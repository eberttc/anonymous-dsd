using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace DSDServices.Dominio
{
    [DataContract]
    public class Especialidad
    {
        [DataMember]
        public int Codigo { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string Descripcion { get; set; }
        [DataMember]
        public string estadoEntidad { get; set; }

        public Especialidad() {
            Nombre = string.Empty;
            Descripcion = string.Empty;
            estadoEntidad = string.Empty;
        }
    }
}