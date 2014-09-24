using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SOAPServices.Dominio;

namespace SOAPServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IEspecialidades" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IEspecialidades
    {
        [OperationContract]
        RespuestaService<Especialidad> grabarEspecialidad(Especialidad especialidad);

        [OperationContract]
        RespuestaService<Especialidad> modificarEspecialidad(Especialidad especialidad);

        [OperationContract]
        List<Especialidad> listarEspecialidad();
    }
}
