Imports BL
Public Class DeleteProducto
    Inherits System.Web.UI.Page

    Dim productoBL As New ProductoBL
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            productoBL.eliminarProducto(txtCodigo.Text.Trim)
            lblMensaje.Text = "Producto eliminado."
        Catch ex As Exception
            lblMensaje.Text = "Error al eliminar el producto. Verifique que el producto exista"
        End Try

    End Sub

    Protected Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        Response.Redirect("Home.aspx")
    End Sub
End Class