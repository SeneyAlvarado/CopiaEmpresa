Imports BL

Public Class ProductoSeleccionar
    Inherits System.Web.UI.Page

    Dim productoBL As New ProductoBL
    Dim productoTabla As New DataTable

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack Then
            productoTabla = ViewState.Item("table")
            grdProductos.DataSource = productoTabla
            grdProductos.DataBind()
            ViewState.Remove("table")
            ViewState.Add("table", productoTabla)
        Else
            productoTabla.Columns.Add("ID")
            productoTabla.Columns.Add("Descripción")
            productoTabla.Columns.Add("Precio")
            productoTabla.Columns.Add("Cantidad")
            productoBL.getProductos(productoTabla)
            grdProductos.DataSource = productoTabla
            grdProductos.DataBind()
            ViewState.Add("table", productoTabla)
        End If
    End Sub

    Protected Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        Response.Redirect("Home.aspx")
    End Sub
End Class