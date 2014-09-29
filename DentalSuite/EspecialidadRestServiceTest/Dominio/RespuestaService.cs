using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EspecialidadRestServiceTest.Dominio
{
    public class RespuestaService<Entidad>
    {

        
        public string MensajeDescripcion { get; set; }
        
        public string TipoMensaje { get; set; }
        
        public string Titulo { get; set; }
        
        public string ServicioOrigen { get; set; }
        
        public string MetodoOrigen { get; set; }
        
        public Entidad ClaseOrigen { get; set; }

        public RespuestaService(string mensajeDescripcion, string tipoMensaje, string titulo, string servicioOrigen,
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
