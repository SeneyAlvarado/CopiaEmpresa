Imports BL
Public Class ProductoInsertar
    Inherits System.Web.UI.Page

    Dim productoBL As New ProductoBL()

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        Dim IdProducto As String = txtIDProducto.Text.Trim()
        Dim cantidad As Integer = Integer.Parse(txtCantidad.Text.Trim())
        Dim descripcion As String = txtDescripcion.Text.Trim()
        Dim precio As Double = Double.Parse(txtPrecio.Text.Trim())
        Try
            productoBL.agregarProducto(IdProducto, descripcion, precio,
                 cantidad)
            lblMensaje.Text = "Transaccion finalizada"
        Catch ex As Exception
            lblMensaje.Text = "Error al insertar. Verifique que los datos sean válidos y que un producto
con ese identificador no exista."
        End Try
    End Sub

    Protected Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        Response.Redirect("Home.aspx")
    End Sub
End Class