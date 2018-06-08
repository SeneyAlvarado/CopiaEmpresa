Public Class Home
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        Response.Redirect("ClientesHome.aspx")
    End Sub
End Class