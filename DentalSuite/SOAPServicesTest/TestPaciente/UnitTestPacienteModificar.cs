using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SOAPServicesTest.TestPaciente
{
    [TestClass]
    public class UnitTestPacienteModificar
    {
        [TestMethod]
        public void TestGrabarModificar()
        {
            PacienteWS.PacientesClient pacienteWs = new PacienteWS.PacientesClient();

            PacienteWS.Paciente objPaciente = new PacienteWS.Paciente();
            objPaciente.Codigo = "pKarinValdivia";
            objPaciente.Nombres = "Karin";
            objPaciente.ApePaterno = "Valdivia";
            objPaciente.ApeMaterno = "Cornejo";
            objPaciente.Sexo = "F";
            objPaciente.TipoDocumento = "DNI";
            objPaciente.NumeroDocumento = "43128304";
            objPaciente.Contrasena = "123456Ab";

            //Registrando un nuevo paciente
            PacienteWS.Mensaje mensaje = pacienteWs.modificarPaciente(objPaciente);

            Assert.AreEqual("Satisfactorio", mensaje.TipoMensaje);

        }
    }
}
