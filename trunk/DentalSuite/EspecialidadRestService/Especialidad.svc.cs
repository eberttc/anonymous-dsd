using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using EspecialidadRestService.Persistencia;
using EspecialidadRestService.Dominio;

namespace EspecialidadRestService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Especialidad" in code, svc and config file together.
    public class Especialidad : IEspecialidad
    {

        EspecialidadDAO espDao = new EspecialidadDAO();
        RespuestaService<Dominio.Especialidad> mensajeRespuesta = null;

        public Dominio.RespuestaService<Dominio.Especialidad> grabarEspecialidad(Dominio.Especialidad especialidad)
        {


            try
            {
                if (espDao.BuscarNombreRepetido(especialidad.Nombre) != null)
                {

                    //Creamos mensaje de ERROR para enviar
                    mensajeRespuesta = new RespuestaService<Dominio.Especialidad>("Nombre ya esta registrado",
                                          "Advertencia",
                                          "Registro de Especialidad",
                                          "IEspecialidad",
                                          "ValidarNombre",
                                          especialidad);

                    return mensajeRespuesta;
                }

                Dominio.Especialidad entidadCrear = espDao.Crear(especialidad);


                mensajeRespuesta = new RespuestaService<Dominio.Especialidad>("Odontologo creado correctamente. Codigo generado:" + especialidad.Codigo,
                                   "Satisfactorio",
                                   "Registro de Especilidad",
                                   "IEspecialidad",
                                   "grabarEspecialidad",
                                   entidadCrear);

                return mensajeRespuesta;
            }
            catch(Exception ex){
                mensajeRespuesta = new RespuestaService<Dominio.Especialidad>("Error de Sitema :" + ex.ToString(),
                                      "Error",
                                      "Registro de Especialidad",
                                      "IEspecialidad",
                                      "Excepcion",
                                      null);

                return mensajeRespuesta;
            
            }


        }

        public Dominio.RespuestaService<Dominio.Especialidad> modificarEspecialidad(Dominio.Especialidad especialidad)
        {


            try
            {
                Dominio.Especialidad entidadModifcar = espDao.Modificar(especialidad);


                mensajeRespuesta = new RespuestaService<Dominio.Especialidad>("Odontologo modificado correctamente. Codigo generado:" + especialidad.Codigo,
                                   "Satisfactorio",
                                   "Registro de Especilidad",
                                   "IEspecialidad",
                                   "modificarEspecialidad",
                                    entidadModifcar);

                return mensajeRespuesta;

            }
            catch (Exception ex)
            {
                mensajeRespuesta = new RespuestaService<Dominio.Especialidad>("Error de Sitema :" + ex.ToString(),
                                      "Error",
                                      "Modificar  Especialidad",
                                      "IEspecialidad",
                                      "Excepcion",
                                      null);

                return mensajeRespuesta;

            }
        }

        public Dominio.Especialidad obtenerEspecialidad(String Codigo)
        {
            return espDao.Obtener(Convert.ToInt16(Codigo));
        }

        public List<Dominio.Especialidad> listarEspecialidad()
        {
            return  espDao.ListarTodos().ToList();
        }
    }
}
