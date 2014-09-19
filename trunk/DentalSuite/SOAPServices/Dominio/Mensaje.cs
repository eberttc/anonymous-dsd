using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace SOAPServices.Dominio
{

    [DataContract]
    public class Mensaje
    {
        [DataMember]
        public string MensajeDescripcion {get;set;}
        [DataMember]
        public string TipoMensaje { get; set; }
        [DataMember]
        public string Titulo { get; set; }
        [DataMember]
        public string ServicioOrigen { get; set; }
    }
}