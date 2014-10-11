<%@ Page Title="" Language="C#" MasterPageFile="~/master/Principal.master" AutoEventWireup="true" CodeFile="reservaCitas.aspx.cs" Inherits="Dental_reservaCitas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
        <link href="<%= ResolveClientUrl("~/Styles/General/jqgrid.ui.css") %>" rel="stylesheet" type="text/css" />
        <link href="<%= ResolveClientUrl("~/Styles/General/jquery.autocomplete.css") %>" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <script src="<%= ResolveClientUrl("~/Scripts/General/jquery.autocomplete.min.js") %>" type="text/javascript"></script>
    <script src="<%= ResolveClientUrl("~/Scripts/Dental/DentalReservaCitas.js") %>" type="text/javascript"></script>
    <form action="<%= ResolveClientUrl("~/m_MobileSolutions/ExportarEdit.aspx") %>" method="post">

<br />
        <br />
            <div id="caja">
                         <table style="width: 900px">
                                <tr>
                                    <td width="200px" >
                                        &nbsp;</td>
                                    <td width="100px" >
                                        <input type="text" id="txtCodigo" runat="server" value="0" visible="false" /></td>
                                    <td width="50px"  style="vertical-align: bottom" >
                                        
                                        &nbsp;</td>
                                    <td style="vertical-align: bottom" >
                                        
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td width="200px" >
                                        Fecha :&nbsp;
                                    </td>
                                    <td width="100px" >
                                        <input type="text" id="txtFecha" /></td>
                                    <td width="50px"  style="vertical-align: bottom" >
                                        
                                        <div id="divBuscar" style="width:150px;top:0px; left:0px; position: relative">
                                            <input id="btnBuscar" runat="server" onserverclick="Buscar_Click" type="button" 
                                                value="Buscar" />
                                        </div>
                                    </td>
                                    <td style="vertical-align: bottom" >
                                       </td>
                                </tr>
                                <tr>
                                    <td width="200px" >
                                        Especialidad:</td>
                                    <td width="100px" >
                                        <asp:DropDownList ID="ddlEspecialidad" runat="server" 
                                            onselectedindexchanged="ddlEspecialidad_SelectedIndexChanged">
                                        </asp:DropDownList>
                                    </td>
                                    <td style="vertical-align: bottom" >
                                        
                                        &nbsp;</td>
                                    <td style="vertical-align: bottom" >
                                        
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td width="200px" >
                                        Odontologo:</td>
                                    <td width="100px" >
                                        <input type="text" id="txtOdontologo"  runat="server"/></td>
                                    <td style="vertical-align: bottom" >
                                        
                                        &nbsp;</td>
                                    <td style="vertical-align: bottom" >
                                        
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td width="200px" >
                                        &nbsp;</td>
                                    <td width="100px" >
                                        &nbsp;</td>
                                    <td style="vertical-align: bottom" >
                                        
                                        &nbsp;</td>
                                    <td style="vertical-align: bottom" >
                                        
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td width="200px" colspan="4" class="style1" >
                                        <asp:Label ID="lblMensajeResultado" runat="server" Font-Bold="True" 
                                            ForeColor="#FF3300"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td valign="top" width="100px">
                                        </td>
                                    <td class="tblFiltroCeldaValor" colspan="3">
                                    <div style="width:500px;height:50px;position: relative; float: right;">
                                        
                                        <div id="divReservar" style="width:150px;top:30px; left:0px; position: absolute" >
                                            <input id="btnReservar" type="button" value="Reservar"   OnServerClick="Reservar_Click" runat="server"/>
                                        </div>

                                    </div>
                                        
                                        </td>
                                </tr>
                                <tr>
                                    <td valign="top" width="100px">
                                        &nbsp;</td>
                                    <td class="tblFiltroCeldaValor" colspan="3">
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td valign="top" width="100px" colspan="4">
                                    <br />
                                    <br />
                                        </td>
                                </tr>
                            </table>
            </div>
    <input type="hidden" name="hdnTitulo" id="hdnTitulo" runat="server" />
    <input type="text" id="txtTipoDocumentoHidden" runat="server" style="visibility: hidden" />
        </form>
</asp:Content>

