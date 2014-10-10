using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DSDServices.Dominio;
using System.Data.SqlClient;

namespace DSDServices.Persistencia
{
    public class HorarioDAO
    {
        public void ActualizarEstado(Cita citaACrear)
        {
            string sql = "UPDATE THorario SET estado = 0 ";
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.ExecuteNonQuery();
                }
            }
        }
      

    }
}