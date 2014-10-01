using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;
using DSDServices.Dominio;

namespace DSDServices.RESTServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEspecialidades" in both code and config file together.
    [ServiceContract]
    public interface IEspecialidades
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "Especialidades", ResponseFormat = WebMessageFormat.Json)]
        Especialidad CrearEspecialidad(Especialidad alumnoACrear);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Especialidades/{nombre}", ResponseFormat = WebMessageFormat.Json)]
        Especialidad ObtenerEspecialidad(string nombre);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "Especialidades", ResponseFormat = WebMessageFormat.Json)]
        Especialidad ModificarEspecialidad(Especialidad alumnoAModificar);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "Especialidades/{codigo}", ResponseFormat = WebMessageFormat.Json)]
        void EliminarEspecialidad(string codigo);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Especialidades", ResponseFormat = WebMessageFormat.Json)]
        List<Especialidad> ListarEspecialidades();

    }
}
