using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SOAPServices.Persistencia;
using SOAPServices.Dominio;
using SOAPServices.Reutilizables;

namespace SOAPServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Especialidades" en el código, en svc y en el archivo de configuración a la vez.
    public class Especialidades : IEspecialidades
    {
        private EspecialidadDAO especialidadDAO = null;
        private EspecialidadDAO EspecialidadDAO
        {
            get
            {
                if (especialidadDAO == null)
                    especialidadDAO = new EspecialidadDAO();
                return especialidadDAO;
            }
        }

        private Utilitario util = null;
        RespuestaService<Especialidad> mensajeEspecialidad = null;
       

        public List<Especialidad> listarEspecialidad()
        {
            return EspecialidadDAO.ListarTodos().ToList();
        }

        public RespuestaService<Especialidad> grabarEspecialidad(Especialidad especialidad)
        {
            util = new Utilitario();
            try
            {

                Especialidad especialidadACrear = new Especialidad()
                {
                    Nombre = especialidad.Nombre,
                    Descripcion = especialidad.Descripcion
                };

                //2) Validar paciente no exista por nombre

                //   Especialidad e = EspecialidadDAO.ObtenerEspecialidad();
                    if (EspecialidadDAO.Obtener(especialidad.Nombre.Trim()) != null)
                    {
                        mensajeEspecialidad = new RespuestaService<Especialidad>("La especialidad que esta intentando crear ya existe",
                                             "Advertencia",
                                             "Registro de Especialidad",
                                             "IEspecialidad",
                                             "ValidarEspecialidadCreado",
                                             especialidadACrear);

                        return mensajeEspecialidad;
                    }
                Especialidad especialidadCreado =  EspecialidadDAO.Crear(especialidadACrear);

                mensajeEspecialidad = new RespuestaService<Especialidad>("Especialidad creado correctamente", "Satisfactorio", "Registro de Especialidad",
                                                                "IEspecialidades", "CrearEspecialidad", especialidadCreado);

                 return mensajeEspecialidad;
            }
            catch (Exception ex)
            {
                mensajeEspecialidad = new RespuestaService<Especialidad>("Error de Sitema :" + ex.ToString(), "Error",
                                                                "Registro de Especialidad","IEspecialidades",
                                                                "Excepcion",null);

                return mensajeEspecialidad;
            }
        }

        public RespuestaService<Especialidad> modificarEspecialidad(Especialidad especialidad)
        {
            util = new Utilitario();
            try
            {

                Especialidad especialidadAModificar = new Especialidad()
                {
                    Nombre = especialidad.Nombre,
                    Descripcion = especialidad.Descripcion
                };

                Especialidad especialidadModificado = EspecialidadDAO.Modificar(especialidadAModificar);

                mensajeEspecialidad = new RespuestaService<Especialidad>("Especialidad modificado correctamente", "Satisfactorio", "Modificar Especialidad",
                                                                "IEspecialidades", "ModificarEspecialidad", especialidadModificado);

                return mensajeEspecialidad;
            }
            catch (Exception ex)
            {
                mensajeEspecialidad = new RespuestaService<Especialidad>("Error de Sitema :" + ex.ToString(), "Error",
                                                                "Modificar Especialidad", "IEspecialidades",
                                                                "Excepcion", null);

                return mensajeEspecialidad;
            }
        }
    }
}
