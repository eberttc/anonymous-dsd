using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate;
using SOAPServices.Dominio;
using NHibernate.Transform;

namespace SOAPServices.Persistencia
{
    public class BaseDAO<Entidad, Id>
    {
        public Entidad Crear(Entidad entidad)
        {
            using (ISession sesion = NHibernateHelper.ObtenerSesion())
            {
                    sesion.Save(entidad);
                    sesion.Flush();
            }
              
            return entidad;
        }
        public Entidad Obtener(Id id)
        {
            using (ISession sesion = NHibernateHelper.ObtenerSesion())
            {
                return sesion.Get<Entidad>(id);
            }
        }
        public Entidad Modificar(Entidad entidad)
        {
            using (ISession sesion = NHibernateHelper.ObtenerSesion())
            {
                sesion.Update(entidad);
                sesion.Flush();
            }
            return entidad;
        }
        public void Eliminar(Entidad entidad)
        {
            using (ISession sesion = NHibernateHelper.ObtenerSesion())
            {
                sesion.Delete(entidad);
                sesion.Flush();
            }
        }
        public ICollection<Entidad> ListarTodos()
        {
            using (ISession sesion = NHibernateHelper.ObtenerSesion())
            {
                ICriteria busqueda = sesion.CreateCriteria(typeof(Entidad));
                return busqueda.List<Entidad>();
            }
        }

        // Metodo por probar
        public Especialidad ObtenerEspecialidad()
        {
            using (ISession sesion = NHibernateHelper.ObtenerSesion())
            {
                string hql = "select * from TEspecialidad where Nombre='a'";

                IQuery query = sesion.CreateQuery(hql)
                    .SetResultTransformer(Transformers.AliasToBean<Especialidad>());

               // IList<ProductReport> products = query.List<ProductReport>();
                Especialidad entidad = (Especialidad)query;

                return entidad;
            }
        }        
    }
}