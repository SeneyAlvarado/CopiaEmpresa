Public Class FacturaInsertar
    Inherits System.Web.UI.Page

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

    End Sub

    Protected Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Response.Redirect("Home.aspx")
    End Sub
End Class