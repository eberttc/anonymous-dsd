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
                citaACrear.CodigoHorarioOdontologo = cita.CodigoHorarioOdontologo;
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

                // Grabamos Paciente
                Cita citaCreado = CitaDAO.Crear(citaACrear);

                //Retornar Clase Mensaje con los datos a mostrar - Flujo Correcto
                mensajeCita = new RespuestaService<Cita>("Cita registrada correctamente. Codigo generado:" + cita.Codigo + " Fecha:" + citaCreado.FechaReserva,
                                    "Satisfactorio",
                                    "Registro de Cita",
                                    "ICitas",
                                    "CrearCita",
                                    citaCreado);

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
                citaAModificar.CodigoHorarioOdontologo = cita.CodigoHorarioOdontologo;
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

                Cita citaModificado = CitaDAO.Modificar(citaAModificar);

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

        public List<Cita> listarCitasPacienteAdministrador()
        {
            string rutaCola = @".\private$\ListaReservaCitas";
            if (!MessageQueue.Exists(rutaCola))
                MessageQueue.Create(rutaCola);
            MessageQueue cola = new MessageQueue(rutaCola);
            cola.Formatter = new XmlMessageFormatter(new Type[] { typeof(Cita) });
            Message mensaje = cola.Receive();

            Cita cita = (Cita)mensaje.Body;

            return CitaDAO.ListarRolPacienteAdministrador(cita);



            /*  Cita respuesta = CitaDAO.Obtener(3);

              mensaje.Body = new Cita()
              {
                  Codigo = respuesta.Codigo,
                  FechaReserva = respuesta.FechaReserva,
                  CodigoEspecialidad = respuesta.CodigoEspecialidad,
                  CodigoPaciente = respuesta.CodigoPaciente,
                  CodigoHorarioOdontologo = respuesta.CodigoHorarioOdontologo,
                  Estado = respuesta.Estado
              };

              cola.Send(mensaje);*/
        }
    }
}
