using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Dental_Especialidades : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            this.hdnTitulo.Value = Request.QueryString["Titulo"].ToString();
        }
        catch
        {
            this.hdnTitulo.Value = string.Empty;
        }
    }
}