using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using DSDServices.Dominio;
using DSDServices.Persistencia;
namespace DSDServices.Persistencia
{
    public class OdontologoDAO
    {
        public List<Odontologo> ListarTodos()
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
                                Codigo =(string)resultado["Codigo"],
                                NumeroDocumento =(string)resultado["TipoDocumento"],
                                Nombres =(string)resultado["Nombres"],
                                ApePaterno =(string)resultado["ApellidoPaterno"],
                                MatPaterno =(string)resultado["ApellidoMaterno"],
                                Sexo =(string)resultado["Sexo"],
                                TipoDocumento =(string)resultado["TipoDocumento"],
                                Correo =(string)resultado["Correo"],
                                Contrasena =(string)resultado["Contrasena"],
                                COP =(string)resultado["COP"],
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