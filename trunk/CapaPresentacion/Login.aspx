<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link href="Styles/Site.css" rel="stylesheet" type="text/css" />
    <script src="Scripts/jquery-1.4.1.min.js"></script>
    <script>
        $(document).ready(function () {
            $("#btnAceptar").click(function () {
                $("#btnIngresar").click();
            });
        }
        );
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div class="page">
        <div class="header" style="height:60px;">
            
        </div>
        <div  style="text-align: center;">
             <!--   <img src="img/imgNaviTrans.jpg" alt="imgNaviTrans.jpg"/> -->
            </div>
        <br /><br />
        <div class="main_loguin">
            <div  class="sub_bloque_login">
                <div id="cabecera_login">Sistema de Reserva de Citas Odontológicas</div>
                <br />
                <div class="Textos_Login">Usuario :</div><div class="Controles_Login"><asp:TextBox ID="txtUsuario" runat="server" Width="150px"></asp:TextBox><label id="val1" style="color:Red;display:none">*</label></div>
                <div class="Textos_Login">Clave de Acceso :</div>
                <div class="Controles_Login">
                <asp:TextBox ID="txtClave" runat="server" Width="150px" TextMode="Password"></asp:TextBox><label id="val2" style="color:Red;display:none">*</label></div>
                
                
                <div class="Textos_Login" >
                    <asp:Button id="btnIngresar" runat="server" Text="Ingresar" style="display:none;" 
                    OnClientClick="return valBlanco();" onclick="btnIngresar_Click" 
                        ClientIDMode="Static" />
                </div>
                <div class="Controles_Login" style="text-align:right;width:160px;" >
                    <div id="btnAceptar" class="boton_login">Ingresar</div>
                </div>
            </div>
            <div style="text-align: center;">
            <asp:Label ID="lblMensaje" runat="server" ForeColor="Red"></asp:Label>
        </div>
        </div>
        
        <div class="footer">
        </div>
    </div>
    </form>
</body>
</html>
<script language="javascript" type="text/javascript">
    function valBlanco() {
        var usuario = document.getElementById("<%=txtUsuario.ClientID %>")
        var clave = document.getElementById("<%=txtClave.ClientID %>")
        var val1 = document.getElementById("val1")
        var val2 = document.getElementById("val2")
        var bol = true;

        if (usuario.value == "") {
            val1.style.display = 'inline';
            bol = false;
        } else {
            val1.style.display = 'none';
        }

        if (clave.value == "") {
            val2.style.display = 'inline';
            bol = false;
        } else {
            val2.style.display = 'none';
        }

        return bol;
    }
</script>
