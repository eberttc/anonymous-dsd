<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Seguridad_Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Dental Suite</title>
    <link href="<%= ResolveClientUrl("~/Styles/Seguridad/login.css") %>" rel="stylesheet" type="text/css" />
    <link href="<%= ResolveClientUrl("~/Styles/General/jquery.ui.css")%>" rel="stylesheet" type="text/css" />
    <script src="<%= ResolveClientUrl("~/Scripts/General/jquery.min.js") %>" type="text/javascript"></script>
    <script src="<%= ResolveClientUrl("~/Scripts/General/jquery.ui.min.js") %>" type="text/javascript"></script>
    <script src="<%= ResolveClientUrl("~/Scripts/General/jquery.curvycorners.min.js") %>" type="text/javascript"></script>
    <script src="<%= ResolveClientUrl("~/Scripts/Seguridad/toolsString.js") %>" type="text/javascript"></script>
    <script src="<%= ResolveClientUrl("~/Scripts/General/jquery.watermarkinput.js") %>" type="text/javascript"></script>
    <script src="<%= ResolveClientUrl("~/Scripts/Seguridad/SeguridadLogin.js") %>" type="text/javascript"></script>
</head>
<body>
    <div id="LoginBox">
        <form id="frmLogin" runat="server">
        <table width="100%">

            <tr>
                <td align="center">
                    <table width="80%" cellpadding="4px" cellspacing="4px" style="margin-top: 20px">
                        <tr>
                            <td align="left">
                                <b>Usuario:</b>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:TextBox ID="txtUsuario" runat="server" CssClass="inputslogin" />
                            </td>
                        </tr>
                        <tr>
                            <td align="left">
                                <b>Clave:</b>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:TextBox ID="txtContrasena" TextMode="Password" runat="server" CssClass="inputslogin" />
                            </td>
                        </tr>
                        <tr>
                            <td align="right">
                                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Button" 
                                    Visible="False" />
                                <asp:Button ID="btnLogin" runat="server" Text=" Ingresar " OnClick="btnLogin_Click" />
                            </td>
                        </tr>
                        <tr>
                            <td align="center">
                                <asp:Label ID="txtLoginMessage" runat="server" Text=""></asp:Label>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
        <asp:HiddenField ID="hdfToken" runat="server" />
        </form>
    </div>
</body>
</html>
