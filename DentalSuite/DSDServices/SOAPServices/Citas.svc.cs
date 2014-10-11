using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DSDServices.Persistencia;
using DSDServices.Dominio;
using DSDServices.Reutilizables;
using System.Messaging;

namespace DSDServices.SOAPServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Citas" in code, svc and config file together.
    public class Citas : ICitas
    {
        private CitaDAO citaDAO = null;
        private CitaDAO CitaDAO
        {
            get
            {
                if (citaDAO == null)
                    citaDAO = new CitaDAO();
                return citaDAO;
            }
        }

        //Horario
        private HorarioDAO horarioDAO = null;
        private HorarioDAO HorarioDAO
        {
            get
            {
                if (horarioDAO == null)
                    horarioDAO = new HorarioDAO();
                return horarioDAO;
            }
        }


        private Utilitario util = null;
        RespuestaService<Cita> mensajeCita = null;



        public RespuestaService<Cita> registrarCita(Cita cita)
        {
            util = new Utilitario();
            try
            {
                Cita citaACrear = new Cita();

                citaACrear.FechaReserva = cita.FechaReserva;
                citaACrear.CodigoEspecialidad = cita.CodigoEspecialidad;
                citaACrear.CodigoPaciente = cita.CodigoPaciente;
              //  citaACrear.CodigoHorarioOdontologo = cita.CodigoHorarioOdontologo;
                citaACrear.CodigoHorario = cita.CodigoHorario;
                citaACrear.CodigoOdontologo = cita.CodigoOdontologo;
                citaACrear.Estado = Constantes.VERDADERO;

                //Validaciones
                //1) Validar solo puede realizar una cita cada 24 horas

                //Obtenenemos ultima fecha de reserva del paciente a registrar
                Cita citaPrevia = CitaDAO.ObtenerUltimaCitaPaciente(citaACrear);
                if (citaPrevia != null)
                {
                    int condicion = util.validarRangoHorasCita(citaPrevia.FechaReserva, citaACrear.FechaReserva);
                    if (condicion < 1)
                    {
                        //Creamos mensaje de ADVERTENCIA para enviar
                        mensajeCita = new RespuestaService<Cita>("Para realizar una Reserva de cita debe pasar 24 horas desde la última que registró",
                                              "Advertencia",
                                              "Registro de Cita",
                                              "ICitas",
                                              "validarRangoHorasCita",
                                              citaACrear);

                        return mensajeCita;
                    }
                }

                //Validaciones
                //2) Validar solo puede realizar una cita con 7 días de anticipación

                if (util.validarDiasAnticipacionCita(citaACrear.FechaReserva) > 7)
                {
                    //Creamos mensaje de ADVERTENCIA para enviar
                    mensajeCita = new RespuestaService<Cita>("Solo puede reservar una cita con 7 días de anticipación.",
                                          "Advertencia",
                                          "Registro de Cita",
                                          "ICitas",
                                          "validarDiasAnticipacionCita",
                                          citaACrear);

                    return mensajeCita;
                }

                // Grabamos una cita
                Cita citaCreado = CitaDAO.Crear(citaACrear);

                //Actualizamos el estado del horario para que no pueda ser elegido
                HorarioDAO.ActualizarEstado(citaCreado,false);

                //Retornar Clase Mensaje con los datos a mostrar - Flujo Correcto
                mensajeCita = new RespuestaService<Cita>("Cita registrada correctamente. Codigo generado:" + cita.Codigo + " Fecha:" + citaCreado.FechaReserva,
                                    "Satisfactorio",
                                    "Registro de Cita",
                                    "ICitas",
                                    "CrearCita",
                                    citaCreado);

                enviarDatosACola(citaCreado);

                return mensajeCita;
            }
            catch (Exception ex)
            {
                mensajeCita = new RespuestaService<Cita>("Error de Sitema :" + ex.ToString(),
                                    "Error",
                                    "Registro de Cita",
                                    "ICitas",
                                    "Excepcion",
                                    null);

                return mensajeCita;
            }
        }

        private void enviarDatosACola(Cita cita)
        {
            // 1. Enviamos la nota original vía la cola de entrada del servidor (In)
            string rutaColaIn = @".\private$\CitasClinica";
            if (!MessageQueue.Exists(rutaColaIn))
                MessageQueue.Create(rutaColaIn);
            MessageQueue colaIn = new MessageQueue(rutaColaIn);
            Message mensajeIn = new Message();
            mensajeIn.Label = "Cita";
            mensajeIn.Body = new Cita() { Codigo =cita.Codigo, CodigoPaciente = cita.CodigoPaciente, FechaReserva = cita.FechaReserva , CodigoEspecialidad=cita.CodigoEspecialidad,
                                          CodigoOdontologo =cita.CodigoOdontologo,CodigoHorario=cita.CodigoHorario,Estado=cita.Estado};
            colaIn.Send(mensajeIn);

        }

            

        public RespuestaService<Cita> modificarCita(Cita cita)
        {
            util = new Utilitario();
            try
            {
                Cita citaAModificar = new Cita();

                citaAModificar.Codigo = cita.Codigo;
                citaAModificar.FechaReserva = cita.FechaReserva;
                citaAModificar.CodigoEspecialidad = cita.CodigoEspecialidad;
                citaAModificar.CodigoPaciente = cita.CodigoPaciente;
               // citaAModificar.CodigoHorarioOdontologo = cita.CodigoHorarioOdontologo;
                citaAModificar.CodigoHorario = cita.CodigoHorario;
                citaAModificar.CodigoOdontologo = cita.CodigoOdontologo;
                citaAModificar.Estado = Constantes.VERDADERO;

                //Validaciones
                //1) Validar solo puede realizar una cita con 7 días de anticipación
                if (util.validarDiasAnticipacionCita(citaAModificar.FechaReserva) > 7)
                {
                    //Creamos mensaje de ADVERTENCIA para enviar
                    mensajeCita = new RespuestaService<Cita>("Solo puede reservar una cita con 7 días de anticipación.",
                                          "Advertencia",
                                          "Registro de Cita",
                                          "ICitas",
                                          "validarDiasAnticipacionCita",
                                          citaAModificar);

                    return mensajeCita;
                }
                Cita citaActual = CitaDAO.Obtener(citaAModificar.Codigo);
                Cita citaModificado = CitaDAO.Modificar(citaAModificar);
                

                if (citaActual.CodigoHorario != citaAModificar.CodigoHorario ||
                    citaActual.CodigoOdontologo != citaAModificar.CodigoOdontologo)
                {
                    //cambiado de horario u odontologo  - Liberar el horario u odontologo
                    HorarioDAO.ActualizarEstado(citaActual, true);
                    HorarioDAO.ActualizarEstado(citaModificado, false);
                }
               
               
                //Retornar Clase Mensaje con los datos a mostrar - Flujo Correcto
                mensajeCita = new RespuestaService<Cita>("Cita modificada correctamente. Codigo generado:" + cita.Codigo + " Nueva Fecha: " + citaModificado.FechaReserva,
                                    "Satisfactorio",
                                    "Registro de Cita",
                                    "ICitas",
                                    "CrearCita",
                                    citaModificado);

                return mensajeCita;
            }
            catch (Exception ex)
            {
                mensajeCita = new RespuestaService<Cita>("Error de Sitema :" + ex.ToString(),
                                    "Error",
                                    "Modificar Cita",
                                    "ICitas",
                                    "Excepcion",
                                    null);

                return mensajeCita;
            }
        }

        public List<Cita> listarCitas()
        {
            return CitaDAO.ListarTodos();
        }

        public void cancelarCita(Cita cita)
        {
            CitaDAO.LiberarCita(cita);
        }

        public List<ConsultaCita> consultarCitas(string fecha,int especialidad,string odontologo)
        {
            return CitaDAO.ConsultarCitas(fecha,especialidad,odontologo);
        }
    }
}
