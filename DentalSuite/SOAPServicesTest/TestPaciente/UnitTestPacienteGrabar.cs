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
            objPaciente.ApePaterno = "Valdivias";
            objPaciente.ApeMaterno = "Cornejo";
            objPaciente.Sexo = "F";
            objPaciente.TipoDocumento = "DNI";
            objPaciente.NumeroDocumento = "43128304";
            objPaciente.Codigo = "lifesux.o.o@gmail.com";
            objPaciente.Contrasena = "123456Aa";

            //Registrando un nuevo paciente
            PacienteWS.Mensaje mensaje =  pacienteWs.registrarPaciente(objPaciente);

            Assert.AreEqual("Satisfactorio", mensaje.TipoMensaje);


        }
    }
}
