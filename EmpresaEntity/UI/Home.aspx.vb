Public Class Home
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        Response.Redirect("ClientesHome.aspx")
    End Sub

    Protected Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        Response.Redirect("Productos.aspx")
    End Sub

    Protected Sub btnFacturas_Click(sender As Object, e As EventArgs) Handles btnFacturas.Click
        Response.Redirect("FacturaInsertar.aspx")
    End Sub

    Protected Sub btnReporteFact_Click(sender As Object, e As EventArgs) Handles btnReporteFact.Click
        Response.Redirect("RegistroFactuas.aspx")
    End Sub
End Class