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
        public void ActualizarEstado(Cita citaCreada,bool estado)
        {
            string sql="";

            if(estado==true)
             sql = "UPDATE THorarioOdontologo SET estado = 1 where codigoTHorario = @codHor and codigoTOdontologo= @codOdont";
            else
             sql = "UPDATE THorarioOdontologo SET estado = 0 where codigoTHorario = @codHor and codigoTOdontologo= @codOdont";

            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@codHor", citaCreada.CodigoHorario));
                    com.Parameters.Add(new SqlParameter("@codOdont", citaCreada.CodigoOdontologo));
                    com.ExecuteNonQuery();
                }
            }
        }

      

    }
}