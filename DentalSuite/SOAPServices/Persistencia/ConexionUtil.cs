using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOAPServices.Persistencia
{
    public class ConexionUtil
    {
        public static string ObtenerCadena()
        {
            return "Data Source=(local);Initial Catalog=DBDentalSuite;Integrated Security=SSPI;";
        }

        public static string Cadena
        {
            get
            {
                return "Data Source=(local);Initial Catalog=DBDentalSuite;Integrated Security=SSPI;";
            }
        }
    }
}