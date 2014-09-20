using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SOAPServices.Dominio;
using SOAPServices.Persistencia;
using SOAPServices.Reutilizables;

namespace SOAPServices
{ 
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

        private Utilitario util = new Utilitario();
        

        
        public Dominio.Mensaje registrarPaciente(Dominio.Paciente paciente)
        {
            try
            {
                string codigoGenerado = util.generarCodigo(paciente);

                Paciente pacienteACrear = new Paciente()
                {
                    Codigo = codigoGenerado,
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
                //bool condicion = validarClave(paciente.Contrasena);
                bool condicion = util.validarClave(paciente.Contrasena);
                if (condicion == false)
                {
                    //Creamos mensaje de ERROR para enviar
                    return util.crearMensaje("La contraseña debe contener al menos una letra mayuscula, una minúscula, un número y mas de 6 digitos",
                                          "Advertencia",
                                          "Registro de Paciente",
                                          "IPaciente");
                }
                //2) Validar paciente no exista
                if (PacienteDAO.Obtener(codigoGenerado) != null)
                {
                    return util.crearMensaje("El paciente que esta intentando crear ya existe",
                                         "Advertencia",
                                         "Registro de Paciente",
                                         "IPaciente");
                }

                // Grabamos Paciente
                PacienteDAO.Crear(pacienteACrear);

                //Retornar Clase Mensaje con los datos a mostrar - Flujo Correcto
                return util.crearMensaje("Paciente creado correctamente. Codigo generado:" + codigoGenerado,
                                    "Satisfactorio",
                                    "Registro de Paciente",
                                    "IPaciente");
            }
            catch (Exception ex)
            {
                return util.crearMensaje("Error de Sitema :" + ex.ToString(),
                                    "Error",
                                    "Registro de Paciente",
                                    "IPaciente");
            }
        }

        public List<Dominio.Paciente> listarPacientes()
        {
            return PacienteDAO.ListarTodos().ToList();
        }

        public Mensaje modificarPaciente(Paciente paciente)
        {
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
                    return util.crearMensaje("La contraseña debe contener al menos una letra mayuscula, una minúscula, un número y mas de 6 digitos",
                                          "Advertencia",
                                          "Modificar Paciente",
                                          "IPaciente");
                }

                // Grabamos Paciente
                PacienteDAO.Modificar(pacienteAModificar);

                //Retornar Clase Mensaje con los datos a mostrar - Flujo Correcto
                return util.crearMensaje("Paciente modificado correctamente",
                                    "Satisfactorio",
                                    "Modificar Paciente",
                                    "IPaciente");
            }
            catch (Exception ex)
            {
                return util.crearMensaje("Error de Sitema :" + ex.ToString(),
                                    "Error",
                                    "Modificar Paciente",
                                    "IPaciente");
            }
        }
    }
}
