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
    <script src="<%= ResolveClientUrl("~/Scripts/General/grid.locale-es.js") %>" type="text/javascript"></script>
    <script src="<%= ResolveClientUrl("~/Scripts/General/jquery.jqGrid.min.js") %>" type="text/javascript"></script>
    <script src="<%= ResolveClientUrl("~/Scripts/General/jquery.autocomplete.min.js") %>" type="text/javascript"></script>
    <script src="<%= ResolveClientUrl("~/Scripts/General/jquery.autocomplete.min.js") %>" type="text/javascript"></script>
    <script src="<%= ResolveClientUrl("~/Scripts/Dental/DentalEspecialidades.js") %>" type="text/javascript"></script>   
<br />
        <br />
    <div id="caja">
                         <table style="width: 900px">
                                <tr>
                                    <td width="90px" >
                                        Codigo:</td>
                                    <td width="100px" >
                                        <input type="text" id="txtCodigo" runat="server" value="0" /></td>
                                    <td width="50px"  style="vertical-align: bottom" >
                                        &nbsp;</td>
                                    <td width="50px"  style="vertical-align: bottom" >
                                        &nbsp;</td>
                                </tr>
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
                                        <input type="text" id="txtDescripcion" size="90" runat="server" /></td>
                                    <td style="vertical-align: bottom" >
                                        
                                        &nbsp;</td>
                                    <td style="vertical-align: bottom" >
                                        
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td width="90px" >
                                        &nbsp;</td>
                                    <td width="100px" >
                                         <asp:Label ID="lblMensajeResultado" runat="server" Font-Bold="True" 
                                            ForeColor="#FF3300"></asp:Label></td>
                                    <td style="vertical-align: bottom" >
                                        <div id="divRegistrarEspecialidad" style="width:250px;top:0px; left:0px; position: relative" >
                                            <input id="Button1" type="button" value="Registrar Especialidad" OnServerClick="RegistrarEspecialidad_Click" runat="server" />
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

<%--          <div id="Seleccion">
          <table id="GrillaEspecialidad" width="100%" border ="0">
                </table>
         </div>
            </div>--%>
        <asp:GridView ID="GWEspecialidad" runat="server" AllowSorting="True" AutoGenerateColumns="False" EnableModelValidation="True" >
            <AlternatingRowStyle BackColor="#999999" BorderColor="Black" 
                                                BorderStyle="Double" ForeColor="White" />
            <Columns>
                <asp:BoundField DataField="codigo" HeaderText="Codigo" />
                <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                <asp:BoundField DataField="descripcion" HeaderText="Descripcion" />
            <asp:TemplateField HeaderText="Editar">
                                                    <ItemTemplate>
                                                      <input type="button" onclick="EditarEspecialidad('<%# Eval("codigo")%>','<%# Eval("nombre")%>','<%# Eval("descripcion")%>')" value="Edit" />
                                                    </ItemTemplate>
                                                </asp:TemplateField>
            </Columns>
                                                        <HeaderStyle BackColor="#444751" BorderColor="White" ForeColor="White" />
                                            <RowStyle BorderStyle="Solid" />
        </asp:GridView>

    <input type="hidden" name="hdnTitulo" id="hdnTitulo" runat="server" />
    </div>
</asp:Content>

