using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;
using System.Text;
public partial class Dental_Especialidades : System.Web.UI.Page
{

    public class Especialidad
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }

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

        ListarEspecialidad();
    }


    protected void RegistrarEspecialidad_Click(object sender, EventArgs e)
    {
        Especialidad entidad = new Especialidad();

        entidad.Codigo =int.Parse(this.txtCodigo.Value);
        entidad.Nombre = this.txtNombre.Value;
        entidad.Descripcion = this.txtDescripcion.Value;
        if (!string.IsNullOrEmpty(entidad.Nombre) && !string.IsNullOrEmpty(entidad.Descripcion))
        {
            if (this.txtCodigo.Value == "0")
            {
                //Registrando un nuevo paciente
                //PacienteWS.Paciente pacienteCreado = paciente.registrarPaciente(objPaciente);

                //WSPacientes.RespuestaServiceOfPacientez_SY3AMPv pacienteRespuesta = WSpaciente.registrarPaciente(objPaciente);


                string postdata ="{\"Nombre\":\""+entidad.Nombre+"\",\"Descripcion\":\""+entidad.Descripcion+"\"}";
                byte[] data = Encoding.UTF8.GetBytes(postdata);
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://localhost:20001/RESTServices/Especialidades.svc/especialidades");
                req.Method = "POST";
                req.ContentLength = data.Length;
                req.ContentType = "application/json";
                var reqStream = req.GetRequestStream();
                reqStream.Write(data, 0, data.Length);
                var res = (HttpWebResponse)req.GetResponse();
                StreamReader reader = new StreamReader(res.GetResponseStream());
                string EspecialidadJson = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                Especialidad EspecialidadCreado = new Especialidad();
                EspecialidadCreado = js.Deserialize<Especialidad>(EspecialidadJson);
                if (EspecialidadCreado.Codigo == 0)
                {
                    lblMensajeResultado.Text = EspecialidadCreado.Nombre;
                }
                else {
                    if (!string.IsNullOrEmpty(EspecialidadCreado.Codigo.ToString()))
                        lblMensajeResultado.Text = "Satisfactorio, codigo " + EspecialidadCreado.Codigo.ToString();
                    else
                        lblMensajeResultado.Text = "Error";
                }
                
                //if (mensaje.TipoMensaje == "Satisfactorio")
                //    Limpiar();
            }
            else
            {

                ////Registrando un nuevo paciente
                //WSPacientes.RespuestaServiceOfPacientez_SY3AMPv pacienteRespuesta = WSpaciente.modificarPaciente(objPaciente);
                //lblMensajeResultado.Text = pacienteRespuesta.TipoMensaje;
                ////if (mensaje.TipoMensaje == "Satisfactorio")
                ////    Limpiar();

                //string postdata = "{\"Codigo\":5,\"Nombre\":\"TEST3\",\"Descripcion\":\"TEST35\"}";
                string postdata = "{\"Codigo\":"+entidad.Codigo +",\"Nombre\":\""+entidad.Nombre+"\",\"Descripcion\":\""+entidad.Descripcion+"\"}";
                byte[] data = Encoding.UTF8.GetBytes(postdata);
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://localhost:20001/RESTServices/Especialidades.svc/especialidades");
                req.Method = "PUT";
                req.ContentLength = data.Length;
                req.ContentType = "application/json";
                var reqStream = req.GetRequestStream();
                reqStream.Write(data, 0, data.Length);
                var res = (HttpWebResponse)req.GetResponse();
                StreamReader reader = new StreamReader(res.GetResponseStream());
                string EspecialidadJson = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                Especialidad EspecialidadCreado = js.Deserialize<Especialidad>(EspecialidadJson);

                if (!string.IsNullOrEmpty(EspecialidadCreado.Codigo.ToString()))
                    lblMensajeResultado.Text = "Actualizado, codigo " + EspecialidadCreado.Codigo.ToString();
                else
                    lblMensajeResultado.Text = "Error";
            }
        }
        else
        {
            lblMensajeResultado.Text = "Debe llenar todos las cajas de texto.";
        }


        ListarEspecialidad();

    }

    private void ListarEspecialidad()
    {
        HttpWebRequest req = (HttpWebRequest)WebRequest
    .Create("http://localhost:20001/RESTServices/Especialidades.svc/especialidades");
        req.Method = "GET";
        HttpWebResponse res = (HttpWebResponse)req.GetResponse();
        StreamReader reader = new StreamReader(res.GetResponseStream());
        string EspecialidadJson = reader.ReadToEnd();
        JavaScriptSerializer js = new JavaScriptSerializer();
        List<Especialidad> ListaEspecialidadsObtenidos = js.Deserialize<List<Especialidad>>(EspecialidadJson);
        GWEspecialidad.DataSource = ListaEspecialidadsObtenidos;
        GWEspecialidad.DataBind();
        GWEspecialidad.Width = 950;
    }

}