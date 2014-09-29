using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using EspecialidadRestService.Dominio;
using System.ServiceModel.Web;

namespace EspecialidadRestService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEspecialidad" in both code and config file together.
    [ServiceContract]
    public interface IEspecialidad
    {
        [OperationContract]
        [WebInvoke(ResponseFormat = WebMessageFormat.Json, Method = "POST", UriTemplate = "Especialidades")]
        RespuestaService<Dominio.Especialidad> grabarEspecialidad(Dominio.Especialidad especialidad);

        [OperationContract]
        [WebInvoke(ResponseFormat = WebMessageFormat.Json, Method = "PUT", UriTemplate = "Especialidades")]       
        RespuestaService<Dominio.Especialidad> modificarEspecialidad(Dominio.Especialidad especialidad);

        [OperationContract]
        [WebInvoke(ResponseFormat = WebMessageFormat.Json, Method = "GET", UriTemplate = "Especialidades/{Codigo}")]
        Dominio.Especialidad obtenerEspecialidad(String Codigo);
        [OperationContract]
        [WebInvoke(ResponseFormat = WebMessageFormat.Json, Method = "GET", UriTemplate = "Especialidades")]
        List<Dominio.Especialidad> listarEspecialidad();

    }
}
