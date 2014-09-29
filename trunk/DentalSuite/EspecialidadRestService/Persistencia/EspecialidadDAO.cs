using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace EspecialidadRestService.Persistencia
{
    public class EspecialidadDAO:BaseDAO<Dominio.Especialidad,int>
    {

        public Dominio.Especialidad BuscarNombreRepetido(string nombre)
        {

            Dominio.Especialidad EspecialidadEncontrado = null;
            string sql = "Select * from Especialidad where Nombre=@Nom";
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@Nom", nombre));
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            EspecialidadEncontrado = new Dominio.Especialidad
                            {
                                Codigo = (int)resultado["Codigo"]

                            };

                        }

                    }

                }


            }
            return EspecialidadEncontrado;

        }
       
    }
}