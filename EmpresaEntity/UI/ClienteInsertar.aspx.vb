Imports BL

Public Class ClienteInsertar
    Inherits System.Web.UI.Page
    Dim cliente As New ClienteBL()
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        Dim cedula As String = txtCedula.Text.Trim()
        Dim nombre As String = txtNombre.Text.Trim()
        Dim apellido As String = txtApellido.Text.Trim()
        Dim correo As String = txtCorreo.Text.Trim()
        Dim telefono As Integer = Integer.Parse(txtTelefono.Text.Trim())
        cliente.agregarCliente(cedula, nombre, apellido, correo, telefono)
        lblMensaje.Text = "Transaccion finalizada"
    End Sub

    Protected Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        Response.Redirect("Home.aspx")
    End Sub
End Class