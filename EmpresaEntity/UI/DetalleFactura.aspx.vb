Imports BL
Public Class DetalleFactura
    Inherits System.Web.UI.Page

    Dim table As New DataTable()
    Dim detalles As New Detalle_FacturaBL()

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack Then
            table = ViewState("detalles")
            grdDetalleFactura.DataSource = table
            grdDetalleFactura.DataBind()
        Else
            Dim lista As New List(Of FacturaBL)
            lista = Session("ListaFacturas")

            cbFactura.AutoPostBack = True
            cbFactura.DataValueField = "Consecutivo"
            cbFactura.DataTextField = "Consecutivo"
            cbFactura.DataSource = lista
            cbFactura.DataBind()

            table.Columns.Add("Factura")
            table.Columns.Add("Producto")
            table.Columns.Add("Cantidad")
            ViewState.Add("detalles", table)


            Dim listaDetalle As New List(Of Detalle_FacturaBL)
            listaDetalle = detalles.obtenerDetalles(Integer.Parse(cbFactura.SelectedValue))

            If listaDetalle.Count >= 1 Then
                For i = 0 To listaDetalle.Count - 1
                    table.Rows.Add(listaDetalle(i).Consecutivo_Factura, listaDetalle(i).Codigo_Producto, listaDetalle(i).Cantidad)
                Next
            End If
            grdDetalleFactura.DataSource = table
            grdDetalleFactura.DataBind()
            ViewState.Add("detalles", table)
        End If


    End Sub

    Protected Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        Response.Redirect("Home.aspx")
    End Sub

    Protected Sub cbFactura_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFactura.SelectedIndexChanged
        Dim factura As Integer = Integer.Parse(cbFactura.SelectedValue)

        Dim detalles As New Detalle_FacturaBL()
        Dim lista As New List(Of Detalle_FacturaBL)
        lista = detalles.obtenerDetalles(factura)
        table.Clear()

        If lista.Count >= 1 Then
            For i = 0 To lista.Count - 1
                table.Rows.Add(lista(i).Consecutivo_Factura, lista(i).Codigo_Producto, lista(i).Cantidad)
            Next
            lblMensaje.Text = ""
        Else
            lblMensaje.Text = "Error, la factura no tiene productos por mostrar"
        End If
        grdDetalleFactura.DataSource = table
        grdDetalleFactura.DataBind()
        ViewState.Add("detalles", table)
    End Sub
End Class