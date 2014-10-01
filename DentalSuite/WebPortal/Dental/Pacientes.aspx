<%@ Page Title="" Language="C#" MasterPageFile="~/master/Principal.master" AutoEventWireup="true" CodeFile="Pacientes.aspx.cs" Inherits="Dental_Pacientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
        <link href="<%= ResolveClientUrl("~/Styles/General/jqgrid.ui.css") %>" rel="stylesheet" type="text/css" />
        <link href="<%= ResolveClientUrl("~/Styles/General/jquery.autocomplete.css") %>" rel="stylesheet" type="text/css" />
        <style type="text/css">
            .style1
            {
                height: 27px;
            }
        </style>
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
                                        Codigo:</td>
                                    <td width="100px" >
                                        <input type="text" id="txtCodigo" runat="server" value="0" /></td>
                                    <td width="50px"  style="vertical-align: bottom" >
                                        
                                        &nbsp;</td>
                                    <td style="vertical-align: bottom" >
                                        
                                        &nbsp;</td>
                                    <td style="vertical-align: bottom" >
                                        &nbsp;</td>
                                </tr>
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

                                        <asp:RadioButtonList ID="RadioButtonList1" runat="server" 
                                            RepeatDirection="Horizontal" 
                                            >
                                            <asp:ListItem>M</asp:ListItem>
                                            <asp:ListItem>F</asp:ListItem>
                                        </asp:RadioButtonList>

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
                                        
                                        <input type="text" id="txtTipoDocumento" runat="server" /></td>
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
                                    <td width="200px" colspan="5" class="style1" >
                                        <asp:Label ID="lblMensajeResultado" runat="server" Font-Bold="True" 
                                            ForeColor="#FF3300"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td valign="top" width="100px">
                                        </td>
                                    <td class="tblFiltroCeldaValor" colspan="4">
                                    <div style="width:500px;height:50px;position: relative; float: right;">
                                        
                                        <div id="divRegistrarPaciente" style="width:150px;top:30px; left:0px; position: absolute" >
                                            <input id="Button1" type="button" value="Registrar Paciente"   OnServerClick="RegistrarPaciente_Click" runat="server"/>
                                        </div>
                                        <div id="divCancelar" style="width:120px;top:30px; left:200px; position: absolute">
                                        <input id="Button2" type="button" value="Cancelar" />
                                            </div>
                                    </div>
                                        
                                        </td>
                                </tr>
                                <tr>
                                    <td valign="top" width="100px">
                                        &nbsp;</td>
                                    <td class="tblFiltroCeldaValor" colspan="4">
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td valign="top" width="100px" colspan="5">
                                    <br />
                                    <br />
                                        <asp:GridView ID="GridView1" runat="server" AllowSorting="True" 
                                            AutoGenerateColumns="False" EnableModelValidation="True" >
                                            <AlternatingRowStyle BackColor="#999999" BorderColor="Black" 
                                                BorderStyle="Double" ForeColor="White" />
                                            <Columns>
                                                <asp:BoundField DataField="Codigo" HeaderText="Codigo" />
                                                <asp:BoundField DataField="ApeMaterno" HeaderText="Materno" />
                                                <asp:BoundField DataField="ApePaterno" HeaderText="Paterno" />
                                                <asp:BoundField DataField="Nombres" HeaderText="Nombres" />
                                                <asp:BoundField DataField="Correo" HeaderText="Correo" />
                                                <asp:BoundField DataField="TipoDocumento" HeaderText="Documento" />
                                                <asp:BoundField DataField="NumeroDocumento" HeaderText="Nro" />
                                                <asp:BoundField DataField="Sexo" HeaderText="Sexo" />
                                                <asp:TemplateField HeaderText="Editar">
                                                    <ItemTemplate>
                                                      <input type="button" onclick="EditarPaciente('<%# Eval("Codigo")%>','<%# Eval("ApePaterno")%>','<%# Eval("ApeMaterno")%>','<%# Eval("Nombres")%>','<%# Eval("Correo")%>','<%# Eval("Contrasena")%>','<%# Eval("Sexo")%>','<%# Eval("TipoDocumento")%>','<%# Eval("NumeroDocumento")%>')" value="Edit" />
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:BoundField DataField="Contrasenia" Visible="False" />
                                            </Columns>
                                            <HeaderStyle BackColor="#444751" BorderColor="White" ForeColor="White" />
                                            <RowStyle BorderStyle="Solid" />
                                        </asp:GridView>
                                        </td>
                                </tr>
                            </table>
            </div>
    <input type="hidden" name="hdnTitulo" id="hdnTitulo" runat="server" />
    <input type="text" id="txtTipoDocumentoHidden" runat="server" style="visibility: hidden" />

</asp:Content>

