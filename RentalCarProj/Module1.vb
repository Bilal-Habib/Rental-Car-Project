Module Module1
    Structure Customer
        Dim ID As Integer
        Dim Forename As String
        Dim Surname As String
        Dim Contact As Long
        Dim Address As String
        Dim Email As String
    End Structure
    'Creates a Structure For customers

    Structure Vehicle
        Dim ID As String
        Dim Make As String
        Dim Model As String
        Dim CostPerDay As String
        Dim FuelType As String
        Dim MaunualOrAutomatic As String
    End Structure
    'Creates a Structure For Vehicles

    Structure Staff
        Dim ID As String
        Dim Forename As String
        Dim Surname As String
        Dim Username As String
        Dim Password As String
        Dim AuthorityLevel As String
    End Structure
    'Creates a Structure for Staff

    Public Const MaxNumOfRecords As Integer = 9
    Public sep As String = ","

    Public CustomerDatabase(MaxNumOfRecords) As Customer
    Public NumOfCustomers As Integer = 0
    Public Customerfilename As String = "CustomerDatabase.csv"
    'Setting the number of records that the database can hold
    'Attaching the file name to a string to make it easier type up

    Public VehicleDatabase(MaxNumOfRecords) As Vehicle
    Public NumOfVehicles As Integer = 0
    Public VehicleFilename As String = "VehicleDatabase.csv"

    Public StaffDatabase(MaxNumOfRecords) As Staff
    Public NumOfStaff As Integer = 0
    Public StaffFilename As String = "StaffDatabase.csv"
End Module
