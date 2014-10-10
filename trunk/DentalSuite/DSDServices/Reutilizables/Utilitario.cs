using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DSDServices.Dominio;
using System.Text.RegularExpressions;

namespace DSDServices.Reutilizables
{
    public class Utilitario
    {

        #region "Metodos reutilizables"

        public bool validarClave(string contrasena)
        {
            var r = new Regex(@"^(?=\S*?[A-Z])(?=\S*?[a-z])(?=\S*?[0-9])\S{6,}$");
            return r.Match(contrasena).Success ? true : false;
        }
       
        public string generarCodigo(object clase)
        {
            
            if (clase.GetType() == typeof(Paciente))
            {

                Paciente clasePaciente = (Paciente)clase;
               // string nombres = clasePaciente.Nombres.Replace(" ", "");
               // return "p" + nombres + clasePaciente.ApePaterno;
                return "p" + clasePaciente.NumeroDocumento;
            }
            else
            {
                Odontologo claseOdontologo = (Odontologo)clase;
              //  string nombres = clasePaciente.Nombres.Replace(" ", "");
              //  return "o" + nombres + clasePaciente.ApePaterno;
                return "o" + claseOdontologo.NumeroDocumento;
            }
        }

        public int validarRangoHorasCita(DateTime fechaUltimaCita, DateTime fechaCitaActual)
        {
            return (fechaCitaActual - fechaUltimaCita).Days;
        }

        public int validarDiasAnticipacionCita(DateTime fechaCitaActual)
        {
            DateTime fechaActual = DateTime.Now;

            return (fechaCitaActual - fechaActual).Days;
        }

        #endregion
    }
}