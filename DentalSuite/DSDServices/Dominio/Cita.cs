using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace DSDServices.Dominio
{
    [DataContract]
    public class Cita
    {
        [DataMember]
        public int Codigo { get; set; }
        [DataMember]
        public DateTime FechaReserva { get; set; }
        [DataMember]
        public int CodigoEspecialidad { get; set; }
        [DataMember]
        public string CodigoPaciente { get; set; }
        [DataMember]
        public int CodigoHorarioOdontologo { get; set; }
        [DataMember]
        public bool Estado { get; set; }
      
    }
}