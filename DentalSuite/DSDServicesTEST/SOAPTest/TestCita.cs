using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DSDServicesTEST.SOAPTest
{
    [TestClass]
    public class TestCita
    {
        [TestMethod]
        public void TestRegistrarCita()
        {
            CitaWS.CitasClient citaWs = new CitaWS.CitasClient();


            DateTime fecha = DateTime.Now;

            CitaWS.Cita objCita = new CitaWS.Cita();
            objCita.FechaReserva = Convert.ToDateTime("2014-10-11");
            //objCita.FechaReserva = fecha;
            objCita.CodigoEspecialidad = 9;
            objCita.CodigoPaciente = "p43454555";
            objCita.CodigoHorario = 3;
            objCita.CodigoOdontologo = "O43411113";

            CitaWS.RespuestaServiceOfCitaz_SY3AMPv citaRespuesta = citaWs.registrarCita(objCita);

            Assert.AreEqual("Satisfactorio", citaRespuesta.TipoMensaje);
        }

        [TestMethod]
        public void TestModificarCita()
        {
            CitaWS.CitasClient citaWs = new CitaWS.CitasClient();


            DateTime fecha = DateTime.Now;

            CitaWS.Cita objCita = new CitaWS.Cita();
            objCita.Codigo = 1;
            objCita.FechaReserva = fecha;
            objCita.CodigoEspecialidad = 8;
            objCita.CodigoPaciente = "p46079567";
            objCita.CodigoHorario = 5;
            objCita.CodigoOdontologo = "O43411111";

            CitaWS.RespuestaServiceOfCitaz_SY3AMPv citaRespuesta = citaWs.modificarCita(objCita);

            Assert.AreEqual("Satisfactorio", citaRespuesta.TipoMensaje);
        }

        [TestMethod]
        public void TestValidarRangoHorasCita()
        {
            CitaWS.CitasClient citaWs = new CitaWS.CitasClient();

            DateTime fecha = DateTime.Now;

            CitaWS.Cita objCita = new CitaWS.Cita();
            objCita.FechaReserva = fecha;
            objCita.CodigoEspecialidad = 1;
            objCita.CodigoPaciente = "p11111111";
            objCita.CodigoHorario = 19;
            objCita.CodigoOdontologo = "O43411111";

            CitaWS.RespuestaServiceOfCitaz_SY3AMPv citaRespuesta = citaWs.registrarCita(objCita);

            Assert.AreEqual("Advertencia-validarRangoHorasCita", citaRespuesta.TipoMensaje + '-' + citaRespuesta.MetodoOrigen);
        }

        [TestMethod]
        public void TestValidarDiasAnticipacionCita()
        {
            CitaWS.CitasClient citaWs = new CitaWS.CitasClient();

            DateTime fecha = DateTime.Now.AddDays(15);

            CitaWS.Cita objCita = new CitaWS.Cita();
            objCita.FechaReserva = fecha;
            objCita.CodigoEspecialidad = 1;
            objCita.CodigoPaciente = "p46079567";
            objCita.CodigoHorario = 1;
            objCita.CodigoOdontologo = "O43411111";

            CitaWS.RespuestaServiceOfCitaz_SY3AMPv citaRespuesta = citaWs.registrarCita(objCita);

            Assert.AreEqual("Advertencia-validarDiasAnticipacionCita", citaRespuesta.TipoMensaje + '-' + citaRespuesta.MetodoOrigen);
        }
        [TestMethod]
        public void TestEnviarPromociones() {
            CitaWS.CitasClient cita = new CitaWS.CitasClient();
            string respuesta=cita.enviarPromociones();
            Assert.AreEqual("Se envio las promociones OK", respuesta);
        }
    }
}
