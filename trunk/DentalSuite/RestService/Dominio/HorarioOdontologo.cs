using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace RestService.Dominio
{
    [DataContract]
    public class HorarioOdontologo
    {
        [DataMember]
        public int Codigo { get; set; }

        [DataMember]
        public string  CodigoOdontologico { get; set; }

        [DataMember]
        public string CodigoHorario { get; set; }
       
        [DataMember]
        public DateTime FechaCita { get; set; }
       
        [DataMember]
        public int Estado { get; set; }

    }
}