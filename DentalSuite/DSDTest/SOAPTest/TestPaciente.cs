using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DSDTest.SOAPTest
{
    [TestClass]
    public class TestPaciente
    {
       
        public void TestGrabarPaciente()
        {
            PacienteWS.PacientesClient pacienteWs = new PacienteWS.PacientesClient();

            PacienteWS.Paciente objPaciente = new PacienteWS.Paciente();
            objPaciente.Nombres = "Juan José";
            objPaciente.ApePaterno = "Ledesma";
            objPaciente.ApeMaterno = "Zevallos";
            objPaciente.Sexo = "M";
            objPaciente.TipoDocumento = "DNI";
            objPaciente.NumeroDocumento = "46079567";
            objPaciente.Correo = "jledesma2509@gmail.com";
            objPaciente.Codigo = "";
            objPaciente.Contrasena = "123456Aabb11";

            //Registrando un nuevo paciente
            PacienteWS.RespuestaServiceOfPacientez_SY3AMPv pacienteRespuesta = pacienteWs.registrarPaciente(objPaciente);

            Assert.AreEqual("Satisfactorio", pacienteRespuesta.TipoMensaje);
        }

       
        public void TestGrabarModificar()
        {
            PacienteWS.PacientesClient pacienteWs = new PacienteWS.PacientesClient();

            PacienteWS.Paciente objPaciente = new PacienteWS.Paciente();
            objPaciente.Nombres = "Juan José";
            objPaciente.ApePaterno = "Ledesma";
            objPaciente.ApeMaterno = "Zevallos";
            objPaciente.Sexo = "M";
            objPaciente.TipoDocumento = "DNI";
            objPaciente.NumeroDocumento = "46079567";
            objPaciente.Correo = "jledesma2509@gmail.com";
            objPaciente.Codigo = "p46079567";
            //  objPaciente.Contrasena = "123456Aabb1";
            objPaciente.Contrasena = "123456Aabb2";

            //Registrando un nuevo paciente
            PacienteWS.RespuestaServiceOfPacientez_SY3AMPv pacienteRespuesta = pacienteWs.modificarPaciente(objPaciente);

            Assert.AreEqual("Satisfactorio", pacienteRespuesta.TipoMensaje);

        }

     
        public void TestClaveIncorrecta()
        {
            PacienteWS.PacientesClient pacienteWs = new PacienteWS.PacientesClient();

            PacienteWS.Paciente objPaciente = new PacienteWS.Paciente();
            objPaciente.Nombres = "Usuario";
            objPaciente.ApePaterno = "Prueba";
            objPaciente.ApeMaterno = "Prueba";
            objPaciente.Sexo = "M";
            objPaciente.TipoDocumento = "DNI";
            objPaciente.NumeroDocumento = "12345678";
            objPaciente.Correo = "uprueba@gmail.com";
            objPaciente.Codigo = "";
            objPaciente.Contrasena = "123456";

            //Registrando un nuevo paciente
            PacienteWS.RespuestaServiceOfPacientez_SY3AMPv pacienteRespuesta = pacienteWs.registrarPaciente(objPaciente);

            Assert.AreEqual("Advertencia-ValidarClave", pacienteRespuesta.TipoMensaje + '-' + pacienteRespuesta.MetodoOrigen);
        }

        [TestMethod]
        public void TestPacienteExistente()
        {
            PacienteWS.PacientesClient pacienteWs = new PacienteWS.PacientesClient();

            PacienteWS.Paciente objPaciente = new PacienteWS.Paciente();
            objPaciente.Nombres = "Juan José";
            objPaciente.ApePaterno = "Ledesma";
            objPaciente.ApeMaterno = "Zevallos";
            objPaciente.Sexo = "M";
            objPaciente.TipoDocumento = "DNI";
            objPaciente.NumeroDocumento = "46079567";
            objPaciente.Correo = "jledesma2509@gmail.com";
            objPaciente.Codigo = "";
            objPaciente.Contrasena = "123456Aabb11";

            //Registrando un nuevo paciente
            PacienteWS.RespuestaServiceOfPacientez_SY3AMPv pacienteRespuesta = pacienteWs.registrarPaciente(objPaciente);

            Assert.AreEqual("Advertencia-ValidarPacienteCreado", pacienteRespuesta.TipoMensaje + '-' + pacienteRespuesta.MetodoOrigen);
        }
    }
}
