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
            string postdata = "{\"Nombre\":\"TEST\",\"Descripcion\":\"TEST\"}";
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
            Assert.AreEqual("TEST", EspecialidadCreado.nombre);
            Assert.AreEqual("TEST", EspecialidadCreado.descripcion);
        }

        [TestMethod]
        public void TESTCrearConRepeticion()
        {

            //CREATE
            string postdata = "{\"Nombre\":\"TEST\",\"Descripcion\":\"TEST\"}";
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
            Assert.AreEqual("la especialidad que esta intentando crear ya existe", EspecialidadCreado.estadoEntidad);
        }

        [TestMethod]
        public void TESTCrearConDescripcionEnBlanco()
        {

            //CREATE
            string postdata = "{\"Nombre\":\"\",\"Descripcion\":\"\"}";
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
            Assert.AreEqual("El nombre o descripcion debe contener valores", EspecialidadCreado.estadoEntidad);
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
            string postdata = "{\"Codigo\":25,\"Nombre\":\"TEST3\",\"Descripcion\":\"TEST2\"}";
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
            Assert.AreEqual("Actualizado OK", EspecialidadCreado.estadoEntidad);
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
