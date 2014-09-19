using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SOAPServices.Dominio;
using SOAPServices.Persistencia;

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


        public Dominio.Paciente registrarPaciente(Dominio.Paciente paciente)
        {
            string codigoGenerado = generarCodigo(paciente);
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
            return PacienteDAO.Crear(pacienteACrear);
        }

        public List<Dominio.Paciente> listarPacientes()
        {
            return PacienteDAO.ListarTodos().ToList();
        }

        public string generarCodigo(object clase)
        {
            if (clase.GetType() == typeof(Paciente))
            {
                Paciente clasePaciente = (Paciente)clase;
                return "p" + clasePaciente.NumeroDocumento;
            }
            else
            {
                Odontologo clasePaciente = (Odontologo)clase;
                return "o" + clasePaciente.NumeroDocumento;
            }
        }
    }
}
