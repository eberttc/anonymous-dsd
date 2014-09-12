using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

public partial class Seguridad_Login : System.Web.UI.Page
{
    string Usuario = string.Empty;
    string Password = string.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {
        //txtUsuario.Focus();
        try
        {
            // recibe valores encriptados enviados por la url
            Usuario = Request.QueryString.Get("Usu").ToString(); 
            Password = Request.QueryString.Get("Pass").ToString();

            if (Usuario.Trim() != "" && Password.Trim() != "")
            {
                //string token = new Seguridad().Login( Cript.Decrypt(Usuario),Cript.Decrypt( Password));
                //if (token.Length > 0)
                //{
                //    Session.Add("Token", token);
                //    Session.Add("Usuario", Usuario);
                //    string rutaPreferente = string.Empty;
                //    string ultimaPaginaVisitada = string.Empty;
                //    rutaPreferente = new wsSeguridad.Seguridad().NavegacionObtenerMenuPreferente(token);

                //    if (Request["var"] != null)
                //    {
                //        ultimaPaginaVisitada = Request["var"].ToString();
                //        ultimaPaginaVisitada = ultimaPaginaVisitada.Replace("||", "&");
                //    }
                //    else
                //    {
                //        ultimaPaginaVisitada = string.Empty;
                //    }
                //    if (ultimaPaginaVisitada != string.Empty)
                //    {
                //        Response.Redirect(ultimaPaginaVisitada);
                //    }
                //    else
                //    {
                //        if (rutaPreferente != string.Empty)
                //            Response.Redirect("~" + rutaPreferente);
                //        else
                //            Response.Redirect(Convert.ToString(ConfigurationManager.AppSettings["PaginaInicio"]));
                //    }
                //}
            }
        }
        catch (Exception )
        {
        }
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {

        if (txtContrasena.Text == "" && txtUsuario.Text == "") txtLoginMessage.Text = "Ingrese usuario y contrasena";
        else if (txtContrasena.Text == "" && txtUsuario.Text != "") txtLoginMessage.Text = "Ingrese contrasena";
        else if (txtContrasena.Text != "" && txtUsuario.Text == "") txtLoginMessage.Text = "Ingrese usuario";
        else
        {
            string token = "12345678";
            if (token.Length > 0)
            {
                Session.Add("Token", token);
                Session.Add("Usuario", this.txtUsuario.Text);
                string rutaPreferente = string.Empty;
                string ultimaPaginaVisitada = string.Empty;
                //rutaPreferente = new wsSeguridad.Seguridad().NavegacionObtenerMenuPreferente(token);

                if (Request["var"] != null)
                {
                    ultimaPaginaVisitada = Request["var"].ToString();
                    ultimaPaginaVisitada = ultimaPaginaVisitada.Replace("||", "&");
                }
                else
                {
                    ultimaPaginaVisitada = string.Empty;
                }
                if (ultimaPaginaVisitada != string.Empty)
                {
                    Response.Redirect(ultimaPaginaVisitada);
                }
                else
                {
                    if (rutaPreferente != string.Empty)
                        Response.Redirect("~" + rutaPreferente);
                    else
                        Response.Redirect(Convert.ToString(ConfigurationManager.AppSettings["PaginaInicio"]));
                }
            }
            else txtLoginMessage.Text = "Usuario o Password inválidos.";
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

    }
}