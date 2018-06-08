<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Home.aspx.vb" Inherits="UI.Home" %>

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
            <div>
                <h1>Inicio</h1>
            </div>
    <div>
    
        
            <br />
            <br />
            <asp:Button ID="btnClientes" runat="server" Text="Clientes" Width="157px"/>
            <br />
            <br />
            <br />
            <asp:Button ID="btnProductos" runat="server" Text="Productos" Width="157px" />
            <br />
            <br />
            <br />
            <asp:Button ID="btnFacturas" runat="server" Text="Facturas" Width="157px" />
            <br />
            <br />
            <br />
            <asp:Button ID="btnReporteFact" runat="server" Text="Registro Facturas" Width="157px" />
            <br />
        </div>
    
    </div>
    </form>
</body>
</html>
