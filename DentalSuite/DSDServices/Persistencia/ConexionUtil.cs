﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DSDServices.Persistencia
{
    public class ConexionUtil
    {
        public static string ObtenerCadena()
        {
            return "Data Source=CP090102\\SQLEXPRESS;Initial Catalog=DBDentalSuite2;Integrated Security=SSPI;";
        }

        public static string Cadena
        {
            get
            {
                return "Data Source=CP090102\\SQLEXPRESS;Initial Catalog=DBDentalSuite2;Integrated Security=SSPI;";
            }
        }
    }
}