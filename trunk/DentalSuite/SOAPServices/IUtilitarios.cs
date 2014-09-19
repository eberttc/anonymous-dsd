using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SOAPServices.Dominio;

namespace SOAPServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IUtilitarios" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IUtilitarios
    {
        [OperationContract]
        bool validarCorreo(string contrasena);

        [OperationContract]
        Mensaje crearMensaje(string mensajeDescripcion,string tipoMensaje,string titulo,string origen);
    }
}
