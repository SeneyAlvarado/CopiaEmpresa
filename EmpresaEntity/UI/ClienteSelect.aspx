<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ClienteSelect.aspx.vb" Inherits="UI.ClienteSelect" %>

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
            <br />
            <br />
        </div>
   
        
         <div align="center">
             <asp:GridView ID="grdClientes" runat="server"></asp:GridView>
             <br />
             <asp:Button ID="btnInicio" runat="server" Text="Inicio" />
     </div>
    </form>
</body>
</html>
