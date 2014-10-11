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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IOdontologoHorario" in both code and config file together.
    [ServiceContract]
    public interface IOdontologoHorario
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Odontologos", ResponseFormat = WebMessageFormat.Json)]
        List<Odontologo> ListarOdontologos();




    }
}
