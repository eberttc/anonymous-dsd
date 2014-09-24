using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SOAPServicesTest.Test
{
    [TestClass]
    public class TestEspecialidad
    {
        [TestMethod]
        public void TestGrabarEspecialiad()
        {
            EspecialidadWS.EspecialidadesClient especialidadWs = new EspecialidadWS.EspecialidadesClient();

            EspecialidadWS.Especialidad objEspecialidad = new EspecialidadWS.Especialidad();
            objEspecialidad.Nombre = "Prueba Nombre";
            objEspecialidad.Descripcion = "Prueba Descripcion";


            //Registrando un nuevo paciente
            EspecialidadWS.RespuestaServiceOfEspecialidadHfBKg5Lh especialidadRespuesta = especialidadWs.grabarEspecialidad(objEspecialidad);

            Assert.AreEqual("Satisfactorio-CrearEspecialidad", especialidadRespuesta.TipoMensaje + '-' + especialidadRespuesta.MetodoOrigen);
        }
    }
}
