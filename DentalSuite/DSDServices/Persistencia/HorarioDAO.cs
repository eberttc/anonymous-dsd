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

        public List<Odontologo> ListarHorarios()
        {
            List<Odontologo> odontologosEncontrados = new List<Odontologo>();
            Odontologo odontologoEncontrado = null;
            string sql = "SELECT * FROM TOdontologo";
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            odontologoEncontrado = new Odontologo()
                            {
                                Codigo = (string)resultado["Codigo"],
                                NumeroDocumento = (string)resultado["TipoDocumento"],
                                Nombres = (string)resultado["Nombres"],
                                ApePaterno = (string)resultado["ApellidoPaterno"],
                                MatPaterno = (string)resultado["ApellidoMaterno"],
                                Sexo = (string)resultado["Sexo"],
                                TipoDocumento = (string)resultado["TipoDocumento"],
                                Correo = (string)resultado["Correo"],
                                Contrasena = (string)resultado["Contrasena"],
                                COP = (string)resultado["COP"],
                                nombreCompleto = string.Format("{0} {1}, {2}", (string)resultado["ApellidoPaterno"], (string)resultado["ApellidoMaterno"], (string)resultado["Nombres"])
                            };
                            odontologosEncontrados.Add(odontologoEncontrado);
                        }
                    }
                }
            }
            return odontologosEncontrados;
        }

    }
}