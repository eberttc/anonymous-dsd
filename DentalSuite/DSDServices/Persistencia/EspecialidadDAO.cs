using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using DSDServices.Dominio;
using DSDServices.Persistencia;

namespace DSDServices.Persistencia
{
    public class EspecialidadDAO
    {
        public Especialidad Crear(Especialidad especialidadACrear)
        {
            Especialidad espacialidadCreado = null;
            int resultado = 0;
            string sql = "INSERT INTO TEspecialidad VALUES (@nom, @des)  SELECT @@IDENTITY";
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@nom", especialidadACrear.Nombre));
                    com.Parameters.Add(new SqlParameter("@des", especialidadACrear.Descripcion));
                
                   try
                   {
                       resultado = Convert.ToInt32(com.ExecuteScalar());
                   }
                   catch
                   {
                       resultado = 0;
                   }
                }
            }
            espacialidadCreado = Obtener(resultado.ToString());
            espacialidadCreado.estadoEntidad =string.Format("Satisfactorio {0}",espacialidadCreado.Codigo);
            return espacialidadCreado;
        }
        public Especialidad Obtener(string codigo)
        {
            int codigoValor =int.Parse(codigo);
            Especialidad especialidadEncontrado = null;
            string sql = "SELECT * FROM TEspecialidad WHERE codigo=@cod";
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@cod", codigoValor));
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            especialidadEncontrado = new Especialidad()
                            {
                                Codigo = (int)resultado["Codigo"],
                                Nombre = (string)resultado["Nombre"],
                                Descripcion = (string)resultado["Descripcion"],
                                estadoEntidad = "Existente",
                            };
                        }
                    }
                }
            }
            return especialidadEncontrado;
        }

        public Especialidad ObtenerPorNombre(string nombre)
        {
            Especialidad especialidadEncontrado = null;
            string sql = "SELECT * FROM TEspecialidad WHERE nombre=@nom";
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@nom", nombre));
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            especialidadEncontrado = new Especialidad()
                            {
                                Codigo = (int)resultado["Codigo"],
                                Nombre = (string)resultado["Nombre"],
                                Descripcion = (string)resultado["Descripcion"],
                            };
                        }
                    }
                }
            }
            return especialidadEncontrado;
        }

        public Especialidad Modificar(Especialidad especialidadAModificar)
        {
            Especialidad especialidadModificado = null;
            try
            {
                string sql = "UPDATE TEspecialidad SET Nombre=@nom,Descripcion=@des WHERE codigo=@cod";
                using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
                {
                    con.Open();
                    using (SqlCommand com = new SqlCommand(sql, con))
                    {
                        com.Parameters.Add(new SqlParameter("@cod", especialidadAModificar.Codigo));
                        com.Parameters.Add(new SqlParameter("@nom", especialidadAModificar.Nombre));
                        com.Parameters.Add(new SqlParameter("@des", especialidadAModificar.Descripcion));
                        com.ExecuteNonQuery();
                    }
                }
                especialidadModificado = Obtener(especialidadAModificar.Codigo.ToString());
                especialidadModificado.estadoEntidad = "Actualizado OK";
            }
            catch (Exception)
            {
                especialidadModificado.estadoEntidad = "ERROR";
            }

            return especialidadModificado;
        }
        public void Eliminar(string codigo)
        {
            int codigoValor = int.Parse(codigo);
            string sql = "DELETE FROM TEspecialidad WHERE codigo=@cod";
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@cod", codigoValor));
                    com.ExecuteNonQuery();
                }
            }
        }
        public List<Especialidad> ListarTodos()
        {
            List<Especialidad> especialidadesEncontrados = new List<Especialidad>();
            Especialidad espacialidadEncontrado = null;
            string sql = "SELECT * FROM TEspecialidad";
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            espacialidadEncontrado = new Especialidad()
                            {
                                Codigo = (int)resultado["Codigo"],
                                Nombre = (string)resultado["Nombre"],
                                Descripcion = (string)resultado["Descripcion"],
                            };
                            especialidadesEncontrados.Add(espacialidadEncontrado);
                        }
                    }
                }
            }
            return especialidadesEncontrados;
        }
    }
}