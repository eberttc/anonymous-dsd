using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.IO;
using EspecialidadRestServiceTest.Dominio;
using System.Web.Script.Serialization;


namespace EspecialidadRestServiceTest
{
   
    [TestClass]
    public class EspecialidadTest
    {
       
        [TestMethod]
        public void grabar()
        {
            string postdata = "{\"Codigo\":\"\"," +
                                 "\"Nombre\":\"Pediatra\"," +                                    
                                 "\"Descripcion\":\"primera descripcion\"}"; //JSON
            byte[] data = Encoding.UTF8.GetBytes(postdata);
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://localhost:20005/Especialidad.svc/Especialidades");
            req.Method = "POST";
            req.ContentLength = data.Length;
            req.ContentType = "application/json";
            var reqStream = req.GetRequestStream();
            reqStream.Write(data, 0, data.Length);
            var res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());
            string respuesta = reader.ReadToEnd();

            JavaScriptSerializer js = new JavaScriptSerializer();
            RespuestaService<Especialidad> respuestaRecibida = js.Deserialize<RespuestaService<Especialidad>>(respuesta);

            Assert.AreEqual("Satisfactorio", respuestaRecibida.TipoMensaje);

     
        }

        [TestMethod]
        public void validaNombreDuplicado()
        {
            string postdata = "{\"Codigo\":\"\"," +
                                 "\"Nombre\":\"Pediatra\"," +
                                 "\"Descripcion\":\"segunda descripcion\"}"; //JSON
            byte[] data = Encoding.UTF8.GetBytes(postdata);
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://localhost:1967/Servicios/Especialidad.svc/Especialidades");
            req.Method = "POST";
            req.ContentLength = data.Length;
            req.ContentType = "application/json";
            var reqStream = req.GetRequestStream();
            reqStream.Write(data, 0, data.Length);
            var res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());
           
            string respuesta = reader.ReadToEnd();

            JavaScriptSerializer js = new JavaScriptSerializer();
            RespuestaService<Especialidad> respuestaRecibida = js.Deserialize<RespuestaService<Especialidad>>(respuesta);

            Assert.AreEqual("Advertencia", respuestaRecibida.TipoMensaje);

           
        }

        [TestMethod]
        public void ObtenerTest()
        {
            // Prueba de OBTENER un alumno vía HTTP GET

            string strURL = "http://localhost:1967/Servicios/Especialidad.svc/Especialidades";
            string strID = "1";
            HttpWebRequest reqObtener = (HttpWebRequest)WebRequest.Create(strURL + "/" + strID);
            reqObtener.Method = "GET";
            HttpWebResponse resObtener = (HttpWebResponse)reqObtener.GetResponse();
            StreamReader readerObtener = new StreamReader(resObtener.GetResponseStream());


            string EspecialidadJsonObtener = readerObtener.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            Especialidad EspecialidaObtenida = js.Deserialize<Especialidad>(EspecialidadJsonObtener);

            Assert.AreEqual("1", EspecialidaObtenida.Codigo);
            Assert.AreEqual("Cirujano", EspecialidaObtenida.Nombre);

        }


        [TestMethod]
        public void EspecialidadModificarTest()
        {
            // Prueba de creación de alumno vía HTTP POST
            string postdata = "{\"Codigo\":\"1\"," +
                                "\"Nombre\":\"Pediatra\"," +
                                "\"Descripcion\":\"segunda descripcion\"}"; //JSON
            byte[] data = Encoding.UTF8.GetBytes(postdata);

            HttpWebRequest req = (HttpWebRequest)WebRequest
                .Create("http://localhost:1967/Servicios/Especialidad.svc/Especialidades");

            req.Method = "PUT";
            req.ContentLength = data.Length;
            req.ContentType = "application/json; charset=utf-8";

            var reqStream = req.GetRequestStream();
            reqStream.Write(data, 0, data.Length);
            var res = (HttpWebResponse)req.GetResponse();


            StreamReader reader = new StreamReader(res.GetResponseStream());
            string respuesta = reader.ReadToEnd();
           
            JavaScriptSerializer js = new JavaScriptSerializer();
            RespuestaService<Especialidad> respuestaRecibida = js.Deserialize<RespuestaService<Especialidad>>(respuesta);

            Assert.AreEqual("Satisfactorio", respuestaRecibida.TipoMensaje);

     
        }
    }
}
