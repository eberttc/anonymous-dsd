using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DSDServices.Dominio;
using DSDServices.Persistencia; 


namespace DSDServices.RESTServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "OdontologoHorario" in code, svc and config file together.
    public class OdontologoHorario : IOdontologoHorario
    {
        private OdontologoDAO dao = new OdontologoDAO();
        public List<Dominio.Odontologo> ListarOdontologos()
        {
            return dao.ListarTodos();
        }
    }
}
