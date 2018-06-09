Imports BL
Public Class ProductoInsertar
    Inherits System.Web.UI.Page

    Dim producto As New ProductoBL()

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        Dim id As Integer = Integer.Parse(txtIDProducto.Text.Trim())
        Dim descripcion As String = txtDescripcion.Text.Trim()
        Dim cantidad As Integer = txtCantidad.Text.Trim()
        Dim precio As Double = Double.Parse(txtPrecio.Text.Trim())

    End Sub
End Class