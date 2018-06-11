Imports BL
Public Class RegistroFactuas
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Response.Redirect("Home.aspx")
    End Sub

    Protected Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Try
            Dim cliente As New ClienteBL()
            Dim cedula As String = txtCliente.Text.Trim()
            Dim fechaInicio As String = txtFechaInicio.Text.Trim()
            Dim fechaFin As String = txtFechaFin.Text.Trim()

            cliente.buscarCliente(txtCliente.Text.Trim())

            If (fechaFin.CompareTo(fechaInicio) < 0) Then
                lblMensaje.Text = "La fecha final NO puede ser menor a la fecha de inicio"
            Else
                lblMensaje.Text = "La fecha de inicio es menor a la fecha final"
            End If

        Catch
            lblMensaje.Text = "El cliente no existe"
        End Try
    End Sub
End Class