Public Class Cars
    Private Shared inventoryCount As Integer
    Private carIdentificationNumber As Integer = 0
    Private carMake As String = String.Empty
    Private carModel As String = String.Empty
    Private carYear As String = String.Empty
    Private carPrice As String = String.Empty
    Private carNew As Boolean = False

    Public Sub New(newCar As Boolean, Price As String, Year As String, Model As String, Make As String)

        Me.New()

        carMake = Make
        carModel = Model
        carYear = Year
        carNew = newCar
        carPrice = Price




    End Sub
    Public Sub New()

        inventoryCount += 1
        carIdentificationNumber = inventoryCount
        ' This call is required by the designer.

        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Public ReadOnly Property Count() As Integer
        Get
            Return inventoryCount

        End Get
    End Property

    Public ReadOnly Property identificationNumber() As Integer
        Get
            Return carIdentificationNumber

        End Get
    End Property

    Public Property NewCar() As Boolean
        Get
            Return carNew
        End Get
        Set(ByVal value As Boolean)
            carNew = value
        End Set

    End Property



    Public Property Model() As String
        Get
            Return carModel
        End Get
        Set(value As String)
            carModel = value
        End Set

    End Property

    Public Property Make() As String
        Get
            Return carMake
        End Get
        Set(value As String)
            carMake = value
        End Set

    End Property

    Public Property Year() As String
        Get
            Return carYear
        End Get
        Set(value As String)
            carYear = value
        End Set

    End Property

    Public Property Price() As String
        Get
            Return carPrice
        End Get
        Set(value As String)
            carPrice = value
        End Set



    End Property

    Public Function GetCar() As String
        Return "Hi i choose the car " & carMake & " " & carModel & " " & carPrice & " " & carYear & ", " & IIf(carNew = True, "This is a new car", "This is not a new car").ToString()

    End Function




End Class
