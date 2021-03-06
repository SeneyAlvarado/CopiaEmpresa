﻿<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="RegistroFactuas.aspx.vb" Inherits="UI.RegistroFactuas" %>

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
    <h1>Reporte Factura</h1>
    </div>
        <div align="center">

            <br />
            <br />
            <asp:Label ID="lblCliente" runat="server" Text="Cédula Cliente" style="display: inline-block;
    width: 125px;"></asp:Label>
            <asp:TextBox ID="txtCliente" runat="server"></asp:TextBox>
            <br />
            <asp:RequiredFieldValidator ID="rfvCedula" runat="server" ErrorMessage="Campo Requerido" ControlToValidate="txtCliente"></asp:RequiredFieldValidator>
            <br />
            <br />

            <asp:Label ID="lblFechaInicio" runat="server" Text="Fecha Inicio" style="display: inline-block;
    width: 125px;"></asp:Label>
            <!--input type="date" name="FechaInicio" min="01-01-1900" max="31-12-2099" required="required" id="inputFechaInicio"/-->
            <asp:TextBox ID="txtFechaInicio" runat="server" TextMode="Date"></asp:TextBox>
            <br />
            <asp:RequiredFieldValidator ID="rfvFechaInicio" runat="server" ErrorMessage="Campo Requerido" ControlToValidate="txtFechaInicio"></asp:RequiredFieldValidator>
            <br />
            <br />
            <br />

            <asp:Label ID="lblFechaFin" runat="server" Text="Fecha Fin" style="display: inline-block;
    width: 125px;"></asp:Label>
            <asp:TextBox ID="txtFechaFin" runat="server" TextMode="Date"></asp:TextBox>
                      
            <br />  <asp:RequiredFieldValidator ID="rfvFechaFin" runat="server" ErrorMessage="Campo Requerido" ControlToValidate="txtFechaFin"></asp:RequiredFieldValidator>

            <!--input type="date" name="FechaFin" min="01-01-1900" max="31-12-2099" required="required" id="inputFechaFin"/-->
            <br />
            <br />
            <br />
            <asp:Button ID="btnConsultar" runat="server" Text="Consultar" />
            <br />
            <br />
            <asp:Button ID="btnRegresar" runat="server" CausesValidation="False" Text="Regresar" Width="83px" ValidationGroup="noVali" />
            <br />
            <br />
            <asp:Label ID="lblMensaje" runat="server"></asp:Label>
            <br />
            <br />
            <asp:GridView ID="grdFacturas" runat="server">
            </asp:GridView>
            <br />
            <asp:Label ID="lblMontoTotal" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnDetalleFactura" runat="server" CausesValidation="False" Text="Mostrar detalle factura" />
            <br />


        </div>
    </form>
</body>
</html>
