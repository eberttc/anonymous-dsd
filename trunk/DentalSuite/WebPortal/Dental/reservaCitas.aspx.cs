using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;
public partial class Dental_reservaCitas : System.Web.UI.Page
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

        if (!Page.IsPostBack)
        {
            listarEspecialidades();
        }
    }

    protected void Buscar_Click(object sender, EventArgs e)
    {

        lblMensajeResultado.Text = ddlEspecialidad.SelectedValue;
    }

    protected void Reservar_Click(object sender, EventArgs e)
    {


    }
    public class Especialidad
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string estadoEntidad { get; set; }
    }

    #region Especialidades
    private void listarEspecialidades()
    {
        List<Especialidad> listaResultado = new List<Especialidad>();
        HttpWebRequest req = (HttpWebRequest)WebRequest
.Create("http://localhost:20001/RESTServices/Especialidades.svc/especialidades");
        req.Method = "GET";
        HttpWebResponse res = (HttpWebResponse)req.GetResponse();
        StreamReader reader = new StreamReader(res.GetResponseStream());
        string EspecialidadJson = reader.ReadToEnd();
        JavaScriptSerializer js = new JavaScriptSerializer();
        listaResultado = js.Deserialize<List<Especialidad>>(EspecialidadJson);

        ddlEspecialidad.DataSource = listaResultado;
        ddlEspecialidad.DataValueField = "Codigo";
        ddlEspecialidad.DataTextField = "Nombre";
        ddlEspecialidad.DataBind();
    }
    #endregion




    protected void ddlEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}