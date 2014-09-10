using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using Naviera.Sync.Service.Accesos;
using System.Web.Security;

public partial class Login : System.Web.UI.Page
{
    private string Usuario = "Administrador";
    private string Clave = "123456";

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnIngresar_Click(object sender, EventArgs e)
    {
       /* IServicioAccesos oIServicioAccesos = new ServicioAccesos();

        if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtClave.Text))
        {
            this.lblMensaje.Text = "Ingrese usuario y/o contraseña";
        }else
        {
            if (oIServicioAccesos.ValidarUsuario(txtUsuario.Text.Trim().ToString(), txtClave.Text.Trim().ToString()))
            {
                FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(
                                1,
                                txtUsuario.Text.Trim().ToString(),
                                DateTime.Now,
                                DateTime.Now.AddMinutes(30),
                                false,
                                string.Empty,
                                FormsAuthentication.FormsCookiePath);

                string encTicket = FormsAuthentication.Encrypt(ticket);

                Response.AppendCookie(new HttpCookie(FormsAuthentication.FormsCookieName, encTicket));

                Session["LoginUsuario"] = txtUsuario.Text.Trim().ToString();

                Response.Redirect("FrmCargaDoc.aspx", false);
            }
            else
            {
                this.lblMensaje.Text = "usuario y/o contraseña incorrecto";
            }
        }*/
        
    }
}