Imports BL
Public Class DetalleFactura
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        Response.Redirect("Home.aspx")
    End Sub

    Protected Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Dim factura As Integer = Integer.Parse(txtFactura.Text.Trim())

        Dim detalles As New Detalle_FacturaBL()
        Dim lista As New List(Of Detalle_FacturaBL)
        lista = detalles.obtenerDetalles(Integer.Parse(txtFactura.Text.Trim()))

        Dim table As New DataTable()

        table.Columns.Add("Factura")
        table.Columns.Add("Producto")
        table.Columns.Add("Cantidad")

        Dim row As DataRow
        For i = 0 To lista.Count - 1
            row = table.NewRow()
            row("Factura") = lista(i).Consecutivo_Factura
            row("Producto") = lista(i).Codigo_Producto
            row("Cantidad") = lista(i).Cantidad

            table.Rows.Add(row)
        Next
        grdDetalleFactura.DataSource = table
        grdDetalleFactura.DataBind()
    End Sub
End Class