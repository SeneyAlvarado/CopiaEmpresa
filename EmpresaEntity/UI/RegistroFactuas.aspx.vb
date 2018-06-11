Imports BL
Public Class RegistroFactuas
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        btnDetalleFactura.Enabled = False
        btnDetalleFactura.Visible = False
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
                Dim reporteBL As New ReporteFacturacionBL()
                Dim lista As New List(Of FacturaBL)

                lista = reporteBL.historico(cedula, fechaInicio, fechaFin)

                If lista Is Nothing Or lista.Count = 0 Then
                    lblMensaje.Text = "No hay facturas que mostrar para el cliente"
                Else
                    Dim table As New DataTable()

                    table.Columns.Add("Cliente")
                    table.Columns.Add("Consecutivo")
                    table.Columns.Add("Fecha")
                    table.Columns.Add("Total Factura")

                    Dim row As DataRow
                    For i = 0 To lista.Count - 1
                        row = table.NewRow()
                        row("Cliente") = lista(i).Cliente
                        row("Consecutivo") = lista(i).Consecutivo
                        row("Fecha") = lista(i).FechaHora
                        row("Total Factura") = lista(i).Total

                        table.Rows.Add(row)
                    Next
                    GridView1.DataSource = table
                    GridView1.DataBind()
                    Dim total As Double = reporteBL.totalFacturas(lista)
                    lblMontoTotal.Text = "El monto total de todas las facturas es de: " & total & "."
                    btnDetalleFactura.Enabled = True
                    btnDetalleFactura.Visible = True
                End If
            End If
        Catch
            lblMensaje.Text = "El cliente no existe"
        End Try
    End Sub

    Protected Sub btnDetalleFactura_Click(sender As Object, e As EventArgs) Handles btnDetalleFactura.Click
        Response.Redirect("DetalleFactura.aspx")
    End Sub
End Class