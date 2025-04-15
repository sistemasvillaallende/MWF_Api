// Decompiled with JetBrains decompiler
// Type: MOTOR_WORKFLOW.Controllers.PasoController
// Assembly: MOTOR_WORKFLOW, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 007B8F5F-49BB-4EE7-8464-22FD2F567A18
// Assembly location: C:\Muni\DEV\WebApiMWF\MOTOR_WORKFLOW.dll

using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CSharp.RuntimeBinder;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Primitives;
using MOTOR_WORKFLOW.Entities;
using MOTOR_WORKFLOW.Entities.CIDI.Comunicacion;
using MOTOR_WORKFLOW.Models;
using MOTOR_WORKFLOW.Services;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using MOTOR_WORKFLOW.Services.CIDI;
using RestSharp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.Encodings.Web;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Diagnostics;

#nullable enable
namespace MOTOR_WORKFLOW.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class PasoController : ControllerBase
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IWebHostEnvironment _HostEnvironment;
        private IPasoService _PasoService;
        private readonly IComunicacionesService _ComunicacionesService;


        public PasoController(
          IPasoService PasoService,
          IWebHostEnvironment webHostEnvironment,
          IWebHostEnvironment hostEnvironment,
          IComunicacionesService comunicacionesService)
        {
            this._PasoService = PasoService;
            this._HostEnvironment = hostEnvironment;
            this._webHostEnvironment = webHostEnvironment;
            this._ComunicacionesService = comunicacionesService;
        }
        [HttpGet]
        public IActionResult GetProximoVecino(int idTramite, int idTramites)
        {
            try
            {
                int proximoPaso = this._PasoService.getProximoVecino(idTramite, idTramites);
                return proximoPaso == 0 ? (IActionResult)this.BadRequest(new
                {
                    message = "Error al obtener los datos"
                }) : (IActionResult)this.Ok(proximoPaso);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        [HttpPost]
        [RequestSizeLimit(104857600)] // 100 MB
        public string SavePaso2()
        {
            try
            {
                var form = Request.Form["data"];
                string contenidoMultinota = string.Empty;
                IFormFileCollection files = Request.Form.Files;

                dynamic formData =
                    JsonConvert.DeserializeObject<dynamic>(form);

                int idPaso = int.Parse(formData.idPaso.ToString());
                int idTramite = int.Parse(formData.idTramite.ToString());
                List<int> lstIdAdjuntos = new List<int>();
                if (formData != null)
                {

                    int idTramites = Tramites.insert(new Tramites()
                    {
                        id_tramite = idTramite,
                        cuit = formData.cuit.ToString(),
                        cuit_representado = formData.cuitRepresentado.ToString(),
                        fecha = DateTime.Now,
                        paso_actual = int.Parse(formData.idPaso.ToString()),
                        id_oficina = int.Parse(formData.idOficina.ToString())
                    });
                    int _idAdjunto = -1;
                    int control_paso = 0;
                    int idPasos = 0;
                    foreach (dynamic paso in formData.pasos)
                    {
                        Pasos pasos = new Pasos();
                        if (Convert.ToInt32(paso.id_formulario.ToString()) != 0)
                        {
                            Formulario objForm = Formulario.getByPk(Convert.ToInt32(paso.id_formulario.ToString()));
                            contenido_ingreso_paso objCont = contenido_ingreso_paso.getByPk(
                                Convert.ToInt32(objForm.id_contenido_ingreso_paso));

                            pasos.row = objCont.row;
                            pasos.col = objCont.col;
                        }
                        else
                        {
                            pasos.row = Convert.ToInt32(paso.row.ToString());
                            pasos.col = Convert.ToInt32(paso.col.ToString());
                        }
                        if (Convert.ToInt32(paso.id_adjunto.ToString()) != 0)
                        {
                            ingreso_paso_modelF objIngPmodel = ingresos_x_paso.getByAdjunto(
                                Convert.ToInt32(paso.id_adjunto));
                            pasos.id_ingreso_paso = objIngPmodel.id_ingreso_paso;
                            pasos.nombre_ingreso_paso = objIngPmodel.nombre_ingreso_paso;
                            pasos.orden_ingreso_paso = objIngPmodel.orden;
                        }
                        else
                        {
                            pasos.id_ingreso_paso = Convert.ToInt32(paso.id_ingreso_paso.ToString());
                            pasos.nombre_ingreso_paso = paso.nombre;
                            pasos.orden_ingreso_paso = paso.orden_paso;
                        }
                        pasos.id_tramites = idTramites;
                        pasos.id_paso = idPaso;
                        pasos.orden_paso = 1;
                        pasos.id_formulario = Convert.ToInt32(paso.id_formulario.ToString());
                        pasos.id_adjunto = Convert.ToInt32(paso.id_adjunto.ToString());
                        pasos.id_ddjj = Convert.ToInt32(paso.id_ddjj.ToString());

                        if (control_paso != Convert.ToInt32(paso.id_ingreso_paso.ToString()))
                        {
                            idPasos = Pasos.insert(pasos);
                            control_paso = paso.id_ingreso_paso;
                        }

                        dynamic objDDJJs = paso.objDDJJs;
                        if (Convert.ToInt32(paso.id_ddjj.ToString()) != 0)
                            Ddjjs.insert(new Ddjjs()
                            {
                                id = 0,
                                ddjj = objDDJJs.respuesta_usuario,
                                id_pasos = idPasos
                            });
                        if (paso.id_formulario != 0)
                        {
                            Formulario byPk = Formulario.getByPk(Convert.ToInt32(paso.id_formulario.ToString()));
                            int num = Formularios.insert(new Formularios()
                            {
                                id_formulario = Convert.ToInt32(paso.id_formulario.ToString()),
                                nombre = byPk.nombre,
                                descripcion = byPk.descripcion,
                                id_pasos = idPasos
                            });
                            foreach (dynamic objFormulario in paso.objFormulario)
                            {
                                Respuesta_formulario.insert(new Respuesta_formulario()
                                {
                                    id_formularios = num,
                                    nombre_campo = objFormulario.nombre_campo,
                                    id_tipo_campo = Convert.ToInt32(objFormulario.id_tipo_campo.ToString()),
                                    etiqueta_campo = objFormulario.etiqueta_campo,
                                    respuesta_usuario = objFormulario.respuesta_usuario,
                                    orden = 0//paso.orden_paso_IP.Value
                                });
                                contenidoMultinota = objFormulario.respuesta_usuario;
                            }
                        }
                        if (Convert.ToInt32(paso.id_adjunto.ToString()) != 0)
                        {
                            if (files != null && files.Count > 0)
                            {
                                Adjunto AdjByPk = Adjunto.getByPk(Convert.ToInt32(paso.id_adjunto.ToString()));
                                foreach (dynamic objAdjunto in paso.objAdjuntos)
                                {

                                    string carpetaImagenes = Path.Combine(
                                    _webHostEnvironment.ContentRootPath, "adjunto");
                                    if (!Directory.Exists(carpetaImagenes))
                                        Directory.CreateDirectory(carpetaImagenes);

                                    IFormFile formFile =
                                        files.First(f => f.Name == objAdjunto.respuesta_usuario.ToString());

                                    if (formFile.Length > 0L)
                                    {
                                        string nombreImagen =
                                          "Tramites_" + idTramites.ToString() + "_" + objAdjunto.respuesta_usuario + Path.GetExtension(formFile.FileName);
                                        using (FileStream stream = new FileStream(Path.Combine(carpetaImagenes, nombreImagen), FileMode.Create))
                                            formFile.CopyTo(stream);

                                        Adjuntos.insert(new Adjuntos()
                                        {
                                            nombre = objAdjunto.etiqueta_campo,
                                            id_pasos = idPasos,
                                            orden = AdjByPk.orden,
                                            archivo = nombreImagen,
                                            extenciones_aceptadas = AdjByPk.extenciones_aceptadas,
                                            multiple = false,
                                        });
                                    }
                                }
                            }
                        }

                    }
                    Movimiento_tramites.insert(new Movimiento_tramites()
                    {
                        fecha = DateTime.Now,
                        cuit = formData.cuit,
                        accion = "INICIO",
                        en_vecino = true,
                        id_tramites = idTramites,
                        cod_oficina_destino = Convert.ToInt32(formData.idOficina.ToString())
                    });

                    MOTOR_WORKFLOW.Models.PasoModel paso1 =
    MOTOR_WORKFLOW.Entities.Paso.getByTramite(idTramite);
                    if (paso1 != null)
                    {
                        multinota(paso1, formData.cuit.ToString(), idTramites,
                            contenidoMultinota);
                    }
                }

                return "";
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private void multinota(MOTOR_WORKFLOW.Models.PasoModel paso, string cuit,
            int idTramites, string contenido)
        {
            try
            {


                MOTOR_WORKFLOW.Entities.Pasos pasos = new
                    MOTOR_WORKFLOW.Entities.Pasos();

                pasos.col = 12;
                pasos.id_adjunto = 0;
                pasos.id_ddjj = 0;
                pasos.id_formulario = paso.ID_FORMULARIO;
                pasos.id_ingreso_paso = paso.ID_INGRESOS_PASO;
                pasos.id_paso = paso.ID_PASO;
                pasos.id_tramites = idTramites;
                pasos.nombre_ingreso_paso = paso.NOMBRE_INGRESO_PASO;
                //pasos.orden_ingreso_paso = paso.orde
                pasos.orden_paso = paso.ROW;

                int idPasos = Pasos.insert(pasos);

                Formulario formulario = Formulario.getByPk(pasos.id_formulario);
                int num = Formularios.insert(new Formularios()
                {
                    id_formulario = pasos.id_formulario,
                    nombre = formulario.nombre,
                    descripcion = formulario.descripcion,
                    id_pasos = idPasos
                });

                Entities.VecinoDigital vecino =
                    Entities.VecinoDigital.getByPk(cuit);

                Models.MesaApiModel model = new Models.MesaApiModel();
                model.celular = vecino.TELEFONO;
                model.email = vecino.MAIL;
                model.cuit = vecino.CUIT;
                model.domicilio = vecino.DIRECCION;
                model.nombre = string.Format("{0}, {1}",
                    vecino.APELLIDO, vecino.NOMBRE);
                model.Observaciones = contenido;

                System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                string nro_expediente_completo = string.Empty;
                string anio = string.Empty;
                string nro_expediente = string.Empty;

                var options = new RestClientOptions(
     "https://vecino.villaallende.gov.ar/MesaApi/Expediente/NuevoExpedienteMultinotaConRetorno")
                {
                    MaxTimeout = -1,
                };

                var client = new RestClient(options);
                var request = new RestRequest("", Method.Post);
                request.AddHeader("Content-Type", "application/json");
                request.AddStringBody(JsonConvert.SerializeObject(model),
                    DataFormat.Json);

                RestResponse response = client.Execute(request);
                if (response.Content != null)
                    nro_expediente_completo = response.Content;

                //if (nro_expediente_completo.Length > 8)
                //{
                //    // Últimos 4 caracteres
                //    anio = nro_expediente_completo.Substring(nro_expediente_completo.Length - 4);

                //    // Resto de la cadena (sin los últimos 4 caracteres)
                //    nro_expediente = nro_expediente_completo.Substring(0, nro_expediente_completo.Length - 4);
                //}

                string respuesta_usuario = string.Empty;

                link_pago objLink = new link_pago();

                objLink.subtitulo = paso.SUBTITULO;
                objLink.titulo = paso.TITULO;
                objLink.texto = string.Format("{0} {1}",
                    paso.TEXTO, nro_expediente_completo);

                objLink.url =
     paso.URL_LINK_PAGO + "?anio=" + DateTime.Now.Year + "&nro=" + nro_expediente_completo;

                objLink.nro_tran = 0;
                respuesta_usuario = JsonConvert.SerializeObject(objLink);

                Respuesta_formulario.insert(new Respuesta_formulario()
                {
                    id_formularios = num,
                    nombre_campo = "Multinota",
                    id_tipo_campo = 23,
                    etiqueta_campo = "Multinota",
                    respuesta_usuario = respuesta_usuario,
                    orden = 1
                });

                // Tramites.finalizar_rechazar(idTramites, 4);


                Movimiento_tramites.insert(new Movimiento_tramites()
                {
                    fecha = DateTime.Now,
                    accion = "APRUEBA",
                    en_vecino = false,
                    id_tramites = idTramites,
                    destino_vecino = true,
                    id_oficina = 102,
                    cod_usuario = 0
                });


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]

        public string SavePasoMunicipal2()
        {
            try
            {

                var form = Request.Form["data"];
                var sessionHash = Request.Form["sessionHash"];
                var estado = Request.Form["estado"];
                Int32 idTramites = int.Parse(Request.Form["idTramites"]);
                bool notificacidi = false; 
                if (!string.IsNullOrEmpty(Request.Form["notificacioncidi"]))
                {
                    Boolean.TryParse(Request.Form["notificacioncidi"], out notificacidi);
                }
                dynamic respuestaTramite =
                    JsonConvert.DeserializeObject<dynamic>((string)form);

                var cod_usuario = Request.Form["cod_usuario"];
                IFormFileCollection files = Request.Form.Files;
                string str = "";
                if (respuestaTramite != null)
                {
                    int idPaso = Convert.ToInt32(respuestaTramite.idPaso.ToString());
                    MOTOR_WORKFLOW.Entities.Paso objPaso =
                        MOTOR_WORKFLOW.Entities.Paso.getByPk(idPaso);

                    int idTramite = Convert.ToInt32(respuestaTramite.idTramite.ToString());

                    foreach (dynamic paso in respuestaTramite.pasos)
                    {
                        Pasos pasos = new Pasos();
                        if (paso.id_formulario != null && Convert.ToInt32(
                            paso.id_formulario.ToString()) != 0)
                        {
                            ingreso_paso_modelF objForm = ingresos_x_paso.getByFormulario(
                                Convert.ToInt32(paso.id_formulario.ToString()));
                            pasos.id_ingreso_paso = objForm.id_ingreso_paso;
                            pasos.nombre_ingreso_paso = objForm.nombre_ingreso_paso;
                            pasos.orden_ingreso_paso = objForm.orden;
                            pasos.row = objForm.row;
                            pasos.col = objForm.col;
                            pasos.id_formulario = Convert.ToInt32(paso.id_formulario.ToString());
                        }
                        else
                        {
                            pasos.id_formulario = 0;
                        }
                        if (paso.id_adjunto != null && Convert.ToInt32(paso.id_adjunto.ToString()) != 0)
                        {
                            ingreso_paso_modelF objIngPmodel = ingresos_x_paso.getByAdjunto(
                                Convert.ToInt32(paso.id_adjunto.ToString()));
                            pasos.id_ingreso_paso = objIngPmodel.id_ingreso_paso;
                            pasos.nombre_ingreso_paso = objIngPmodel.nombre_paso;
                            pasos.orden_ingreso_paso = objIngPmodel.orden;
                            pasos.row = objIngPmodel.row;
                            pasos.col = objIngPmodel.col;
                            pasos.id_adjunto = Convert.ToInt32(paso.id_adjunto.ToString());
                        }
                        else
                        {
                            pasos.id_adjunto = 0;
                        }
                        pasos.id_tramites = idTramites;
                        pasos.id_paso = idPaso;

                        if (paso.id_ddjj != null &&
                            Convert.ToInt32(paso.id_ddjj.ToString()) != 0)
                        {
                            pasos.id_ddjj = Convert.ToInt32(paso.id_ddjj.ToString());
                        }
                        else
                        {
                            pasos.id_ddjj = 0;
                        }
                        int idPasos = Pasos.insert(pasos);

                        dynamic objDDJJs = paso.objDDJJs;
                        if (paso.id_ddjj != null && Convert.ToInt32(paso.id_ddjj.ToString()) != 0)
                            Ddjjs.insert(new Ddjjs()
                            {
                                id = 0,
                                ddjj = objDDJJs.respuesta_usuario.ToString(),
                                id_pasos = idPasos
                            });
                        if (paso.id_formulario != null && Convert.ToInt32(paso.id_formulario.ToString()) != 0)
                        {
                            Formulario byPk1 = Formulario.getByPk(Convert.ToInt32(paso.id_formulario.ToString()));
                            int num = Formularios.insert(new Formularios()
                            {
                                id_formulario = Convert.ToInt32(paso.id_formulario.ToString()),
                                nombre = byPk1.nombre,
                                descripcion = byPk1.descripcion,
                                id_pasos = idPasos
                            });
                            int indice = 0;
                            foreach (dynamic objFormulario in paso.objFormulario)
                            {
                                string respuesta_usuario = objFormulario.respuesta_usuario;
                                if (Convert.ToInt32(objFormulario.id_tipo_campo.ToString()) == 20)
                                {
                                    link_pago objLink = new link_pago();
                                    campos_x_formulario objCampo =
                                        byPk1.lstCampos.Find(f => f.id_tipo_campo == 20);
                                    objLink.texto = objCampo.TEXTO;
                                    objLink.titulo = objCampo.TITULO;
                                    objLink.subtitulo = objCampo.SUBTITULO;
                                    objLink.url = objCampo.URL_LINK_PAGO;
                                    objLink.nro_tran = objFormulario.respuesta_usuario;
                                    objLink.subsistema = objCampo.SUBSISTEMA;
                                    respuesta_usuario = JsonConvert.SerializeObject(objLink);
                                }
                                Respuesta_formulario.insert(new Respuesta_formulario()
                                {
                                    id_formularios = num,
                                    nombre_campo = byPk1.lstCampos[indice].nombre,
                                    id_tipo_campo = Convert.ToInt32(objFormulario.id_tipo_campo.ToString()),
                                    etiqueta_campo = byPk1.lstCampos[indice].etiqueta,
                                    respuesta_usuario = respuesta_usuario,
                                    orden = Convert.ToInt32(paso.orden_paso_IP.ToString())
                                });
                                indice++;
                            }
                        }
                        if (paso.id_adjunto != null && Convert.ToInt32(paso.id_adjunto.ToString()) != 0)
                        {
                            Adjunto AdjByPk = Adjunto.getByPk(Convert.ToInt32(paso.id_adjunto.ToString()));
                            foreach (dynamic objAdjunto in paso.objAdjuntos)
                            {

                                string carpetaImagenes = Path.Combine(
                                _webHostEnvironment.ContentRootPath, "adjunto");
                                if (!Directory.Exists(carpetaImagenes))
                                    Directory.CreateDirectory(carpetaImagenes);

                                IFormFile formFile =
                                    files.First(f => f.Name == objAdjunto.respuesta_usuario.ToString());

                                if (formFile.Length > 0L)
                                {
                                    string nombreImagen =
                                      "Tramites_" + idTramites.ToString() + "_" + objAdjunto.respuesta_usuario + Path.GetExtension(formFile.FileName);
                                    using (FileStream stream = new FileStream(Path.Combine(carpetaImagenes, nombreImagen), FileMode.Create))
                                        formFile.CopyTo(stream);

                                    Adjuntos.insert(new Adjuntos()
                                    {
                                        nombre = objAdjunto.etiqueta_campo,
                                        id_pasos = idPasos,
                                        orden = AdjByPk.orden,
                                        archivo = nombreImagen,
                                        extenciones_aceptadas = AdjByPk.extenciones_aceptadas,
                                        multiple = false,
                                    });
                                }
                            }

                        }
                        if (objPaso.es_final)
                        {
                            Tramites.finalizar_rechazar(idTramites, int.Parse((string)estado));

                            switch ((string)estado)
                            {
                                case "3":
                                    str = "RECHAZA";
                                    break;
                                case "4":
                                    str = "APRUEBA";
                                    break;
                            }

                        }
                        else
                        {
                            Tramites.mover(idTramites, objPaso.id, objPaso.id_oficina, objPaso.proxima_oficina);
                            Movimiento_tramites.insert(new Movimiento_tramites()
                            {
                                fecha = DateTime.Now,
                                accion = "PROCESA",
                                en_vecino = false,
                                id_tramites = idTramites,
                                destino_vecino = true,
                                id_oficina = objPaso.id_oficina,
                                cod_oficina_destino = objPaso.proxima_oficina,
                                cod_usuario = int.Parse((string)cod_usuario)
                            });
                        }
                        Movimiento_tramites.insert(new Movimiento_tramites()
                        {
                            fecha = DateTime.Now,
                            accion = str,
                            en_vecino = false,
                            id_tramites = idTramites,
                            destino_vecino = true,
                            id_oficina = objPaso.id_oficina,
                            cod_usuario = int.Parse((string)cod_usuario)
                        });
                        if (notificacidi is true)
                        {

                            string cuit = ""; // falta sacar el cuit de respuestaTramite
                            //string cuit = respuestaTramite.idTramite.ToString();
                            string hash = "";
                            var req = Request.Headers;
                            string cuerpoNotif = " <p> NOTIFICAR SIGUIENTE PASO DEL PROCESO- MUNICIPALIDAD DE VILLA ALLENDE </p>";
                            
                            cuit = "20355767966";  // HARDCODEO SI CUIT 
                             hash = sessionHash.ToString();
                            Email objEmail = new Email();
                            objEmail.HashCookie = hash;
                            objEmail.Cuil = cuit;// "20355767966";
                            objEmail.Asunto = "Notificacion - Municipalidad Villa Allende";
                            objEmail.Mensaje = cuerpoNotif;
                            objEmail.Firma = "Dirección de Sistemas";
                            objEmail.Ente = "Municipalidad de Villa Allende";
                            objEmail.Id_App = Config.CiDiIdAplicacion;
                            objEmail.Pass_App = Config.CiDiPassAplicacion;
                            objEmail.TimeStamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");
                            objEmail.TokenValue = Config.ObtenerToken_SHA512(objEmail.TimeStamp);

                            var respuesta = _ComunicacionesService.enviarNotificacionCUIT(cuit, objEmail);

                }
                    }
                }
                return "";
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return null;
            }
        }

        //[HttpPost]
        //public string savePasoMunicipal()
        //{
        //    try
        //    {
        //        var form = Request.Form["data"];
        //        var estado = Request.Form["estado"];
        //        Int32 idTramites = int.Parse(Request.Form["idTramites"]);
        //        var cod_usuario = Request.Form["cod_usuario"];
        //        IFormFileCollection files = Request.Form.Files;

        //        dynamic formData =
        //            JsonConvert.DeserializeObject<dynamic>(form);

        //        List<int> lstIdAdjuntos = new List<int>();
        //        if (formData != null)
        //        {
        //            int idPaso = int.Parse(formData.idPaso.ToString());
        //            int idTramite = int.Parse(formData.idTramite.ToString());
        //            int idTramites = Tramites.insert(new Tramites()
        //            {
        //                id_tramite = idTramite,
        //                cuit = formData.cuit.ToString(),
        //                cuit_representado = formData.cuitRepresentado.ToString(),
        //                fecha = DateTime.Now,
        //                paso_actual = int.Parse(formData.idPaso.ToString()),
        //                id_oficina = int.Parse(formData.idOficina.ToString())
        //            });
        //            int _idAdjunto = -1;

        //            foreach (dynamic paso in formData.pasos)
        //            {
        //                Pasos pasos = new Pasos();
        //                if (Convert.ToInt32(paso.id_formulario.ToString()) != 0)
        //                {
        //                    Formulario objForm = Formulario.getByPk(Convert.ToInt32(paso.id_formulario.ToString()));
        //                    contenido_ingreso_paso objCont = contenido_ingreso_paso.getByPk(
        //                        Convert.ToInt32(objForm.id_contenido_ingreso_paso));

        //                    pasos.row = objCont.row;
        //                    pasos.col = objCont.col;
        //                }
        //                else
        //                {
        //                    pasos.row = Convert.ToInt32(paso.row.ToString());
        //                    pasos.col = Convert.ToInt32(paso.col.ToString());
        //                }
        //                if (Convert.ToInt32(paso.id_adjunto.ToString()) != 0)
        //                {
        //                    ingreso_paso_modelF objIngPmodel = ingresos_x_paso.getByAdjunto(
        //                        Convert.ToInt32(paso.id_adjunto));
        //                    pasos.id_ingreso_paso = objIngPmodel.id_ingreso_paso;
        //                    pasos.nombre_ingreso_paso = objIngPmodel.nombre_ingreso_paso;
        //                    pasos.orden_ingreso_paso = objIngPmodel.orden;
        //                }
        //                else
        //                {
        //                    pasos.id_ingreso_paso = Convert.ToInt32(paso.id_ingreso_paso.ToString());
        //                    pasos.nombre_ingreso_paso = paso.nombre;
        //                    pasos.orden_ingreso_paso = paso.orden_paso;
        //                }
        //                pasos.id_tramites = idTramites;
        //                pasos.id_paso = idPaso;
        //                pasos.orden_paso = 1;
        //                pasos.id_formulario = Convert.ToInt32(paso.id_formulario.ToString());
        //                pasos.id_adjunto = Convert.ToInt32(paso.id_adjunto.ToString());
        //                pasos.id_ddjj = Convert.ToInt32(paso.id_ddjj.ToString());
        //                int idPasos = Pasos.insert(pasos);
        //                dynamic objDDJJs = paso.objDDJJs;
        //                if (Convert.ToInt32(paso.id_ddjj.ToString()) != 0)
        //                    Ddjjs.insert(new Ddjjs()
        //                    {
        //                        id = 0,
        //                        ddjj = objDDJJs.respuesta_usuario,
        //                        id_pasos = idPasos
        //                    });
        //                if (paso.id_formulario != 0)
        //                {
        //                    Formulario byPk = Formulario.getByPk(Convert.ToInt32(paso.id_formulario.ToString()));
        //                    int num = Formularios.insert(new Formularios()
        //                    {
        //                        id_formulario = Convert.ToInt32(paso.id_formulario.ToString()),
        //                        nombre = byPk.nombre,
        //                        descripcion = byPk.descripcion,
        //                        id_pasos = idPasos
        //                    });
        //                    foreach (dynamic objFormulario in paso.objFormulario)
        //                        Respuesta_formulario.insert(new Respuesta_formulario()
        //                        {
        //                            id_formularios = num,
        //                            nombre_campo = objFormulario.nombre_campo,
        //                            id_tipo_campo = Convert.ToInt32(objFormulario.id_tipo_campo.ToString()),
        //                            etiqueta_campo = objFormulario.etiqueta_campo,
        //                            respuesta_usuario = objFormulario.respuesta_usuario,
        //                            orden = 0//paso.orden_paso_IP.Value
        //                        });
        //                }
        //                if (Convert.ToInt32(paso.id_adjunto.ToString()) != 0)
        //                {
        //                    Adjunto AdjByPk = Adjunto.getByPk(Convert.ToInt32(paso.id_adjunto.ToString()));
        //                    foreach (dynamic objAdjunto in paso.objAdjuntos)
        //                    {

        //                        string carpetaImagenes = Path.Combine(
        //                        _webHostEnvironment.ContentRootPath, "Adjuntos");
        //                        if (!Directory.Exists(carpetaImagenes))
        //                            Directory.CreateDirectory(carpetaImagenes);

        //                        IFormFile formFile =
        //                            files.First(f => f.Name == objAdjunto.respuesta_usuario.ToString());

        //                        if (formFile.Length > 0L)
        //                        {
        //                            string nombreImagen =
        //                              "Tramites_" + idTramites.ToString() + "_" + objAdjunto.respuesta_usuario + Path.GetExtension(formFile.FileName);
        //                            using (FileStream stream = new FileStream(Path.Combine(carpetaImagenes, nombreImagen), FileMode.Create))
        //                                formFile.CopyTo(stream);

        //                            Adjuntos.insert(new Adjuntos()
        //                            {
        //                                nombre = objAdjunto.etiqueta_campo,
        //                                id_pasos = idPasos,
        //                                orden = AdjByPk.orden,
        //                                archivo = nombreImagen,
        //                                extenciones_aceptadas = AdjByPk.extenciones_aceptadas,
        //                                multiple = false,
        //                            });
        //                        }
        //                    }

        //                }

        //            }
        //            Movimiento_tramites.insert(new Movimiento_tramites()
        //            {
        //                fecha = DateTime.Now,
        //                cuit = formData.cuit,
        //                accion = "INICIO",
        //                en_vecino = true,
        //                id_tramites = idTramites,
        //                cod_oficina_destino = Convert.ToInt32(formData.idOficina.ToString())
        //            });

        //        }
        //        return "";
        //    }
        //    catch (Exception ex)
        //    {
        //        return (IActionResult)this.StatusCode(500);
        //    }
        //}

        [HttpGet]
        public IActionResult read(int idTramite)
        {
            List<MOTOR_WORKFLOW.Entities.Paso> pasoList = this._PasoService.read(idTramite);
            return pasoList == null ? (IActionResult)this.BadRequest(new
            {
                message = "Error al obtener los datos"
            }) : (IActionResult)this.Ok(pasoList);
        }
        [HttpGet]
        public IActionResult getByPk(int ID)
        {
            MOTOR_WORKFLOW.Entities.Paso byPk = this._PasoService.getByPk(ID);
            return byPk == null ? (IActionResult)this.BadRequest(new
            {
                message = "Error al obtener los datos"
            }) : (IActionResult)this.Ok(byPk);
        }
        [HttpGet]
        public IActionResult readBackEnd(int idTramite)
        {
            List<MOTOR_WORKFLOW.Entities.Paso> pasoList = this._PasoService.readBackEnd(idTramite);
            return pasoList == null ? (IActionResult)this.BadRequest(new
            {
                message = "Error al obtener los datos"
            }) : (IActionResult)this.Ok(pasoList);
        }

        [HttpPost]
        public IActionResult insert(Entities.PasoModel obj)
        {
            try
            {
                this._PasoService.insert(obj);
                return (IActionResult)this.Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        [HttpPost]
        public IActionResult update(Entities.PasoModel obj)
        {
            try
            {
                this._PasoService.update(obj);
                return (IActionResult)this.Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpGet]
        public IActionResult delete(int idPaso)
        {
            try
            {
                this._PasoService.delete(idPaso);
                return (IActionResult)this.Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}