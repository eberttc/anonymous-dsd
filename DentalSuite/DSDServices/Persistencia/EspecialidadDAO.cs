using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using SOAPServices.Dominio;
using SOAPServices.Persistencia;

namespace SOAPServices.Persistencia
{
    public class EspecialidadDAO
    {
        public Especialidad Crear(Especialidad especialidadACrear)
        {
            Especialidad espacialidadCreado = null;
            string sql = "INSERT INTO TEspecialidad VALUES (@nom, @des)";
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@nom", especialidadACrear.Nombre));
                    com.Parameters.Add(new SqlParameter("@des", especialidadACrear.Descripcion));
                   
                    com.ExecuteNonQuery();
                }
            }
            espacialidadCreado = Obtener(especialidadACrear.Nombre);
            return espacialidadCreado;
        }
        public Especialidad Obtener(string nombre)
        {
            Especialidad especialidadEncontrado = null;
            string sql = "SELECT * FROM TEspecialidad WHERE Nombre=@nom";
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
            string sql = "UPDATE TEspecialidad SET Nombre=@nom,Descripcion=@des WHERE Nombre=@nom";
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
            especialidadModificado = Obtener(especialidadAModificar.Nombre);
            return especialidadModificado;
        }
        public void Eliminar(Especialidad especialidadAEliminar)
        {
            string sql = "DELETE FROM TEspecialidad WHERE codigo=@cod";
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@cod", especialidadAEliminar.Codigo));
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