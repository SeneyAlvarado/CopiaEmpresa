Imports BL
Public Class FacturaInsertar
    Inherits System.Web.UI.Page

    Dim cliente As New ClienteBL

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtIDProduct.Enabled = False
        txtCantidad.Enabled = False
        btnAgregarProducto.Enabled = False
        btnAgregarProducto.Visible = False
        btnGenerarFactura.Enabled = False
        btnGenerarFactura.Visible = False
        revCantidad.Enabled = False
        revIDProducto.Enabled = False
        rfvCantidad.Enabled = False
        revIDProducto.Enabled = False
        rfvIDProducto.Enabled = False
    End Sub

    Protected Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Response.Redirect("Home.aspx")
    End Sub

    Protected Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        Try
            Dim cedula As String = txtCedula.Text.Trim()
            cliente.buscarCliente(cedula)
            lblNombreCliente.Text = "Nombre: " & cliente.Nombre
            lblApellidoCliente.Text = "Apellido: " & cliente.Apellido
            lblCorreoCliente.Text = "Correo: " & cliente.Correo
            lblTelefono.Text = "Teléfono: " & cliente.Telefono
            lblMensaje.Text = ""
        Catch ex As Exception
            lblMensaje.Text = "El cliente no existe"
            lblNombreCliente.Text = ""
            lblApellidoCliente.Text = ""
            lblCorreoCliente.Text = ""
            lblTelefono.Text = ""
        End Try
    End Sub
End Class