using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace DSDServices.Dominio
{
    [DataContract]
    public class ConsultaCita
    {
        [DataMember]
        public int cita { get; set; }
        [DataMember]
        public string fecha { get; set; }
        [DataMember]
        public string especialidad { get; set; }
        [DataMember]
        public string odontologo { get; set; }
        [DataMember]
        public string paciente { get; set; }
        [DataMember]
        public string horario { get; set; }
      
    }

}