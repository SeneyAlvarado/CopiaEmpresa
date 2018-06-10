Imports BL

Public Class ProductoActualizar
    Inherits System.Web.UI.Page

    Dim productoBL As New ProductoBL

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtCantidad.Enabled = False
        txtDescripcion.Enabled = False
        txtPrecio.Enabled = False
        rfvCantidad.Enabled = False
        rfvDescripcion.Enabled = False
        rfvPrecio.Enabled = False
        btnActualizar.Enabled = False
    End Sub

    Protected Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        Try
            Dim codigo As String = txtIDProducto.Text.Trim()
            productoBL.buscarProducto(codigo)

            txtCantidad.Text = productoBL.CantidadInventario
            txtDescripcion.Text = productoBL.Descripcion
            txtPrecio.Text = productoBL.PrecioVenta

            txtIDProducto.Enabled = False
            txtCantidad.Enabled = True
            txtDescripcion.Enabled = True
            txtPrecio.Enabled = True
            btnActualizar.Enabled = True
            btnActualizar.Visible = True
            btnBuscar.Enabled = False
            btnBuscar.Visible = False
            rfvCantidad.Enabled = True
            rfvDescripcion.Enabled = True
            rfvPrecio.Enabled = True
            lblMensaje.Text = ""
        Catch ex As Exception
            lblMensaje.Text = "El producto consultado no existe"
        End Try

    End Sub

    Protected Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim codigo As String = txtIDProducto.Text.Trim()
        Dim descripcion As String = txtDescripcion.Text.Trim()
        Dim precio As String = txtPrecio.Text.Trim()
        Dim cantidad As String = txtCantidad.Text.Trim()
        productoBL.actualizarProducto(codigo, descripcion, precio, cantidad)
        lblMensaje.Text = "Los datos se actualizaron correctamente"
    End Sub

    Protected Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        Response.Redirect("Home.aspx")
    End Sub

    Protected Sub btnMostrarProductos_Click(sender As Object, e As EventArgs) Handles btnMostrarProductos.Click
        Response.Redirect("ProductoSeleccionar.aspx")
    End Sub
End Class