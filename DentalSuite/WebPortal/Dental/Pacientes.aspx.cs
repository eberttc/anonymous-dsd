using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Dental_Pacientes : System.Web.UI.Page
{
    //PacienteWS.PacientesClient pacienteWs = new PacienteWS.PacientesClient();
    //PacienteWS.Paciente objPaciente =new PacienteWS.Paciente();

    WSPacientes.PacientesClient WSpaciente = new WSPacientes.PacientesClient();
    WSPacientes.Paciente objPaciente = new WSPacientes.Paciente();

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
        //if (!Page.IsPostBack)
        //{
            
        //}

        ListarPacientes();
    }


    protected void RegistrarPaciente_Click(object sender, EventArgs e) {
        objPaciente.Codigo = this.txtCodigo.Value;
        objPaciente.Nombres = this.txtNombre.Value;
        objPaciente.ApePaterno = this.txtApellidoPaterno.Value;
        objPaciente.ApeMaterno = this.txtApellidoMaterno.Value;
        objPaciente.Sexo = (RadioButtonList1.SelectedValue == "F") ? "F" : "M";
        objPaciente.TipoDocumento = this.txtTipoDocumento.Value;
        objPaciente.NumeroDocumento = this.txtNroDocumento.Value;
        objPaciente.Correo = (this.txtCorreo.Value == this.txtConfirmarCorreo.Value) ? this.txtCorreo.Value : string.Empty;
        objPaciente.Contrasena = (this.txtContrasenia.Value == this.txtConfirmarContrasenia.Value) ? this.txtContrasenia.Value : string.Empty;

        if (!string.IsNullOrEmpty(objPaciente.Correo) && !string.IsNullOrEmpty(objPaciente.Contrasena))
        {
            if (this.txtCodigo.Value == "0")
            {
                //Registrando un nuevo paciente
                //PacienteWS.Paciente pacienteCreado = paciente.registrarPaciente(objPaciente);

                WSPacientes.RespuestaServiceOfPacientez_SY3AMPv pacienteRespuesta = WSpaciente.registrarPaciente(objPaciente);


                lblMensajeResultado.Text = pacienteRespuesta.TipoMensaje;
                //if (mensaje.TipoMensaje == "Satisfactorio")
                //    Limpiar();
            }
            else
            {

                //Registrando un nuevo paciente
                WSPacientes.RespuestaServiceOfPacientez_SY3AMPv pacienteRespuesta = WSpaciente.modificarPaciente(objPaciente);
                lblMensajeResultado.Text = pacienteRespuesta.TipoMensaje;
                //if (mensaje.TipoMensaje == "Satisfactorio")
                //    Limpiar();
            }
        }
        else
        {
            lblMensajeResultado.Text = "El correo o la contraeña no coinciden";
        }


        ListarPacientes();

    }
    private void ListarPacientes() {

        WSPacientes.Paciente[] listaPacientes;
        listaPacientes = WSpaciente.listarPacientes();
        GridView1.DataSource = listaPacientes;
        GridView1.DataBind();
        GridView1.Width = 950;
    }

    private void Limpiar() {
        this.txtCodigo.Value = "0";
        this.txtCodigo.Disabled = true;
        this.txtNombre.Value = "";
        this.txtApellidoPaterno.Value = "";
        this.txtApellidoMaterno.Value = "";
        this.txtTipoDocumento.Value = "";
        this.txtNroDocumento.Value = "";
        this.txtCorreo.Value = "";
        this.txtContrasenia.Value = "";
        this.txtConfirmarCorreo.Value = "";
        this.txtConfirmarContrasenia.Value = "";
    }

}