<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ClienteInsertar.aspx.vb" Inherits="UI.ClienteInsertar" %>

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
            <h2>Insertar Cliente</h2>
            <br />
            <br />
            <br />
        </div>
    <div align="center">
    
        <asp:Label ID="lblCedula" runat="server" Text="Cédula" style="display: inline-block;
    width: 90px;"></asp:Label>
        <asp:TextBox ID="txtCedula" runat="server"></asp:TextBox>
        <br />
        <asp:RequiredFieldValidator ID="rfvCedula" runat="server" ControlToValidate="txtCedula" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Label ID="lblNombre" runat="server" Text="Nombre" style="display: inline-block;
    width: 90px;"></asp:Label>
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <br />
        <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ControlToValidate="txtNombre" ErrorMessage="Campo requerido"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Label ID="lblApellido" runat="server" Text="Apellido" style="display: inline-block;
    width: 90px;"></asp:Label>
        <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
        <br />
        <asp:RequiredFieldValidator ID="rfvApellido" runat="server" ControlToValidate="txtApellido" ErrorMessage="Campo requerido"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Label ID="lblCorreo" runat="server" Text="Correo" style="display: inline-block;
    width: 90px;"></asp:Label>
        <asp:TextBox ID="txtCorreo" runat="server"></asp:TextBox>
        <br />
        <asp:RequiredFieldValidator ID="rfvCorreo" runat="server" ControlToValidate="txtCorreo" ErrorMessage="Campo requerido"></asp:RequiredFieldValidator>
        <br />
        <asp:RegularExpressionValidator ID="revCorreo" runat="server" ErrorMessage="Utilice el formato correcto" ControlToValidate="txtCorreo" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        <br />
        <br />
        <asp:Label ID="lblTelefono" runat="server" Text="Telefono" style="display: inline-block;
    width: 90px;"></asp:Label>
        <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
        <br />
        <asp:RequiredFieldValidator ID="rfvTelefono" runat="server" ControlToValidate="txtTelefono" ErrorMessage="Campo requerido"></asp:RequiredFieldValidator>
        <br />
        <asp:RegularExpressionValidator ID="revTelefono" runat="server" ErrorMessage="Utilice únicamente números" ControlToValidate="txtTelefono" ValidationExpression="^[0-9]*"></asp:RegularExpressionValidator>
        <br />
        <br />
        <br />
        <asp:Button ID="btnInsertar" runat="server" Text="Insertar" style="height: 26px" />
        <br />
        <br />
        <asp:Button ID="btnInicio" runat="server" CausesValidation="False" Text="Inicio" Width="63px" />
        <br />
        <br />
        <asp:Label ID="lblMensaje" runat="server"></asp:Label>
        <br />
    
    </div>
    </form>
</body>
</html>
