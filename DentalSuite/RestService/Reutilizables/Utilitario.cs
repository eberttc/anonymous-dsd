using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestService.Dominio;
using System.Text.RegularExpressions;

namespace RestService.Reutilizables
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

            if (clase.GetType() == typeof(Odontologo))
            {

                Odontologo OdontologoClass = (Odontologo)clase;
                // string nombres = clasePaciente.Nombres.Replace(" ", "");
                // return "p" + nombres + clasePaciente.ApePaterno;
                return "O" + OdontologoClass.COP;
            }
            else {
                return "";
            }
           
        }



        #endregion
    }
}