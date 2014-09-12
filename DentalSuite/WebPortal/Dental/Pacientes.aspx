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
                                        <input type="text" id="txtNombre"  /></td>
                                    <td width="50px"  style="vertical-align: bottom" >
                                        
                                        &nbsp;</td>
                                    <td style="vertical-align: bottom" >
                                        
                                        Sexo:</td>
                                    <td style="vertical-align: bottom" >
                                        M
                                    <input type="radio" name="sex" id="m" value="20"/>
                                        F
                                    <input type="radio" name="sex id="f" value="20"/>
                                    </td>
                                </tr>
                                <tr>
                                    <td width="200px" >
                                        Ap. Paterno:</td>
                                    <td width="100px" >
                                        <input type="text" id="txtAoellidoPaterno"  /></td>
                                    <td style="vertical-align: bottom" >
                                        
                                        &nbsp;</td>
                                    <td style="vertical-align: bottom" >
                                        
                                        Tipo de Documento</td>
                                    <td style="vertical-align: bottom" >
                                        
                                        <input type="text" id="txtTipoDocumento"  /></td>
                                </tr>
                                <tr>
                                    <td width="200px" >
                                        Ap. Materno:</td>
                                    <td width="100px" >
                                        <input type="text" id="txtApellidoMaterno"  /></td>
                                    <td style="vertical-align: bottom" >
                                        
                                        &nbsp;</td>
                                    <td style="vertical-align: bottom" >
                                        
                                        Numero de Documento</td>
                                    <td style="vertical-align: bottom" >
                                        
                                        <input type="text" id="txtNroDocumento"  /></td>
                                </tr>
                                <tr>
                                    <td width="200px" >
                                        correo:</td>
                                    <td width="100px" >
                                        <input type="text" id="txtApellidoMaterno0"  /></td>
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
                                        <input type="text" id="txtApellidoMaterno1"  /></td>
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
                                        <input type="text" id="txtApellidoMaterno2"  /></td>
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
                                        <input type="text" id="txtApellidoMaterno3"  /></td>
                                    <td style="vertical-align: bottom" >
                                        
                                        &nbsp;</td>
                                    <td style="vertical-align: bottom" >
                                        
                                        &nbsp;</td>
                                    <td style="vertical-align: bottom" >
                                        
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td valign="top" width="100px">
                                        </td>
                                    <td class="tblFiltroCeldaValor" colspan="4">
                                    <div style="width:500px;height:50px;position: relative; float: right;">
                                        
                                        <div id="divRegistrarPaciente" style="width:150px;top:30px; left:0px; position: absolute" >
                                            <input type="button" value="Registrar Paciente"  />
                                        </div>
                                        <div id="divCancelar" style="width:120px;top:30px; left:200px; position: absolute">
                                        <input type="button" value="Cancelar"  />
                                            </div>
                                    </div>
                                        
                                        </td>
                                </tr>
                            </table>
            </div>


    <input type="hidden" name="hdnTitulo" id="hdnTitulo" runat="server" />
    <input type="text" id="txtTipoDocumentoHidden" style="visibility: hidden" />
</asp:Content>

