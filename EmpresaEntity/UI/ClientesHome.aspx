﻿<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ClientesHome.aspx.vb" Inherits="UI.ClientesHome" %>

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
    
        <h2>Clientes</h2>
    <br />
    </div>
    <div align="center">
        <asp:Button ID="btnInsertar" runat="server" Text="Insertar" Width="180px" />
        <br />
        <br />
        <br />
        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" Width="180px" />
        <br />
        <br />
        <br />
        <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" Width="180px" />
        <br />
        <br />
        <br />
        <asp:Button ID="btnMostrar" runat="server" Text="Mostrar todos los clientes" Width="180px" />
        <br />
        <br />
        <br />
        <asp:Button ID="btnAtras" runat="server" Text="Atrás" Width="180px"/>
    </div>
    </form>
</body>
</html>
