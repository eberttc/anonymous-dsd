using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SOAPServicesTest
{
    [TestClass]
    public class UnitTestPaciente
    {
        [TestMethod]
        public void TestGrabarPaciente()
        {
            PacienteWS.PacientesClient pacienteWs = new PacienteWS.PacientesClient();

            PacienteWS.Paciente objPaciente = new PacienteWS.Paciente();
            objPaciente.Nombres = "Karin";
            objPaciente.ApePaterno = "Valdivia";
            objPaciente.ApeMaterno = "Cornejo";
            objPaciente.Sexo = "F";
            objPaciente.TipoDocumento = "DNI";
            objPaciente.NumeroDocumento = "43128304";
            objPaciente.Codigo = "lifesux.o.o@gmail.com";
            objPaciente.Contrasena = "1234";

            //Registrando un nuevo paciente
            pacienteWs.registrarPaciente(objPaciente);

            //Listado de Pacientes
            List<PacienteWS.Paciente> listaPacientes =  pacienteWs.listarPacientes();

            //Obtenemos el numero de pacientes actual
            int contador = listaPacientes.Count();

            Assert.AreEqual(2, contador);


        }
    }
}
