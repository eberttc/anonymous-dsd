using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DSDServices.Dominio;

namespace DSDServices.SOAPServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICitas" in both code and config file together.
    [ServiceContract]
    public interface ICitas
    {
        [OperationContract]
        RespuestaService<Cita> registrarCita(Cita cita);

        [OperationContract]
        RespuestaService<Cita> modificarCita(Cita cita);

        [OperationContract]
        void cancelarCita(Cita cita);

        [OperationContract]
        List<Cita> listarCitas();

        [OperationContract]
        List<ConsultaCita> consultarCitas(string fecha,int especialidad,string odontologo);

    }
}
