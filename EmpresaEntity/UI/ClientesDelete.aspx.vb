Imports BL
Public Class ClientesDelete
    Inherits System.Web.UI.Page

    Dim clienteBL As New ClienteBL
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        clienteBL.eliminarCliente(txtCedula.Text.Trim)
        lblMensaje.Text = "Cliente eliminado."
    End Sub
End Class