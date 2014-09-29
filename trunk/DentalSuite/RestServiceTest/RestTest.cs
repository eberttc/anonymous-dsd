using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.IO;

namespace RestServiceTest
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class RestTest
    {
        

        [TestMethod]
        public void TestCrear()
        {
            {
                string postdata = "{\"codigo\":\"2\"," +
                                   "\"NroDocumento\":\"123456\"," +
                                   "\"Nombres\":\"EBERT\"," +
                                   "\"ApePaterno\":\"TORIBIO\"," +
                                   "\"MatPaterno\":\"CERVANTES\"," +
                                   "\"Sexo\":\"M\"," +
                                   "\"TipoDocumento\":\"DNI\"," +
                                   "\"Correo\":\"e@hotmail.com\"," +
                                   "\"Contrasena\":\"123\"," +
                                   "\"CodigoEspecialidad\":\"1\"," +
                                   "\"COP\":\"1234\"}"; //JSON
                byte[] data = Encoding.UTF8.GetBytes(postdata);
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://localhost:1967/Servicios/Odontologos.svc/Odontologos");
                req.Method = "POST";
                req.ContentLength = data.Length;
                req.ContentType = "application/json";
                var reqStream = req.GetRequestStream();
                reqStream.Write(data, 0, data.Length);
                var res = (HttpWebResponse)req.GetResponse();
                StreamReader reader = new StreamReader(res.GetResponseStream());
                string alumnoJson = reader.ReadToEnd();
            }
        }
    }
}

