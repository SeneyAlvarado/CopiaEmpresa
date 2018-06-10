<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="FacturaInsertar.aspx.vb" Inherits="UI.FacturaInsertar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-image:url('fondo.jpg'); 
             background-position: center center;	  
	         background-repeat: no-repeat;
	         background-attachment: fixed;
	         background-size: cover;
             width:auto;">
    <form id="form1" runat="server">
     <div align="center">
            <h2>Insertar Factura</h2>
            <br />

        </div>

        <div align="center">
        </div>

         <div style="margin-left: 16px" align="center">

            <asp:Label ID="lblCedula" runat="server" Text="Cédula Cliente" style="display: inline-block;
    width: 125px;"></asp:Label> 

             <asp:TextBox ID="txtCedula" runat="server" style="margin-left: 0px"></asp:TextBox>
        <br />
        <asp:RequiredFieldValidator ID="rfvCedula" runat="server" ControlToValidate="txtCedula" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>
             <br />
             <br />
             <asp:Button ID="btnBuscarCliente" runat="server" Text="Buscar" />
             </div>
        <br/>

         <div align="center">
             <asp:Label ID="lblNombreCliente" runat="server" style="display: inline-block;
    width: 90px; margin-left: 17px;" Width="119px"></asp:Label>
             <br />
             <br />
             <asp:Label ID="lblApellidoCliente" runat="server" style="display: inline-block;
    width: 90px; margin-left: 17px;" Width="119px"></asp:Label>
             <br />
             <br />
             <asp:Label ID="lblCorreoCliente" runat="server" style="display: inline-block;
    width: 90px; margin-left: 17px;" Width="119px"></asp:Label>
             
             <br />
             <br />
             <asp:Label ID="lblTelefono" runat="server" style="display: inline-block;
    width: 90px; margin-left: 17px;" Width="119px"></asp:Label>
             <br />
             <br />
             <asp:Label ID="lblMensaje" runat="server" style="display: inline-block;
    width: 90px; margin-left: 17px;" Width="119px"></asp:Label>
             <br />
             <br />
             </div>
        <div align="center">
             <asp:Label ID="lblIDProducto" runat="server" Text="ID Producto" style="display: inline-block;
    width: 125px;"></asp:Label>
             <asp:TextBox ID="txtIDProduct" runat="server" style="margin-left: 0px"></asp:TextBox>
             <br />
             <asp:RegularExpressionValidator ID="revIDProducto" runat="server" ControlToValidate="txtIDProduct" ErrorMessage="Utilice únicamente números" ValidationExpression="^[0-9]*"></asp:RegularExpressionValidator>
             <br />
             <asp:RequiredFieldValidator ID="rfvIDProducto" runat="server" ControlToValidate="txtIDProduct" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>
             <br />
             <br />
             <asp:Label ID="lblCantidad" runat="server" Text="Cantidad" style="display: inline-block;
    width: 125px;"></asp:Label>
             <asp:TextBox ID="txtCantidad" runat="server"></asp:TextBox>
             <br />
             <asp:RegularExpressionValidator ID="revCantidad" runat="server" ControlToValidate="txtCantidad" ErrorMessage="Utilice únicamente números" ValidationExpression="^[0-9]*"></asp:RegularExpressionValidator>
             <br />
             <asp:RequiredFieldValidator ID="rfvCantidad" runat="server" ControlToValidate="txtCantidad" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>
             <br />
             <br />
             <asp:Button ID="btnAgregarProducto" runat="server" Text="Agregar Producto" Width="134px" />
             <br />
             <br />
             <br />
             <asp:GridView ID="grdDetalleFactura" runat="server">
             </asp:GridView>
             <br />
             <br />
             <asp:Button ID="btnGenerarFactura" runat="server" Text="Generar Factura" width="142px"/>
             <br />
             <br />
             <asp:Button ID="btnRegresar" runat="server" Text="Regresar" Width="142px" CausesValidation="False" />
        </div>
    </form>
</body>
</html>
