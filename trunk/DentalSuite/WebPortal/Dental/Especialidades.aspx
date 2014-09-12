<%@ Page Title="" Language="C#" MasterPageFile="~/master/Principal.master" AutoEventWireup="true" CodeFile="Especialidades.aspx.cs" Inherits="Dental_Especialidades" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
        <link href="<%= ResolveClientUrl("~/Styles/General/jqgrid.ui.css") %>" rel="stylesheet" type="text/css" />
        <link href="<%= ResolveClientUrl("~/Styles/General/jquery.autocomplete.css") %>" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <script src="<%= ResolveClientUrl("~/Scripts/General/jquery.autocomplete.min.js") %>" type="text/javascript"></script>
    <script src="<%= ResolveClientUrl("~/Scripts/Dental/DentalEspecialidades.js") %>" type="text/javascript"></script>   
        <form action="<%= ResolveClientUrl("~/m_MobileSolutions/ExportarEdit.aspx") %>" method="post">

    <input type="hidden" name="hdnTitulo" id="hdnTitulo" runat="server" />
    </form>
</asp:Content>

