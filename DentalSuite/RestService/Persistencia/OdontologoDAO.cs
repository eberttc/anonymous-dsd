using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestService.Dominio;
using System.Data.SqlClient;

namespace RestService.Persistencia
{
    public class OdontologoDAO:BaseDAO<Odontologo,string>
    {

        public Odontologo BuscarCorreoRepetido(string correo)
        {

            Odontologo OdontologoEncontrado = null;
            string sql = "Select * from Odontologo where Correo=@Correo";
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@Correo", correo));
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            OdontologoEncontrado = new Odontologo()
                            {


                                Codigo = (string)resultado["Codigo"]


                            };

                        }

                    }

                }


            }
            return OdontologoEncontrado;

        }

        public Odontologo BuscarCOPRepetido(string cop)
        {

            Odontologo OdontologoEncontrado = null;
            string sql = "Select * from Odontologo where COP=@COP";
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@COP", cop));
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            OdontologoEncontrado = new Odontologo()
                            {


                                Codigo = (string)resultado["Codigo"]


                            };

                        }

                    }

                }


            }
            return OdontologoEncontrado;

        }
    }
}