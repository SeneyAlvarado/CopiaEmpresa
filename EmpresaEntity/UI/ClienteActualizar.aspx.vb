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
        rfvCorreo.Enabled = False
        rfvApellido.Enabled = False
        rfvNombre.Enabled = False
        rfvTelefono.Enabled = False


    End Sub

    Protected Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim cedula As String = txtCedula.Text.Trim()
        Dim nombre As String = txtNombre.Text.Trim()
        Dim apellido As String = txtApellido.Text.Trim()
        Dim correo As String = txtCorreo.Text.Trim()
        Dim telefono As Integer = Integer.Parse(txtTelefono.Text.Trim())
        cliente.actualizarCliente(cedula, nombre, apellido, correo, telefono)
        lblMensaje.Text = "Los datos se actualizaron correctamente"
    End Sub

    Protected Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
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
            rfvCorreo.Enabled = True
            rfvApellido.Enabled = True
            rfvNombre.Enabled = True
            rfvTelefono.Enabled = True
            lblMensaje.Text = ""
        Catch ex As Exception
            lblMensaje.Text = "El cliente no existe"
        End Try


    End Sub

    Protected Sub btnMostrarClientes_Click(sender As Object, e As EventArgs) Handles btnMostrarClientes.Click
        Response.Redirect("ClienteSelect.aspx")
    End Sub

    Protected Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        Response.Redirect("Home.aspx")
    End Sub
End Class