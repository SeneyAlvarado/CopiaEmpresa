Imports BL
Public Class ClienteActualizar
    Inherits System.Web.UI.Page

    Dim cliente As New ClienteBL()

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtApellido.Enabled = False
        txtCorreo.Enabled = False
        txtNombre.Enabled = False
        txtTelefono.Enabled = False
        btnActualizar.Enabled = False
        btnActualizar.Visible = False
        RequiredFieldValidator2.Enabled = False
        RequiredFieldValidator3.Enabled = False
        RequiredFieldValidator4.Enabled = False
        RequiredFieldValidator1.Enabled = False


    End Sub

    Protected Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click

    End Sub

    Protected Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim cedula As String = txtCedula.Text.Trim()
        cliente.buscarCliente(cedula)

        txtNombre.Text = cliente.Nombre
        txtApellido.Text = cliente.Apellido
        txtCorreo.Text = cliente.Correo
        txtTelefono.Text = cliente.Telefono

        txtCedula.Enabled = False
        txtNombre.Enabled = True
        txtApellido.Enabled = True
        txtCorreo.Enabled = True
        txtTelefono.Enabled = True
        btnActualizar.Enabled = True
        btnActualizar.Visible = True
        btnBuscar.Enabled = False
        btnBuscar.Visible = False

    End Sub

    Protected Sub btnMostrarClientes_Click(sender As Object, e As EventArgs) Handles btnMostrarClientes.Click
        Response.Redirect("ClienteSelect.aspx")
    End Sub
End Class