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
            objCita.FechaReserva = fecha;
            objCita.CodigoEspecialidad = 1;
            objCita.CodigoPaciente = "p46079567";
            objCita.CodigoHorarioOdontologo = 1;


            //Registrando un nuevo paciente
            CitaWS.RespuestaServiceOfCitaz_SY3AMPv citaRespuesta = citaWs.registrarCita(objCita);

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
            objCita.CodigoPaciente = "p46079567";
            objCita.CodigoHorarioOdontologo = 1;

            //Registrando un nuevo paciente
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
            objCita.CodigoHorarioOdontologo = 1;

            //Registrando un nuevo paciente
            CitaWS.RespuestaServiceOfCitaz_SY3AMPv citaRespuesta = citaWs.registrarCita(objCita);

            Assert.AreEqual("Advertencia-validarDiasAnticipacionCita", citaRespuesta.TipoMensaje + '-' + citaRespuesta.MetodoOrigen);
        }
        
    }
}
