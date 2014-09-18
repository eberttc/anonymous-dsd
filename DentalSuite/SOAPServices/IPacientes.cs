using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SOAPServices.Dominio;

namespace SOAPServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IPacientes" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IPacientes
    {
        [OperationContract]
        Paciente registrarPaciente(Paciente paciente);

        [OperationContract]
        List<Paciente> listarPacientes();

        [OperationContract]
        string generarCodigo(object clase);
    }
}
