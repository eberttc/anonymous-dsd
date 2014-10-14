<%@ Page Title="" Language="C#" MasterPageFile="~/master/Principal.master" AutoEventWireup="true" CodeFile="ConsultaCitas.aspx.cs" Inherits="Dental_ConsultaCitas" %>

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
                                        Fecha :&nbsp;
                                    </td>
                                    <td width="100px" >
                                        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
                                    </td>
                                    <td width="50px"  style="vertical-align: bottom" >
                                        
                                        <div id="divBuscar" style="width:150px;top:0px; left:0px; position: relative">
                                            <input id="btnBuscar" runat="server" onserverclick="Buscar_Click" type="button" 
                                                value="Consultar" />
                                        </div>
                                    </td>
                                    <td style="vertical-align: bottom" >
                                       </td>
                                </tr>
                                <tr>
                                    <td width="200px" >
                                        Especialidad:</td>
                                    <td width="100px" >
                                        <asp:DropDownList ID="ddlEspecialidad" runat="server" Height="21px" 
                                            Width="166px" >
                                        </asp:DropDownList>
                                    </td>
                                    <td style="vertical-align: bottom" >
                                        
                                        &nbsp;</td>
                                    <td style="vertical-align: bottom" >
                                        
                                        <div id="divEnviarCorreo" style="width:150px;top:0px; left:0px; position: relative">
                                            <input id="btnCorreo" runat="server" onserverclick="EnviarCorreo_Click" type="button" 
                                                value="Enviar Promociones" />
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td width="200px" >
                                        Odontologo:</td>
                                    <td width="100px" >
                                        <asp:DropDownList ID="ddlOdontologo" runat="server" Height="27px" Width="299px">
                                        </asp:DropDownList>
                                    </td>
                                    <td style="vertical-align: bottom" >
                                        
                                        &nbsp;</td>
                                    <td style="vertical-align: bottom" >
                                        
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td width="200px" >
                                        <asp:Label ID="lblResultado" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td width="100px" >
                                        &nbsp;</td>
                                    <td style="vertical-align: bottom" >
                                        
                                        &nbsp;</td>
                                    <td style="vertical-align: bottom" >
                                        
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td width="200px" colspan="4" class="style1" >
                                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                                        
                                            <AlternatingRowStyle BackColor="#999999" BorderColor="Black" 
                                                BorderStyle="Double" ForeColor="White" />
                                            <Columns>
                                                <asp:BoundField DataField="cita" HeaderText="cita" />
                                                <asp:BoundField DataField="fecha" HeaderText="fecha" />
                                                <asp:BoundField DataField="especialidad" HeaderText="especialidad" />
                                                <asp:BoundField DataField="odontologo" HeaderText="odontologo" />
                                                <asp:BoundField DataField="paciente" HeaderText="paciente" />
                                                <asp:BoundField DataField="horario" HeaderText="horario" />
                                            </Columns>
                                            <HeaderStyle BackColor="#444751" BorderColor="White" ForeColor="White" />
                                            <RowStyle BorderStyle="Solid" />
                                        </asp:GridView>
                                    </td>
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

