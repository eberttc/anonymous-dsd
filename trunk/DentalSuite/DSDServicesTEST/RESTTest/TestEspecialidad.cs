using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;
using DSDServicesTEST.Dominio;
namespace DSDServicesTEST.RESTTest
{
    [TestClass]
    public class TestEspecialidad
    {
        [TestMethod]
        public void TESTCrear()
        {

            //CREATE
            string postdata = "{\"Nombre\":\"Cirujano Ortodoncista5\",\"Descripcion\":\"Cirujano Ortodoncista5\"}";
            byte[] data = Encoding.UTF8.GetBytes(postdata);
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://localhost:20001/RESTServices/Especialidades.svc/especialidades");
            req.Method = "POST";
            req.ContentLength = data.Length;
            req.ContentType = "application/json";
            var reqStream = req.GetRequestStream();
            reqStream.Write(data, 0, data.Length);
            var res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());
            string EspecialidadJson = reader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            Especialidad EspecialidadCreado = js.Deserialize<Especialidad>(EspecialidadJson);
            Assert.AreEqual("Cirujano Ortodoncista", EspecialidadCreado.nombre);
            Assert.AreEqual("Cirujano Ortodoncista", EspecialidadCreado.descripcion);
        }

        [TestMethod]
        public void TESTCrearConRepeticion()
        {

            //CREATE
            string postdata = "{\"Nombre\":\"PedoDentista\",\"Descripcion\":\"PedoDentista\"}";
            byte[] data = Encoding.UTF8.GetBytes(postdata);
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://localhost:20001/RESTServices/Especialidades.svc/especialidades");
            req.Method = "POST";
            req.ContentLength = data.Length;
            req.ContentType = "application/json";
            var reqStream = req.GetRequestStream();
            reqStream.Write(data, 0, data.Length);
            var res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());
            string EspecialidadJson = reader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            Especialidad EspecialidadCreado = js.Deserialize<Especialidad>(EspecialidadJson);
            Assert.AreEqual("Especialidad ya existe", EspecialidadCreado.nombre);
        }

        [TestMethod]
        public void TESTCrearConDescripcionEnBlanco()
        {

            //CREATE
            string postdata = "{\"Nombre\":\"PRUEBA\",\"Descripcion\":\"\"}";
            byte[] data = Encoding.UTF8.GetBytes(postdata);
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://localhost:20001/RESTServices/Especialidades.svc/especialidades");
            req.Method = "POST";
            req.ContentLength = data.Length;
            req.ContentType = "application/json";
            var reqStream = req.GetRequestStream();
            reqStream.Write(data, 0, data.Length);
            var res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());
            string EspecialidadJson = reader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            Especialidad EspecialidadCreado = js.Deserialize<Especialidad>(EspecialidadJson);
            Assert.AreEqual("Descripcion en blanco", EspecialidadCreado.nombre);
        }

        [TestMethod]
        public void TESTObtener()
        {

            //modify
            HttpWebRequest req = (HttpWebRequest)WebRequest
                .Create("http://localhost:20001/RESTServices/Especialidades.svc/especialidades/Ortodoncista");
            req.Method = "GET";
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());
            string EspecialidadJson = reader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            Especialidad EspecialidadObtenido = js.Deserialize<Especialidad>(EspecialidadJson);
            Assert.AreEqual(2, EspecialidadObtenido.codigo);
            Assert.AreEqual("Ortodoncista", EspecialidadObtenido.nombre);
            Assert.AreEqual("Ortodoncista", EspecialidadObtenido.descripcion);
        }

        [TestMethod]
        public void TESTModificar()
        {
            //MODIFICAR
            string postdata = "{\"Codigo\":5,\"Nombre\":\"Cirujano Ortodoncista\",\"Descripcion\":\"Cirujano Ortodoncista\"}";
            byte[] data = Encoding.UTF8.GetBytes(postdata);
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://localhost:20001/RESTServices/Especialidades.svc/especialidades");
            req.Method = "PUT";
            req.ContentLength = data.Length;
            req.ContentType = "application/json";
            var reqStream = req.GetRequestStream();
            reqStream.Write(data, 0, data.Length);
            var res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());
            string EspecialidadJson = reader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            Especialidad EspecialidadCreado = js.Deserialize<Especialidad>(EspecialidadJson);
            Assert.AreEqual(5, EspecialidadCreado.codigo);
            Assert.AreEqual("Cirujano Ortodoncista", EspecialidadCreado.nombre);
            Assert.AreEqual("Cirujano Ortodoncista", EspecialidadCreado.descripcion);
        }

        [TestMethod]
        public void TESTListar()
        {

            //listar
            HttpWebRequest req = (HttpWebRequest)WebRequest
                .Create("http://localhost:20001/RESTServices/Especialidades.svc/especialidades");
            req.Method = "GET";
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());
            string EspecialidadJson = reader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            List<Especialidad> ListaEspecialidadsObtenidos = js.Deserialize<List<Especialidad>>(EspecialidadJson);
            Assert.AreEqual(15, ListaEspecialidadsObtenidos.Count);
        }

        [TestMethod]
        public void TESTEliminar()
        {
            string codigoAEliminar = "4";
            //ELIMINAR
            HttpWebRequest req = (HttpWebRequest)WebRequest
                            .Create(string.Format("http://localhost:20001/RESTServices/Especialidades.svc/especialidades/{0}", codigoAEliminar));
            req.Method = "DELETE";
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());

            //Consultando si elimino
            HttpWebRequest req2 = (HttpWebRequest)WebRequest
                .Create(string.Format("http://localhost:20001/RESTServices/Especialidades.svc/especialidades/{0}", codigoAEliminar));
            req2.Method = "GET";
            HttpWebResponse res2 = (HttpWebResponse)req2.GetResponse();
            StreamReader reader2 = new StreamReader(res2.GetResponseStream());
            string EspecialidadJson = reader2.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            Especialidad EspecialidadObtenido = new Especialidad();
            if (!string.IsNullOrEmpty(EspecialidadJson)) EspecialidadObtenido = js.Deserialize<Especialidad>(EspecialidadJson);
            Assert.AreEqual(0,EspecialidadObtenido.codigo);
            Assert.IsNull(EspecialidadObtenido.nombre);
            Assert.IsNull(EspecialidadObtenido.descripcion);

        }







    }
}
