Imports BL
Public Class FacturaInsertar
    Inherits System.Web.UI.Page

    Dim clienteBL As New ClienteBL
    Dim facturaBL As New FacturaBL
    Dim productoBL As New ProductoBL
    Dim detalleFacturaBL As New Detalle_FacturaBL
    Dim tablaProductos As New DataTable()

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack Then
            tablaProductos = ViewState.Item("productos")
            grdDetalleFactura.DataSource = tablaProductos
            grdDetalleFactura.DataBind()
        Else
            tablaProductos.Columns.Add("ID")
            tablaProductos.Columns.Add("Descripcion")
            tablaProductos.Columns.Add("Precio unitario")
            tablaProductos.Columns.Add("Cantidad solicitada")
            tablaProductos.Columns.Add("Subtotal")
            grdDetalleFactura.DataSource = tablaProductos
            grdDetalleFactura.DataBind()
            ViewState.Add("productos", tablaProductos)

            txtIDProduct.Enabled = False
            txtCantidad.Enabled = False
            btnAgregarProducto.Enabled = False
            btnAgregarProducto.Visible = False
            btnGenerarFactura.Enabled = False
            btnGenerarFactura.Visible = False
            revCantidad.Enabled = False
            rfvCantidad.Enabled = False
            revIDProducto.Enabled = False
            rfvIDProducto.Enabled = False
            btnCrearFactura.Enabled = False
            btnBuscarProducto.Enabled = False
            btnAgregarProducto.Enabled = False
        End If

    End Sub

    Protected Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Response.Redirect("Home.aspx")
    End Sub

    Protected Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        Try
            Dim cedula As String = txtCedula.Text.Trim()
            clienteBL.buscarCliente(cedula)
            lblNombreCliente.Text = "Nombre: " & clienteBL.Nombre
            lblApellidoCliente.Text = "Apellido: " & clienteBL.Apellido
            lblCorreoCliente.Text = "Correo: " & clienteBL.Correo
            lblTelefono.Text = "Teléfono: " & clienteBL.Telefono
            lblMensaje.Text = ""
            btnCrearFactura.Enabled = True
            btnBuscarCliente.Enabled = False
            txtCedula.Enabled = False
        Catch ex As Exception
            btnCrearFactura.Enabled = False
            lblMensaje.Text = "El cliente no existe"
            lblNombreCliente.Text = ""
            lblApellidoCliente.Text = ""
            lblCorreoCliente.Text = ""
            lblTelefono.Text = ""
        End Try
    End Sub

    Protected Sub btnCrearFactura_Click(sender As Object, e As EventArgs) Handles btnCrearFactura.Click
        facturaBL.agregarFactura(txtCedula.Text.Trim)
        txtIDProduct.Enabled = True
        revIDProducto.Enabled = True
        rfvIDProducto.Enabled = True
        btnAgregarProducto.Enabled = True
        btnCrearFactura.Enabled = False
        txtCantidad.Enabled = True
        revCantidad.Enabled = True
        rfvCantidad.Enabled = True
        btnBuscarProducto.Enabled = True
        ViewState.Add("facturaConsecutivo", facturaBL.Consecutivo)
        ViewState.Add("facturaTotal", facturaBL.Total)
    End Sub

    Protected Sub btnAgregarProducto_Click(sender As Object, e As EventArgs) Handles btnAgregarProducto.Click
        Try
            productoBL.Codigo = ViewState.Item("productoCodigo")
            productoBL.CantidadInventario = ViewState.Item("productoCantidad")
            productoBL.Descripcion = ViewState.Item("productoDescripcion")
            productoBL.PrecioVenta = ViewState.Item("productoPrecio")
            facturaBL.Consecutivo = ViewState.Item("facturaConsecutivo")
            facturaBL.Total = ViewState.Item("facturaTotal")

            detalleFacturaBL.agregarDetalle(facturaBL.Consecutivo, productoBL.Codigo, txtCantidad.Text.Trim)
            Dim totalProd As Double = productoBL.PrecioVenta * Integer.Parse(txtCantidad.Text.Trim)
            tablaProductos.Rows.Add(productoBL.Codigo, productoBL.Descripcion, productoBL.PrecioVenta, txtCantidad.Text, totalProd)
            facturaBL.actualizarTotalFactura(totalProd)

            btnAgregarProducto.Enabled = False

            lblMensaje.Text = "Producto agregado"
            ViewState.Remove("productos")
            ViewState.Add("productos", tablaProductos)
            grdDetalleFactura.DataSource = tablaProductos
            grdDetalleFactura.DataBind()
            lblMensaje.Text = "Producto añadido a la factura"
        Catch ex As Exception
            lblMensaje.Text = "Error, no existe suficiente cantidad de productos"
        End Try
    End Sub

    Protected Sub btnBuscarProducto_Click(sender As Object, e As EventArgs) Handles btnBuscarProducto.Click
        Try
            productoBL.buscarProducto(txtIDProduct.Text.Trim)
            btnAgregarProducto.Visible = True
            btnAgregarProducto.Enabled = True
            ViewState.Add("productoCodigo", productoBL.Codigo)
            ViewState.Add("productoDescripcion", productoBL.Descripcion)
            ViewState.Add("productoCantidad", productoBL.CantidadInventario)
            ViewState.Add("productoPrecio", productoBL.PrecioVenta)
            lblMensaje.Text = productoBL.Descripcion & " Cantidad: " & productoBL.CantidadInventario
        Catch ex As Exception
            lblMensaje.Text = "El producto buscado no existe"
        End Try
    End Sub
End Class