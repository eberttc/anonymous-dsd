<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ErrorPage.aspx.cs" Inherits="ErrorPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>.:: Error ::.</title>
     <link href="<%= ResolveClientUrl("~/Styles/Error/Error.css")%>" rel="stylesheet"
        type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>    
        
    </div>
    <div align="center">
		<div id="outline">
		<div id="errorboxoutline">

			<div id="errorboxheader">.:::  DENTAL SOLUTIONS  :::.</div>
			<div id="errorboxbody">
			    <p><strong>NO PODEMOS PROCESAR SU SOLICITUD EN ESTE MOMENTO</strong></p>
               
                <br />
			<p><strong>Ir a la página de Inicio de este sitio en el siguiente link</strong></p>
            <div id="pagInicio">
			<p>
				<!--<ul>-->
					<li><a href="http://dental.pe" title="Ir a la página de inicio">Página de inicio</a></li>
				<!--</ul>-->
			</p>
            </div>
			<p>Si la dificultad persiste, contacte con el administrador de este sitio  a <a href = "mailto:soporte@dental.pe" title="Dental Solutions">Soporte@dental.pe</a> </p>
			</div>
		</div>
		</div>

	</div>    
    </form>
</body>
</html>
