Imports BL
Public Class ProductoBuscar
    Inherits System.Web.UI.Page

    Dim productoBL As New ProductoBL
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtCantidad.Enabled = False
        txtDescripcion.Enabled = False
        txtPrecio.Enabled = False
    End Sub

    Protected Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Dim codigo As String = txtIDProducto.Text.Trim()
            productoBL.buscarProducto(codigo)
            txtCantidad.Text = productoBL.CantidadInventario
            txtDescripcion.Text = productoBL.Descripcion
            txtPrecio.Text = productoBL.PrecioVenta
            lblMensaje.Text = ""
        Catch ex As Exception
            lblMensaje.Text = "El producto consultado no existe"
            txtCantidad.Text = ""
            txtDescripcion.Text = ""
            txtPrecio.Text = ""
        End Try
    End Sub

    Protected Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        Response.Redirect("Home.aspx")
    End Sub
End Class