<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="DetalleFactura.aspx.vb" Inherits="UI.DetalleFactura" %>

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
        <br />
    <h2>Detalle Factura</h2>

        <br />
        <asp:Label ID="lblFactura" runat="server" Text="Número de Factura" style="display: inline-block;
    width: 130px;" Width="100px"></asp:Label>
        <asp:TextBox ID="txtFactura" runat="server"></asp:TextBox>
        <br />
        <asp:RequiredFieldValidator ID="rfvFactura" runat="server" ErrorMessage="Campo Requerido" ControlToValidate="txtFactura"></asp:RequiredFieldValidator>
        <br />
        <asp:RegularExpressionValidator ID="revFactura" runat="server" ErrorMessage="Utilice solamente números" ValidationExpression="^[0-9]*" ControlToValidate="txtFactura"></asp:RegularExpressionValidator>
        <br />
        <br />
        <asp:Button ID="btnMostrar" runat="server" Text="Mostrar" />
        <br />
        <br />
        <asp:GridView ID="grdDetalleFactura" runat="server">
        </asp:GridView>
        <br />
        <br />
        <asp:Button ID="btnInicio" runat="server" Text="Inicio" Width="64px" />

    </div>
    </form>
</body>
</html>
