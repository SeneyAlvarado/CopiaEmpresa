Imports BL
Public Class ClienteBuscar
    Inherits System.Web.UI.Page

    Dim cliente As New ClienteBL()
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtApellido.Enabled = False
        txtCorreo.Enabled = False
        txtNombre.Enabled = False
        txtTelefono.Enabled = False
    End Sub

    Protected Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Dim cedula As String = txtCedula.Text.Trim()
            cliente.buscarCliente(cedula)

            txtNombre.Text = cliente.Nombre
            txtApellido.Text = cliente.Apellido
            txtCorreo.Text = cliente.Correo
            txtTelefono.Text = cliente.Telefono
            lblMensaje.Text = ""
        Catch ex As Exception
            lblMensaje.Text = "El cliente no existe"
            txtNombre.Text = ""
            txtApellido.Text = ""
            txtCorreo.Text = ""
            txtTelefono.Text = ""
        End Try

    End Sub

    Protected Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        Response.Redirect("Home.aspx")
    End Sub
End Class