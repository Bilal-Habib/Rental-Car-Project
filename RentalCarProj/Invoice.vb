Imports System.Net.Mail

Class Invoice
    Private Sub Invoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelMake.Text = ("Vehicle Make: " & VehicleHire.Make)
        LabelModel.Text = ("Vehicle Model: " & VehicleHire.Model)
        LabelFuelType.Text = ("Fuel Type: " & VehicleHire.FuelType)
        LabelTotalAmount.Text = ("Total (inc.VAT): " & VehicleHire.TotalAmount)

        LabelDate.Text = Date.Now.ToString("dd/MM/yyyy")

        LabelCustomerName.Text = ("Customer Name: " & VehicleHire.CustomerForename + " " + VehicleHire.CustomerSurname)
        LabelContact.Text = ("Customer Contact Number: " & VehicleHire.CustomerContact)
        LabelAddress.Text = ("Customer Address: " & VehicleHire.CustomerAddress)

    End Sub

    Private Sub cmdExitInvoice_Click(sender As Object, e As EventArgs) Handles cmdExitInvoice.Click
        Me.Hide()
        MainFormMenu.Show()
    End Sub

    Private Function TakeScreenShot(ByRef Control As Control) As Bitmap
        Dim tmpImg As New Bitmap(Control.Width, Control.Height)
        Using g As Graphics = Graphics.FromImage(tmpImg)
            g.CopyFromScreen(Control.PointToScreen(New Point(1, 1)), New Point(1, 1), New Size(Control.Width, Control.Height))
        End Using
        Return tmpImg
    End Function

    Private Sub cmdPrintInvoice_Click(sender As Object, e As EventArgs) Handles cmdPrintInvoice.Click
        Try
            Dim counter As Integer
            cmdEmailInvoice.Hide()
            cmdPrintInvoice.Hide()
            TakeScreenShot(Me).Save("screenshot.png", Imaging.ImageFormat.Png)
            counter += 1
            If counter >= 1 Then
                cmdEmailInvoice.Show()
                cmdPrintInvoice.Show()
            End If

            PrintDialog1.Document = PrintDocument1
            PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
            PrintDialog1.AllowSomePages = True

            If PrintDialog1.ShowDialog = DialogResult.OK Then
                PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
                PrintDocument1.Print()
            End If
        Catch ex As Exception
            MessageBox.Show("Please Exit the Page and re-enter to fix the problem")
        End Try
    End Sub

    Private Sub PrintDocument1_PrintPage_1(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        'Image Location
        Dim ImageLocation As Point = New Point(0, 0)
        'Traverse the image
        'Get the image
        Dim path As String = "screenshot.png"
        Dim img As Image = Image.FromFile(path)
        'Draw the image
        e.Graphics.DrawImage(img, ImageLocation)
        'Calculate the location of next image
        ImageLocation.Y += img.Height + 1
    End Sub

    Private Sub cmdEmailInvoice_Click(sender As Object, e As EventArgs) Handles cmdEmailInvoice.Click
        Dim counter As Integer
        cmdEmailInvoice.Hide()
        cmdPrintInvoice.Hide()
        cmdExitInvoice.Hide()
        TakeScreenShot(Me).Save("screenshot.png", Imaging.ImageFormat.Png)
        counter += 1
        If counter >= 1 Then
            cmdEmailInvoice.Show()
            cmdPrintInvoice.Show()
            cmdExitInvoice.Show()
        End If

        Dim EmailInvoice As New MailMessage()
        Try
            EmailInvoice.From = New MailAddress("bilal.habib67@live.com")
            'Enter sender's email
            EmailInvoice.To.Add(VehicleHire.CustomerEmail)
            'Sends the email to the email that is held in the customer data grid view
            EmailInvoice.Subject = "Abdul's Vehicle Rental Invoice"
            EmailInvoice.Body = "The Invoice has been sent successfully"
            Dim SMTP As New SmtpClient("smtp.live.com") With {
                .Port = 587,
                .EnableSsl = True,
                .Credentials = New Net.NetworkCredential("bilal.habib67@live.com", "B2theizzo2001")
            }
            'Initialises a New instance of the SmtpClient class that send e-mail by using the speicified smtp server
            Dim InvoiceAttatchment As Attachment
            InvoiceAttatchment = New Attachment("screenshot.png")
            EmailInvoice.Attachments.Add(InvoiceAttatchment)
            SMTP.Send(EmailInvoice)
            MessageBox.Show("Email Sent Successfully")
        Catch ex As Exception
            MessageBox.Show("Email Failed To Send Due To The Following Error")
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class