﻿<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ProductoActualizar.aspx.vb" Inherits="UI.ProductoActualizar" %>

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
            <h2>Actualizar Producto</h2>
            <br />
            <br />
            <br />
        </div>
    <div align="center">
    
        <asp:Label ID="lblIDProducto" runat="server" Text="ID Producto" style="display: inline-block;
    width: 90px;"></asp:Label>
        <asp:TextBox ID="txtIDProducto" runat="server"></asp:TextBox>
        <br />
        <asp:RequiredFieldValidator ID="rfvIDProducto" runat="server" ControlToValidate="txtIDProducto" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Label ID="lblDescripcion" runat="server" Text="Descripción" style="display: inline-block;
    width: 90px;"></asp:Label>
        <asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox>
        <br />
        <asp:RequiredFieldValidator ID="rfvDescripcion" runat="server" ControlToValidate="txtDescripcion" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Label ID="lblPrecio" runat="server" Text="Precio unidad" style="display: inline-block;
    width: 90px;"></asp:Label>
        <asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox>
        <br />
        <asp:RequiredFieldValidator ID="rfvPrecio" runat="server" ControlToValidate="txtPrecio" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>
        <br />
        <asp:RegularExpressionValidator ID="revPrecio" runat="server" ErrorMessage="Utilice números válidos" ControlToValidate="txtPrecio" ValidationExpression="^[0-9]*"></asp:RegularExpressionValidator>
        <br />
        <br />
        <asp:Label ID="lblCantidad" runat="server" Text="Cantidad" style="display: inline-block;
    width: 90px;" Width="118px"></asp:Label>
        <asp:TextBox ID="txtCantidad" runat="server"></asp:TextBox>
        <br />
        <asp:RequiredFieldValidator ID="rfvCantidad" runat="server" ControlToValidate="txtCantidad" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>
        <br />
        <asp:RegularExpressionValidator ID="revCantidad" runat="server" ErrorMessage="Utilice únicamente números" ControlToValidate="txtCantidad" ValidationExpression="^[0-9]*"></asp:RegularExpressionValidator>
        <br />
        <br />
        <br />
        <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" Width="157px" />
        <br />
        <br />
        <asp:Button ID="btnBuscar" runat="server" Text="Buscar" Width="157px" />
        <br />
        <br />
        <asp:Button ID="btnMostrarClientes" runat="server" Height="23px" Text="Mostrar todos los ptoductos" Width="157px" />
        <br />
        <br />
        <asp:Button ID="btnInicio" runat="server" Text="Inicio" Width="157px" />
        <br />
        <br />
        <asp:Label ID="lblMensaje" runat="server"></asp:Label>
        <br />
    </div>
    </form>
</body>
</html>
