using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SOAPServices.Dominio;

namespace SOAPServices.Servicios.Pacientes
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IPacientes" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IPacientes
    {
        [OperationContract]
        RespuestaService<Paciente> registrarPaciente(Paciente paciente);

        [OperationContract]
        RespuestaService<Paciente> modificarPaciente(Paciente paciente);

        [OperationContract]
        List<Paciente> listarPacientes();
    }
}
