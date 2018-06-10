Imports BL
Public Class ClientesDelete
    Inherits System.Web.UI.Page

    Dim clienteBL As New ClienteBL
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            clienteBL.eliminarCliente(txtCedula.Text.Trim)
            lblMensaje.Text = "Cliente eliminado."
        Catch ex As Exception
            lblMensaje.Text = "Error al eliminar el cliente. Es posible que el cliente posea facturación o no exista"
        End Try
    End Sub

    Protected Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        Response.Redirect("Home.aspx")
    End Sub
End Class