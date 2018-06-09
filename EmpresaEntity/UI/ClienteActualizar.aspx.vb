Public Class ClienteActualizar
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtApellido.Enabled = False
        txtCorreo.Enabled = False
        txtNombre.Enabled = False
        txtTelefono.Enabled = False
        btnActualizar.Enabled = False
        btnActualizar.Visible = False
    End Sub

    Protected Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click

    End Sub
End Class