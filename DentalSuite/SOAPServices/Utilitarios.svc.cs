using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Text.RegularExpressions;

namespace SOAPServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Utilitarios" en el código, en svc y en el archivo de configuración a la vez.
    public class Utilitarios : IUtilitarios
    {


        public bool validarCorreo(string contrasena)
        {
            throw new NotImplementedException();
        }

        public Dominio.Mensaje crearMensaje(string mensajeDescripcion, string tipoMensaje, string titulo, string origen)
        {
            throw new NotImplementedException();
        }
    }
}
