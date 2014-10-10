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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Especialidades" in code, svc and config file together.
    public class Especialidades : IEspecialidades
    {
        private EspecialidadDAO dao = new EspecialidadDAO();
        public Especialidad CrearEspecialidad(Especialidad EspecialidadACrear)
        {
            Especialidad entidad=new Especialidad();
            if (dao.ObtenerPorNombre(EspecialidadACrear.Nombre.Trim()) !=null)
            {
                entidad.estadoEntidad = "la especialidad que esta intentando crear ya existe";
                return entidad;
            }
            else if(string.IsNullOrEmpty(EspecialidadACrear.Descripcion) || string.IsNullOrEmpty(EspecialidadACrear.Nombre))
            {
                entidad.estadoEntidad = "El nombre o descripcion debe contener valores";
                return entidad;
            }

            else {
                return dao.Crear(EspecialidadACrear);
            }
            
        }

        public Especialidad ObtenerEspecialidad(string nombre)
        {
            return dao.ObtenerPorNombre(nombre);
        }

        public Especialidad ModificarEspecialidad(Especialidad EspecialidadAModificar)
        {
            return dao.Modificar(EspecialidadAModificar);
        }

        public void EliminarEspecialidad(string codigo)
        {
            dao.Eliminar(codigo);
        }

        public List<Especialidad> ListarEspecialidades()
        {
            return dao.ListarTodos();
        }

    }
}
