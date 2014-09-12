using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class master_Principal : System.Web.UI.MasterPage
{

    protected void Page_Init(object sender, EventArgs e)
    {
        string configId = string.Empty;
        string pageName = this.ContentPlaceHolder1.Page.AppRelativeVirtualPath;
        if (Request.QueryString["Config"] != null)
        {
            configId = "?Config=" + Request.QueryString["Config"].ToString();
        }
        else
        {
            configId = "?Config=0";
        }
        if (Request.QueryString["Titulo"] != null)
        {
            configId = configId + "&Titulo=" + Request.QueryString["Titulo"].ToString();
        }
        else
        {
            configId = configId + "&Titulo=";
        }
        try
        {
            string token = Session["Token"].ToString();
            //if (new wsSeguridad.Seguridad().EsTokenValido(token))
            //{
            //    new wsSeguridad.Seguridad().AutenticacionActualizarToken(token);
            //    this.hdfToken.Value = token;
            //}
            //else
            //{
            //    throw new Exception();
            //}
            //hdfLinkHoy.Value = FuncionesDeFechaYHora.ObtenerFechaHoy();
            //hdfLink7Inicio.Value = FuncionesDeFechaYHora.ObtenerFechaInicioSemana7Dias();
            //hdfLink30Inicio.Value = FuncionesDeFechaYHora.ObtenerFechaInicioMes30Dias();
            //hdfLinkmInicio.Value = FuncionesDeFechaYHora.ObtenerFechaInicioMesActual();
            //hdfLink3mInicio.Value = FuncionesDeFechaYHora.ObtenerFechaInicio3MesAnterior();
            ////hdfLink6mInicio.Value = FuncionesDeFechaYHora.ObtenerFechaInicio6MesAnterior();

        }
        catch
        {
            Session.Abandon();
            Session.Clear();
            if (pageName == null) pageName = string.Empty;
            configId = configId.Replace("&","||");
            string redirectLogin = "~/Seguridad/Login.aspx?var=" + pageName + configId;

            Response.Redirect(redirectLogin);
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }

}
