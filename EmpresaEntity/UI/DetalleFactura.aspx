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
        <asp:DropDownList ID="cbFactura" runat="server" Width="145px">
        </asp:DropDownList>
        <br />
        <br />
        <br />
        <asp:Label ID="lblMensaje" runat="server"></asp:Label>
        <br />
        <asp:GridView ID="grdDetalleFactura" runat="server">
        </asp:GridView>
        <br />
        <br />
        <asp:Button ID="btnInicio" runat="server" Text="Inicio" Width="64px" CausesValidation="False" />

    </div>
    </form>
</body>
</html>
