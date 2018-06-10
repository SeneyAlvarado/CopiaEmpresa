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

        <div>
            <asp:Label ID="lblCedula" runat="server" Text="Cédula Cliente" style="margin-left: 15px"></asp:Label> </div>

         <div style="margin-left: 16px">

             <asp:TextBox ID="txtCedula" runat="server" style="margin-left: 0px"></asp:TextBox>
             <asp:TextBox ID="txtIDProduct" runat="server" style="margin-left: 345px"></asp:TextBox>
        <br />
        <asp:RequiredFieldValidator ID="rfvCedula" runat="server" ControlToValidate="txtCedula" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>
             </div>
        </br>

         <div>
             <asp:Label ID="lblNombreCliente" runat="server" style="display: inline-block;
    width: 90px; margin-left: 17px;" Width="119px"></asp:Label>
             </div>
         </br>
        <div>
             <asp:Label ID="lblApellidoCliente" runat="server" style="display: inline-block;
    width: 90px; margin-left: 17px;" Width="119px"></asp:Label>
             </div>
        </br>

        <asp:Label ID="lblCorreoCliente" runat="server" style="display: inline-block;
    width: 90px; margin-left: 17px;" Width="119px"></asp:Label>
             </div>
        </br>
          </br>
        <asp:Label ID="lblTelefono" runat="server" style="display: inline-block;
    width: 90px; margin-left: 17px;" Width="119px"></asp:Label>
             </div>
        </br>

    </form>
</body>
</html>
