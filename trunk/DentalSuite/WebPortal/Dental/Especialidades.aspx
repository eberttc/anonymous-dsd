<%@ Page Title="" Language="C#" MasterPageFile="~/master/Principal.master" AutoEventWireup="true" CodeFile="Especialidades.aspx.cs" Inherits="Dental_Especialidades" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
        <link href="<%= ResolveClientUrl("~/Styles/General/jqgrid.ui.css") %>" rel="stylesheet" type="text/css" />
        <link href="<%= ResolveClientUrl("~/Styles/General/jquery.autocomplete.css") %>" rel="stylesheet" type="text/css" />
        <style type="text/css">
            .style1
            {
                height: 26px;
            }
        </style>
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
                                        <input type="text" name="txtNombre" id="txtNombre" runat="server" /></td>
                                    <td width="50px"  style="vertical-align: bottom" >
                                        </td>
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
                                    <td style="vertical-align: bottom" >
                                        
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td width="90px" >
                                        &nbsp;</td>
                                    <td width="100px" >
                                        &nbsp;</td>
                                    <td style="vertical-align: bottom" >
                                        <div id="divRegistrarEspecialidad" style="width:250px;top:0px; left:0px; position: relative" >
                                            <input id="Button1" type="button" value="Registrar Especialidad" OnServerClick="AddButton_Click" runat="server"  />
                                        </div></td>
                                    <td style="vertical-align: bottom" >
                                        <div id="divCancelar" style="width:200px;top:0px; left:0px; position: relative">
                                        <input type="button" value="Cancelar"  />
                                            </div></td>
                                </tr>
                                <tr>
                                    <td valign="top" width="100px" class="style1">
                                        </td>
                                    <td class="style1" colspan="2">
                                    <div style="width:500px;height:50px;position: absolute; float: right; top: -153px; left: 100px;">
                                        
                                        
                                        
                                    </div>
                                        
                                        </td>
                                    <td class="style1">
                                        </td>
                                </tr>
                            </table>
            </div>


    <input type="hidden" name="hdnTitulo" id="hdnTitulo" runat="server" />
</asp:Content>

