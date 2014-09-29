using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using RestService.Persistencia;
using RestService.Dominio;
using RestService.Reutilizables;

namespace RestService.Servicios
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Odontologos" in code, svc and config file together.
    public class Odontologos : IOdontologos
    {

        OdontologoDAO dao = new OdontologoDAO();
        HorarioOdontologoDAO daoHorario = new HorarioOdontologoDAO();
        
        RespuestaService<Odontologo> mensajeRespuesta = null;

        public RespuestaService<Odontologo> Crear(Dominio.Odontologo OdontologoACrear)
        {

            Odontologo odonto = null;
           // HorarioOdontologo Hodonto = null;
            List<HorarioOdontologo> lstHoario=new List<HorarioOdontologo>();
            try {


                //valida si el correo ya esta regitrado
                if (dao.BuscarCorreoRepetido(OdontologoACrear.Correo) != null) {

                    //Creamos mensaje de ERROR para enviar
                    mensajeRespuesta = new RespuestaService<Odontologo>("Correo ya esta registrado",
                                          "Advertencia",
                                          "Registro de Odontologo",
                                          "IOdontologo",
                                          "ValidarCorreo",
                                          OdontologoACrear);

                    return mensajeRespuesta;
                }

                //valida si el correo ya esta regitrado
                if (dao.BuscarCOPRepetido(OdontologoACrear.COP) != null)
                {

                    //Creamos mensaje de ERROR para enviar
                    mensajeRespuesta = new RespuestaService<Odontologo>("Coop ya esta registrado",
                                          "Advertencia",
                                          "Registro de Odontologo",
                                          "IOdontologo",
                                          "ValidarCop",
                                           OdontologoACrear);

                    return mensajeRespuesta;
                }


                odonto=dao.Crear(OdontologoACrear) ;

                if (odonto != null)
                {

                   /* foreach (HorarioOdontologo o in OdontologoACrear.HorarioOdontlogo)
                    {

                        Hodonto=daoHorario.Crear(o);
                        lstHoario.Add(Hodonto);
                    }*/


                }
                odonto.HorarioOdontlogo = lstHoario;

                mensajeRespuesta = new RespuestaService<Odontologo>("Odontologo creado correctamente. Codigo generado:" + odonto.Codigo,
                                   "Satisfactorio",
                                   "Registro de Odontologo",
                                   "IOdontologo",
                                   "CrearOdontologo",
                                   odonto);

                return mensajeRespuesta;
             
            }

             catch (Exception ex) {

                 mensajeRespuesta = new RespuestaService<Odontologo>("Error de Sitema :" + ex.ToString(),
                                    "Error",
                                    "Registro de Odontologo",
                                    "IOdontologo",
                                    "Excepcion",
                                    null);

                 return mensajeRespuesta;
            }
        
        }

        public RespuestaService<Odontologo> Modificar(Dominio.Odontologo OdontologoAModificar)
        {
            try {

                // Modificacmo Odontologo
                Odontologo odontoModificado = dao.Modificar(OdontologoAModificar);

                //Retornar Clase Mensaje con los datos a mostrar - Flujo Correcto
                mensajeRespuesta = new RespuestaService<Odontologo>("Odontologo modificado correctamente",
                                    "Satisfactorio",
                                    "Modificar Odontologo",
                                    "IDontologo",
                                    "ModificarOdontologo",
                                    odontoModificado);

                return mensajeRespuesta;
            }catch(Exception ex){
                mensajeRespuesta = new RespuestaService<Odontologo>("Error de Sitema :" + ex.ToString(),
                                       "Error",
                                       "Modificar Odontologo",
                                       "IDontologo",
                                       "Exeption",
                                       null);

                return mensajeRespuesta;
            }



        }

        public RespuestaService<Odontologo> Obtener(string Codigo)
        {
            return null;
            //no coge nada que raro sips ahver bajatelo a tu pc  y pruebalo alli pera, nombre del repositoria
            //el link no tengo acceso
        }

        public ICollection<Dominio.Odontologo> ListarTodos()
        {
            return dao.ListarTodos();
        }
    }
}
