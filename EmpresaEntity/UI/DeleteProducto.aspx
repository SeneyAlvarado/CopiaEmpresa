<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="DeleteProducto.aspx.vb" Inherits="UI.DeleteProducto" %>

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
            <h2>Eliminar Producto</h2>
            <br />
            <br />
            <br />
        </div>
    <div align="center">
    
        <asp:Label ID="lblCodigo" runat="server" Text="Código" style="display: inline-block;
    width: 90px;"></asp:Label>
        <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
        <br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtCodigo" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
       <br />
        <br />
        <asp:Button ID="btnDelete" runat="server" Text="Eliminar" style="height: 26px" />
        <br />
        <br />
        <asp:Label ID="lblMensaje" runat="server"></asp:Label>
        <br />
    
    </div>
    </form>
</body>
</html>
