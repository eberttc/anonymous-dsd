using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;
public partial class Dental_ConsultaCitas : System.Web.UI.Page
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
            listarOdontologos();
        }
    }



    protected void Buscar_Click(object sender, EventArgs e)
    {
        WSCitas.CitasClient cliente = new WSCitas.CitasClient();
        List<WSCitas.ConsultaCita> lista = new List<WSCitas.ConsultaCita>();
        lista= cliente.consultarCitas(Calendar1.SelectedDate.ToString("yyyMMdd"),int.Parse(ddlEspecialidad.SelectedValue),ddlOdontologo.SelectedValue).ToList();
        GridView1.DataSource = lista;
        GridView1.DataBind();
        GridView1.Width = 950;
    }

    protected void EnviarCorreo_Click(object sender, EventArgs e)
    {
        WSCitas.CitasClient cliente = new WSCitas.CitasClient();
        lblResultado.Text = cliente.enviarPromociones();

    }

    #region Especialidades
    public class Especialidad
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string estadoEntidad { get; set; }
    }
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


    #region Odontologos
    public class Odontologo
    {
        public string Codigo { get; set; }
        public string NumeroDocumento { get; set; }
        public string Nombres { get; set; }
        public string ApePaterno { get; set; }
        public string MatPaterno { get; set; }
        public string Sexo { get; set; }
        public string TipoDocumento { get; set; }
        public string NroDocumento { get; set; }
        public string Correo { get; set; }
        public string Contrasena { get; set; }
        public string COP { get; set; }
        public string NombreCompleto { get; set; }
    }

    private void listarOdontologos()
    {
        List<Odontologo> listaResultado = new List<Odontologo>();
        HttpWebRequest req = (HttpWebRequest)WebRequest
.Create("http://localhost:20001/RESTServices/OdontologoHorario.svc/Odontologos");
        req.Method = "GET";
        HttpWebResponse res = (HttpWebResponse)req.GetResponse();
        StreamReader reader = new StreamReader(res.GetResponseStream());
        string OdontologoJson = reader.ReadToEnd();
        JavaScriptSerializer js = new JavaScriptSerializer();
        listaResultado = js.Deserialize<List<Odontologo>>(OdontologoJson);

        ddlOdontologo.DataSource = listaResultado;
        ddlOdontologo.DataValueField = "Codigo";
        ddlOdontologo.DataTextField = "NombreCompleto";
        ddlOdontologo.DataBind();
    }
    #endregion
}