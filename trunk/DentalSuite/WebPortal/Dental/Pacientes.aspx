<%@ Page Title="" Language="C#" MasterPageFile="~/master/Principal.master" AutoEventWireup="true" CodeFile="Pacientes.aspx.cs" Inherits="Dental_Pacientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
        <link href="<%= ResolveClientUrl("~/Styles/General/jqgrid.ui.css") %>" rel="stylesheet" type="text/css" />
        <link href="<%= ResolveClientUrl("~/Styles/General/jquery.autocomplete.css") %>" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <script src="<%= ResolveClientUrl("~/Scripts/General/jquery.autocomplete.min.js") %>" type="text/javascript"></script>
    <script src="<%= ResolveClientUrl("~/Scripts/Dental/DentalPacientes.js") %>" type="text/javascript"></script>
    <br />
        <br />
            <div id="caja">
                         <table style="width: 900px">
                                <tr>
                                    <td width="200px" >
                                        Nombre :&nbsp;
                                    </td>
                                    <td width="100px" >
                                        <input type="text" id="txtNombre" runat="server"/></td>
                                    <td width="50px"  style="vertical-align: bottom" >
                                        
                                        &nbsp;</td>
                                    <td style="vertical-align: bottom" >
                                        
                                        Sexo:</td>
                                    <td style="vertical-align: bottom" >
                                        M
                                    <input type="radio" name="sex" id="m" value="20" runat="server"/>
                                        F
                                    <input type="radio" name="sex" id="f" value="20" runat="server"/>
                                    </td>
                                </tr>
                                <tr>
                                    <td width="200px" >
                                        Ap. Paterno:</td>
                                    <td width="100px" >
                                        <input type="text" id="txtApellidoPaterno" runat="server"  /></td>
                                    <td style="vertical-align: bottom" >
                                        
                                        &nbsp;</td>
                                    <td style="vertical-align: bottom" >
                                        
                                        Tipo de Documento</td>
                                    <td style="vertical-align: bottom" >
                                        
                                        <input type="text" id="txtTipoDocumento" /></td>
                                </tr>
                                <tr>
                                    <td width="200px" >
                                        Ap. Materno:</td>
                                    <td width="100px" >
                                        <input type="text" id="txtApellidoMaterno"  runat="server"/></td>
                                    <td style="vertical-align: bottom" >
                                        
                                        &nbsp;</td>
                                    <td style="vertical-align: bottom" >
                                        
                                        Numero de Documento</td>
                                    <td style="vertical-align: bottom" >

                                        
                                        <input type="text" id="txtNroDocumento"  runat="server"/></td>
                                </tr>
                                <tr>
                                    <td width="200px" >
                                        correo:</td>
                                    <td width="100px" >
                                        <input type="text" id="txtCorreo"  runat="server" /></td>
                                    <td style="vertical-align: bottom" >
                                        
                                        &nbsp;</td>
                                    <td style="vertical-align: bottom" >
                                        
                                        &nbsp;</td>
                                    <td style="vertical-align: bottom" >
                                        
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td width="200px" >
                                        Confirmar Correo:</td>
                                    <td width="100px" >
                                        <input type="text" id="txtConfirmarCorreo" runat="server"  /></td>
                                    <td style="vertical-align: bottom" >
                                        
                                        &nbsp;</td>
                                    <td style="vertical-align: bottom" >
                                        
                                        &nbsp;</td>
                                    <td style="vertical-align: bottom" >
                                        
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td width="200px" >
                                        Contraseña</td>
                                    <td width="100px" >
                                        <input type="text" id="txtContrasenia"  runat="server" /></td>
                                    <td style="vertical-align: bottom" >
                                        
                                        &nbsp;</td>
                                    <td style="vertical-align: bottom" >
                                        
                                        &nbsp;</td>
                                    <td style="vertical-align: bottom" >
                                        
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td width="200px" >
                                        Confirmar Contraseña:</td>
                                    <td width="100px" >
                                        <input type="text" id="txtConfirmarContrasenia" runat="server"  /></td>
                                    <td style="vertical-align: bottom" >
                                        
                                        &nbsp;</td>
                                    <td style="vertical-align: bottom" >
                                        
                                        &nbsp;</td>
                                    <td style="vertical-align: bottom" >
                                        
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td width="200px" colspan="5" >
                                        <asp:Label ID="lblMensajeResultado" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td valign="top" width="100px">
                                        </td>
                                    <td class="tblFiltroCeldaValor" colspan="4">
                                    <div style="width:500px;height:50px;position: relative; float: right;">
                                        
                                        <div id="divRegistrarPaciente" style="width:150px;top:30px; left:0px; position: absolute" >
                                            <input id="Button1" type="button" value="Registrar Paciente"  OnServerClick="RegistrarPaciente_Click" runat="server"/>
                                        </div>
                                        <div id="divCancelar" style="width:120px;top:30px; left:200px; position: absolute">
                                        <input id="Button2" type="button" value="Cancelar"  OnServerClick="Cancelar_Click" runat="server"/>
                                            </div>
                                    </div>
                                        
                                        </td>
                                </tr>
                            </table>
            </div>


    <input type="hidden" name="hdnTitulo" id="hdnTitulo" runat="server" />
    <input type="text" id="txtTipoDocumentoHidden" runat="server" style="visibility: hidden" />

</asp:Content>

