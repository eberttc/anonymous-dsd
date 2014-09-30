using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DSDServices.Dominio;
using DSDServices.Persistencia;
using DSDServices.Reutilizables;

namespace DSDServices.SOAPServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Pacientes" in code, svc and config file together.
    public class Pacientes : IPacientes
    {
        private PacienteDAO pacienteDAO = null;
        private PacienteDAO PacienteDAO
        {
            get
            {
                if (pacienteDAO == null)
                    pacienteDAO = new PacienteDAO();
                return pacienteDAO;
            }
        }


        private Utilitario util = null;
        RespuestaService<Paciente> mensajePaciente = null;


        public RespuestaService<Paciente> registrarPaciente(Dominio.Paciente paciente)
        {
            util = new Utilitario();
            try
            {

                string codigoGenerado = util.generarCodigo(paciente);
                Paciente pacienteACrear = new Paciente();
                //Paciente pacienteACrear = new Paciente()
                //{
                pacienteACrear.Codigo = codigoGenerado;
                pacienteACrear.NumeroDocumento = paciente.NumeroDocumento;
                pacienteACrear.Nombres = paciente.Nombres;
                pacienteACrear.ApePaterno = paciente.ApePaterno;
                pacienteACrear.ApeMaterno = paciente.ApeMaterno;
                pacienteACrear.Correo = paciente.Correo;
                pacienteACrear.Sexo = paciente.Sexo;
                pacienteACrear.TipoDocumento = paciente.TipoDocumento;
                pacienteACrear.Contrasena = paciente.Contrasena;

                //};
                //Validaciones
                //1) Validar complejidad de la clave
                bool condicion = util.validarClave(paciente.Contrasena);
                //bool condicion = util.validarClave(pacienteACrear.Contrasena);
                //bool condicion = true;
                if (condicion == false)
                {
                    //Creamos mensaje de ERROR para enviar
                    mensajePaciente = new RespuestaService<Paciente>("La contraseña debe contener al menos una letra mayuscula, una minúscula, un número y mas de 6 digitos",
                                          "Advertencia",
                                          "Registro de Paciente",
                                          "IPaciente",
                                          "ValidarClave",
                                          pacienteACrear);

                    return mensajePaciente;
                }
                //2) Validar paciente no exista
                if (PacienteDAO.Obtener(codigoGenerado) != null)
                {
                    mensajePaciente = new RespuestaService<Paciente>("El paciente que esta intentando crear ya existe",
                                         "Advertencia",
                                         "Registro de Paciente",
                                         "IPaciente",
                                         "ValidarPacienteCreado",
                                         pacienteACrear);

                    return mensajePaciente;
                }


                // Grabamos Paciente
                Paciente pacienteCreado = PacienteDAO.Crear(pacienteACrear);

                //Retornar Clase Mensaje con los datos a mostrar - Flujo Correcto

                mensajePaciente = new RespuestaService<Paciente>("Paciente creado correctamente. Codigo generado:" + codigoGenerado,
                                    "Satisfactorio",
                                    "Registro de Paciente",
                                    "IPaciente",
                                    "CrearPaciente",
                                    pacienteCreado);

                return mensajePaciente;
            }
            catch (Exception ex)
            {
                mensajePaciente = new RespuestaService<Paciente>("Error de Sitema :" + ex.ToString(),
                                    "Error",
                                    "Registro de Paciente",
                                    "IPaciente",
                                    "Excepcion",
                                    null);

                return mensajePaciente;
            }
        }

        public List<Dominio.Paciente> listarPacientes()
        {
            return PacienteDAO.ListarTodos().ToList();
        }

        public RespuestaService<Paciente> modificarPaciente(Paciente paciente)
        {
            util = new Utilitario();
            try
            {

                Paciente pacienteAModificar = new Paciente()
                {
                    Codigo = paciente.Codigo,
                    NumeroDocumento = paciente.NumeroDocumento,
                    Nombres = paciente.Nombres,
                    ApePaterno = paciente.ApePaterno,
                    ApeMaterno = paciente.ApeMaterno,
                    Correo = paciente.Correo,
                    Sexo = paciente.Sexo,
                    TipoDocumento = paciente.TipoDocumento,
                    Contrasena = paciente.Contrasena,

                };
                //Validaciones
                //1) Validar complejidad de la clave
                bool condicion = util.validarClave(paciente.Contrasena);
                if (condicion == false)
                {
                    //Creamos mensaje de ERROR para enviar
                    mensajePaciente = new RespuestaService<Paciente>("La contraseña debe contener al menos una letra mayuscula, una minúscula, un número y mas de 6 digitos",
                                          "Advertencia",
                                          "Modificar Paciente",
                                          "IPaciente",
                                          "ValidarClave",
                                          pacienteAModificar);

                    return mensajePaciente;
                }

                // Grabamos Paciente
                Paciente pacienteModificado = PacienteDAO.Modificar(pacienteAModificar);

                //Retornar Clase Mensaje con los datos a mostrar - Flujo Correcto
                mensajePaciente = new RespuestaService<Paciente>("Paciente modificado correctamente",
                                    "Satisfactorio",
                                    "Modificar Paciente",
                                    "IPaciente",
                                    "ModificarPaciente",
                                    pacienteModificado);

                return mensajePaciente;
            }
            catch (Exception ex)
            {
                mensajePaciente = new RespuestaService<Paciente>("Error de Sitema :" + ex.ToString(),
                                    "Error",
                                    "Modificar Paciente",
                                    "IPaciente",
                                    "Exeption",
                                    null);

                return mensajePaciente;

            }
        }
    }
}
