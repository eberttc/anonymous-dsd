using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using RestService.Dominio;
using System.ServiceModel.Web;

namespace RestService.Servicios
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IOdontologos" in both code and config file together.
    [ServiceContract]
    public interface IOdontologos
    {
        [OperationContract]
        [WebInvoke(ResponseFormat = WebMessageFormat.Json, Method = "POST", UriTemplate = "Odontologos")]
        RespuestaService<Odontologo> Crear(Odontologo OdontologoACrear);
        [OperationContract]
        [WebInvoke(ResponseFormat = WebMessageFormat.Json, Method = "PUT", UriTemplate = "Odontologos")]
        RespuestaService<Odontologo> Modificar(Odontologo OdontologoAModificar);
        [OperationContract]
        [WebInvoke(ResponseFormat = WebMessageFormat.Json, Method = "GET", UriTemplate = "Odontologos/{Codigo}")]
        RespuestaService<Odontologo> Obtener(string Codigo);
        [OperationContract]
        [WebInvoke(ResponseFormat = WebMessageFormat.Json, Method = "GET", UriTemplate = "Odontologos")]
        ICollection<Odontologo> ListarTodos();
    }
}
