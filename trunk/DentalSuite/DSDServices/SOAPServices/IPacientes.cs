using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DSDServices.Dominio;


namespace DSDServices.SOAPServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPacientes" in both code and config file together.
    [ServiceContract]
    public interface IPacientes
    {
        [OperationContract]
        Respuesta<Paciente> registrarPaciente(Paciente paciente);

        [OperationContract]
        Respuesta<Paciente> modificarPaciente(Paciente paciente);

        [OperationContract]
        List<Paciente> listarPacientes();
    }
}
