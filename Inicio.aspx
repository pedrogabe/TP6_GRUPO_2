<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="TP6_GRUPO2.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Size="X-Large" Text="Grupo N°2"></asp:Label>
            <br />
            <asp:HyperLink ID="lnkEjercicio1" runat="server" NavigateUrl="~/Ejercicio1.aspx">Ejercicio 1</asp:HyperLink>
            <br />
            <asp:HyperLink ID="lnkEjercicio2" runat="server" NavigateUrl="~/Ejercicio2.aspx">Ejercicio 2</asp:HyperLink>
        </div>
    </form>
</body>
</html>
