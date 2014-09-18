<%@ Page Title="" Language="C#" MasterPageFile="~/master/Principal.master" AutoEventWireup="true" CodeFile="Especialidades.aspx.cs" Inherits="Dental_Especialidades" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
        <link href="<%= ResolveClientUrl("~/Styles/General/jqgrid.ui.css") %>" rel="stylesheet" type="text/css" />
        <link href="<%= ResolveClientUrl("~/Styles/General/jquery.autocomplete.css") %>" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <script src="<%= ResolveClientUrl("~/Scripts/General/jquery.autocomplete.min.js") %>" type="text/javascript"></script>
    <script src="<%= ResolveClientUrl("~/Scripts/Dental/DentalEspecialidades.js") %>" type="text/javascript"></script>   
<br />
        <br />
    <div id="caja">
                         <table style="width: 900px">
                                <tr>
                                    <td width="90px" >
                                        Nombre :&nbsp;
                                    </td>
                                    <td width="100px" >
                                        <input type="text" id="txtNombre"  /></td>
                                    <td width="50px"  style="vertical-align: bottom" >
                                        
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td width="90px" >
                                        Descripcion:</td>
                                    <td width="100px" >
                                        <input type="text" id="txtDescripcion" size="90"  /></td>
                                    <td style="vertical-align: bottom" >
                                        
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td valign="top" width="100px">
                                        </td>
                                    <td class="tblFiltroCeldaValor" colspan="2">
                                    <div style="width:500px;height:50px;position: relative; float: right;">
                                        
                                        <div id="divRegistrarEspecialidad" style="width:150px;top:30px; left:0px; position: absolute" >
                                            <input type="button" value="Registrar Especialidad"  />
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
</asp:Content>

