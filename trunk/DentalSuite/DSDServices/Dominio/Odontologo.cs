using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace DSDServices.Dominio
{
    [DataContract]
    public class Odontologo
    {
        [DataMember]
        public string Codigo { get; set; }
        [DataMember]
        public string NumeroDocumento { get; set; }
         [DataMember]
        public string Nombres { get; set; }
         [DataMember]
        public string ApePaterno { get; set; }
         [DataMember]
        public string MatPaterno { get; set; }
         [DataMember]
        public string Sexo { get; set; }
         [DataMember]
        public string TipoDocumento { get; set; }
         [DataMember]
        public string NroDocumento { get; set; }
         [DataMember]
        public string Correo { get; set; }
         [DataMember]
        public string Contrasena { get; set; }
         [DataMember]
        public string COP { get; set; }
        [DataMember]
         public string nombreCompleto { get; set; }




        
    }
}