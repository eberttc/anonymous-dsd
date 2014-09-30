using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using DSDServices.Persistencia;

namespace DSDServices.Dominio
{
    [DataContract]
    public class Respuesta<Entidad>
    {

        [DataMember]
        public string MensajeDescripcion { get; set; }
        [DataMember]
        public string TipoMensaje { get; set; }
        [DataMember]
        public string Titulo { get; set; }
        [DataMember]
        public string ServicioOrigen { get; set; }
        [DataMember]
        public string MetodoOrigen { get; set; }
        [DataMember]
        public Entidad ClaseOrigen { get; set; }

        public Respuesta(string mensajeDescripcion, string tipoMensaje, string titulo, string servicioOrigen,
                       string metodoOrigen, Entidad claseOrigen)
        {
            MensajeDescripcion = mensajeDescripcion;
            TipoMensaje = tipoMensaje;
            Titulo = titulo;
            ServicioOrigen = servicioOrigen;
            MetodoOrigen = metodoOrigen;
            ClaseOrigen = claseOrigen;
        }




    }
}