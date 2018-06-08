Public Class ClienteTO
    Public Property Cedula As String
    Public Property Nombre As String
    Public Property Apellido As String
    Public Property Correo As String
    Public Property Telefono As Integer

    Public Sub New(cedula As String, nombre As String, apellido As String,
                   correo As String, telefono As Integer)
        Me.Cedula = cedula
        Me.Nombre = nombre
        Me.Apellido = apellido
        Me.Correo = correo
        Me.Telefono = telefono
    End Sub

    Public Sub New()

    End Sub
End Class
