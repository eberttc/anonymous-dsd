using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSDServicesTEST.Dominio
{
    public class Especialidad
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string estadoEntidad { get; set; }
        public Especialidad() {
            nombre = string.Empty;
            descripcion = string.Empty;
            estadoEntidad = string.Empty;
        }
    }
}
