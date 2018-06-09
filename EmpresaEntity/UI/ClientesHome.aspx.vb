Public Class ClientesHome
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        Response.Redirect("ClienteInsertar.aspx")
    End Sub

    Protected Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Response.Redirect("ClienteSelect.aspx")
    End Sub

    Protected Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Response.Redirect("ClienteActualizar.aspx")
    End Sub

    Protected Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Response.Redirect("ClientesEliminar.aspx")
    End Sub

    Protected Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Response.Redirect("Home.aspx")
    End Sub
End Class