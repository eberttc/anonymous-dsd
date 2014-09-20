using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Dental_Pacientes : System.Web.UI.Page
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


    protected void RegistrarPaciente_Click(object sender, EventArgs e) {
        PacienteWS.PacientesClient paciente = new PacienteWS.PacientesClient();
        PacienteWS.Paciente objPaciente = new PacienteWS.Paciente();
        objPaciente.Nombres = this.txtNombre.Value;
        objPaciente.ApePaterno = this.txtApellidoPaterno.Value;
        objPaciente.ApeMaterno = this.txtApellidoMaterno.Value;
        objPaciente.Sexo = (this.m.Checked)?"M":((this.f.Checked)?"F":string.Empty);
        objPaciente.TipoDocumento = this.txtTipoDocumentoHidden.Value;
        objPaciente.NumeroDocumento = this.txtNroDocumento.Value;
        objPaciente.Correo = (this.txtCorreo.Value == this.txtConfirmarCorreo.Value) ? this.txtCorreo.Value : "error";
        objPaciente.Contrasena = (this.txtContrasenia.Value == this.txtConfirmarContrasenia.Value) ? this.txtContrasenia.Value : "error";

        //Registrando un nuevo paciente
        PacienteWS.Mensaje mensaje = paciente.registrarPaciente(objPaciente);
        lblMensajeResultado.Text = mensaje.MensajeDescripcion;
    }

    protected void Cancelar_Click(object sender, EventArgs e)
    {

    }

}