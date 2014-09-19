using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SOAPServices.Dominio;
using System.Text.RegularExpressions;

namespace SOAPServices.Reutilizables
{
    public class Utilitario
    {
        public bool validarClave(string contrasena)
        {
            var r = new Regex(@"^(?=\S*?[A-Z])(?=\S*?[a-z])(?=\S*?[0-9])\S{6,}$");
            return r.Match(contrasena).Success ? true : false;
        }


        public Mensaje crearMensaje(string mensajeDescripcion, string tipoMensaje, string titulo, string origen)
        {
            Mensaje mensaje = new Mensaje();
            mensaje.MensajeDescripcion = mensajeDescripcion;
            mensaje.TipoMensaje = tipoMensaje;
            mensaje.Titulo = titulo;
            mensaje.ServicioOrigen = origen;

            return mensaje;
        }


        public string generarCodigo(object clase)
        {
            if (clase.GetType() == typeof(Paciente))
            {

                Paciente clasePaciente = (Paciente)clase;
                string nombres = clasePaciente.Nombres.Replace(" ", "");
                return "p" + nombres + clasePaciente.ApePaterno;
            }
            else
            {
                Paciente clasePaciente = (Paciente)clase;
                string nombres = clasePaciente.Nombres.Replace(" ", "");
                return "o" + nombres + clasePaciente.ApePaterno;
            }
        }
    }
}