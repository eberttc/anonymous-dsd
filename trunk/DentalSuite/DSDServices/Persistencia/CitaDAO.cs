using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DSDServices.Dominio;
using System.Data.SqlClient;

namespace DSDServices.Persistencia
{
    public class CitaDAO
    {
        public Cita Crear(Cita citaACrear)
        {
            int codigo = 0;
            Cita citaCreado = null;
           // string sql = "INSERT INTO TReservaCita VALUES (@fecha, @codEps,@codPac,@codHor,@estado)  SELECT @@IDENTITY";
            string sql = "INSERT INTO TReservaCita VALUES (@fecha, @codEps,@codPac,@codHor,@codOdont,@estado)  SELECT @@IDENTITY";
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@fecha", citaACrear.FechaReserva));
                    com.Parameters.Add(new SqlParameter("@codEps", citaACrear.CodigoEspecialidad));
                    com.Parameters.Add(new SqlParameter("@codPac", citaACrear.CodigoPaciente));
                    com.Parameters.Add(new SqlParameter("@codHor", citaACrear.CodigoHorario));
                    com.Parameters.Add(new SqlParameter("@codOdont", citaACrear.CodigoOdontologo));
                    com.Parameters.Add(new SqlParameter("@estado", citaACrear.Estado));
                    codigo = Int32.Parse(com.ExecuteScalar().ToString());
                }
            }
            citaCreado = Obtener(codigo);
            return citaCreado;
        }
        public Cita Obtener(int codigo)
        {
            Cita citaEncontrado = null;
            string sql = "SELECT * FROM TReservaCita WHERE codigo=@cod";
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@cod", codigo));
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            citaEncontrado = new Cita()
                            {
                                Codigo = (int)resultado["Codigo"],
                                FechaReserva = (DateTime)resultado["FechaReserva"],
                                CodigoEspecialidad = (int)resultado["CodigoEspecialidad"],
                                CodigoPaciente = (string)resultado["CodigoPaciente"],
                               // CodigoHorarioOdontologo = (int)resultado["CodigoHorarioOdontologo"],
                                CodigoHorario = (int)resultado["CodigoHorario"],
                                CodigoOdontologo = (string)resultado["CodigoOdontologo"],
                                Estado = (bool)resultado["Estado"],
                            };
                        }
                    }
                }
            }
            return citaEncontrado;
        }

        public Cita ObtenerPorFechaYPaciente(Cita cita)
        {
            Cita citaEncontrado = null;
            string sql = "SELECT * FROM TReservaCita WHERE where FechaReserva = @fecha  and CodigoPaciente = @codpac";
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@cod", cita.FechaReserva));
                    com.Parameters.Add(new SqlParameter("@cod", cita.CodigoPaciente));
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            citaEncontrado = new Cita()
                            {
                                Codigo = (int)resultado["Codigo"],
                                FechaReserva = (DateTime)resultado["FechaReserva"],
                                CodigoEspecialidad = (int)resultado["CodigoEspecialidad"],
                                CodigoPaciente = (string)resultado["CodigoPaciente"],
                              //  CodigoHorarioOdontologo = (int)resultado["CodigoHorarioOdontologo"],
                                CodigoHorario = (int)resultado["CodigoHorario"],
                                CodigoOdontologo = (string)resultado["CodigoOdontologo"],
                                Estado = (bool)resultado["Estado"],
                            };
                        }
                    }
                }
            }
            return citaEncontrado;
        }


        public Cita Modificar(Cita citaAModificar)
        {
            Cita citaModificado = null;
          //  string sql = "UPDATE TReservaCita SET FechaReserva=@fecha,CodigoEspecialidad=@codEsp,CodigoHorarioOdontologo=@codHor WHERE Codigo=@cod";
            string sql = "UPDATE TReservaCita SET FechaReserva=@fecha,CodigoEspecialidad=@codEsp,CodigoHorario=@codHor,CodigoOdontologo=@codOdont WHERE Codigo=@cod";
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@cod", citaAModificar.Codigo));
                    com.Parameters.Add(new SqlParameter("@fecha", citaAModificar.FechaReserva));
                    com.Parameters.Add(new SqlParameter("@codEsp", citaAModificar.CodigoEspecialidad));
                    com.Parameters.Add(new SqlParameter("@codHor", citaAModificar.CodigoHorario));
                    com.Parameters.Add(new SqlParameter("@codOdont", citaAModificar.CodigoOdontologo));
                  
                    com.ExecuteNonQuery();
                }
            }
            citaModificado = Obtener(citaAModificar.Codigo);
            return citaModificado;
        }

        public Cita ObtenerUltimaCitaPaciente(Cita cita)
        {
            Cita citaEncontrado = null;
            string sql = "SELECT TOP 1 * FROM TReservaCita WHERE codigoPaciente=@codpaciente and Estado =1  order by Codigo desc";
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@codpaciente", cita.CodigoPaciente));
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            citaEncontrado = new Cita()
                            {
                                Codigo = (int)resultado["Codigo"],
                                FechaReserva = (DateTime)resultado["FechaReserva"],
                                CodigoEspecialidad = (int)resultado["CodigoEspecialidad"],
                                CodigoPaciente = (string)resultado["CodigoPaciente"],
                                CodigoHorario = (int)resultado["CodigoHorario"],
                                CodigoOdontologo = (string)resultado["CodigoOdontologo"],
                            //    CodigoHorarioOdontologo = (int)resultado["CodigoHorarioOdontologo"],
                                Estado = (bool)resultado["Estado"],
                            };
                        }
                    }
                }
            }
            return citaEncontrado;
        }

        public List<Cita> ListarTodos()
        {
            List<Cita> citasEncontrados = new List<Cita>();
            Cita citaEncontrado = null;
            string sql = "SELECT * FROM TReservaCita where Estado=1";
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            citaEncontrado = new Cita()
                            {
                                Codigo = (int)resultado["Codigo"],
                                FechaReserva = (DateTime)resultado["FechaReserva"],
                                CodigoEspecialidad = (int)resultado["CodigoEspecialidad"],
                                CodigoPaciente = (string)resultado["CodigoPaciente"],
                                //  CodigoHorarioOdontologo = (int)resultado["CodigoHorarioOdontologo"],
                                CodigoHorario = (int)resultado["CodigoHorario"],
                                CodigoOdontologo = (string)resultado["CodigoOdontologo"],
                                Estado = (bool)resultado["Estado"],
                            };
                            citasEncontrados.Add(citaEncontrado);
                        }
                    }
                }
            }
            return citasEncontrados;
        }

        public void LiberarCita(Cita cita)
        {
            string sql = "UPDATE TReservaCita SET ESTADO=0 WHERE codigo=@cod";
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@cod", cita.Codigo));
                    com.ExecuteNonQuery();
                }
            }
        }

        public List<Cita> ListarRolPacienteAdministrador(Cita cita)
        {
            List<Cita> citasEncontrados = new List<Cita>();
            Cita citaEncontrado = null;
            string sql = "SELECT * FROM TReservaCita where  CodigoEspecialidad = @codesp and Estado=1 and CodigoPaciente = @codpac ";
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@codesp", cita.CodigoEspecialidad));
                    com.Parameters.Add(new SqlParameter("@codpac", cita.CodigoPaciente));
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            citaEncontrado = new Cita()
                            {
                                Codigo = (int)resultado["Codigo"],
                                FechaReserva = (DateTime)resultado["FechaReserva"],
                                CodigoEspecialidad = (int)resultado["CodigoEspecialidad"],
                                CodigoPaciente = (string)resultado["CodigoPaciente"],
                                //  CodigoHorarioOdontologo = (int)resultado["CodigoHorarioOdontologo"],
                                CodigoHorario = (int)resultado["CodigoHorario"],
                                CodigoOdontologo = (string)resultado["CodigoOdontologo"],
                                Estado = (bool)resultado["Estado"],
                            };
                            citasEncontrados.Add(citaEncontrado);
                        }
                    }
                }
            }
            return citasEncontrados;
        }

        public List<ConsultaCita> ConsultarCitas(string fecha, int especialidad,string odontologo)
        {
            List<ConsultaCita> citasEncontrados = new List<ConsultaCita>();
            ConsultaCita citaEncontrado = null;
            string sql = "select a.Codigo cita,CONVERT(char(8),FechaReserva,112) fecha, "
                    +"b.Nombre especialidad,"
                    +"d.ApellidoPaterno+' '+d.ApellidoMaterno+', '+d.Nombres odontologo,"
                    +"c.ApellidoPaterno+' '+c.ApellidoMaterno+', '+c.Nombres paciente,"
                     +"e.HoraInicio+'-'+e.HoraTermino horario "
                    +"from TReservaCita a "
                    +"inner join TEspecialidad b on a.CodigoEspecialidad=b.Codigo "
                    +"inner join TPaciente c on a.CodigoPaciente=c.Codigo "
                    +"inner join TOdontologo d on a.CodigoOdontologo=d.Codigo "
                    +"inner join THorario e on a.CodigoHorario=e.Codigo "
                    + "where (a.CodigoOdontologo=@odontologo OR a.CodigoEspecialidad=@especialidad) "
                    + "and CONVERT(char(8),FechaReserva,112)=@fecha "
                        +"order by e.HoraInicio,e.HoraTermino";

            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@fecha", fecha));
                    com.Parameters.Add(new SqlParameter("@especialidad", especialidad));
                    com.Parameters.Add(new SqlParameter("@odontologo", odontologo));
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            citaEncontrado = new ConsultaCita()
                            {
                                cita = (int)resultado["cita"],
                                fecha = (string)resultado["fecha"],
                                especialidad = (string)resultado["especialidad"],
                                odontologo = (string)resultado["odontologo"],
                                paciente = (string)resultado["paciente"],
                                horario = (string)resultado["horario"],
                            };
                            citasEncontrados.Add(citaEncontrado);
                        }
                    }
                }
            }
            return citasEncontrados;
        }
    }
}