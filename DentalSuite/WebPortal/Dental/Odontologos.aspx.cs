using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Dental_Odontologos : System.Web.UI.Page
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

        llenarGrillaHorarios();
    }

    public class horario{
        public string dia{get;set;}
        public string desde{get;set;}
        public string hasta{get;set;}

        public horario(){
            dia=string.Empty;
            desde=string.Empty;
            hasta=string.Empty;
        }
    }

    private void llenarGrillaHorarios() {
        horario[] listaHorario = new horario[5];
        listaHorario[0]=new horario { dia = "Lunes", desde = "08:00", hasta = "12:00" };
        listaHorario[1] = new horario { dia = "Martes", desde = "08:00", hasta = "12:00" };
        listaHorario[2] = new horario { dia = "Miercoles", desde = "08:00", hasta = "12:00" };
        listaHorario[3] = new horario { dia = "Jueves", desde = "08:00", hasta = "12:00" };
        listaHorario[4] = new horario { dia = "Viernes", desde = "08:00", hasta = "12:00" };
        GridView1.DataSource = listaHorario;
        GridView1.DataBind();
        GridView1.Width = 200;
    }

}