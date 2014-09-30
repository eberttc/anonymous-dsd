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
            //    data = "[{ value: '1', text: 'Endodentista'},{ value: '2', text: 'Cirujano oral'},{ value: '3', text: 'Ortodoncista'},{ value: '4', text: 'PedoDentista'} ,{ value: '5', text: 'PerioDentista'}]";
            EspecialidadWS.Especialidad objEspecialidad = new EspecialidadWS.Especialidad();
            objEspecialidad.Nombre = "Endodentista";
            objEspecialidad.Descripcion = "Endodentista";


            //Registrando un nuevo paciente
            EspecialidadWS.RespuestaServiceOfEspecialidadHfBKg5Lh especialidadRespuesta = especialidadWs.grabarEspecialidad(objEspecialidad);

            Assert.AreEqual("Satisfactorio-CrearEspecialidad", especialidadRespuesta.TipoMensaje + '-' + especialidadRespuesta.MetodoOrigen);
        }
    }
}
