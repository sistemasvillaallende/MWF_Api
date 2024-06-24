// Decompiled with JetBrains decompiler
// Type: MOTOR_WORKFLOW.Controllers.PasoController
// Assembly: MOTOR_WORKFLOW, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 007B8F5F-49BB-4EE7-8464-22FD2F567A18
// Assembly location: C:\Muni\DEV\WebApiMWF\MOTOR_WORKFLOW.dll

using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CSharp.RuntimeBinder;
using Microsoft.Extensions.Primitives;
using MOTOR_WORKFLOW.Entities;
using MOTOR_WORKFLOW.Models;
using MOTOR_WORKFLOW.Services;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

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

        public PasoController(
          IPasoService PasoService,
          IWebHostEnvironment webHostEnvironment,
          IWebHostEnvironment hostEnvironment)
        {
            this._PasoService = PasoService;
            this._HostEnvironment = hostEnvironment;
            this._webHostEnvironment = webHostEnvironment;
        }

        [HttpPost]
        public string SavePaso2()
        {
            try
            {
                var form = Request.Form["data"];

                IFormFileCollection files = Request.Form.Files;

                MOTOR_WORKFLOW.Models.RespuestaTramite formData =
                    JsonConvert.DeserializeObject<MOTOR_WORKFLOW.Models.RespuestaTramite>(form);




                if (formData != null)
                {
                    int idPaso = formData.idPaso.Value;
                    int idTramite = formData.idTramite.Value;
                    int idTramites = Tramites.insert(new Tramites()
                    {
                        id_tramite = formData.idTramite.Value,
                        cuit = formData.cuit,
                        cuit_representado = formData.cuitRepresentado,
                        fecha = DateTime.Now,
                        paso_actual = formData.idPaso.Value,
                        id_oficina = formData.idOficina.Value
                    });

                    foreach (MOTOR_WORKFLOW.Models.Paso paso in formData.pasos)
                    {
                        Pasos pasos = new Pasos();
                        if (paso.id_formulario != 0)
                        {
                            Formulario objForm = Formulario.getByPk(paso.id_formulario.Value);
                            contenido_ingreso_paso objCont = contenido_ingreso_paso.getByPk(
                                objForm.id_contenido_ingreso_paso);

                            pasos.row = objCont.row;
                            pasos.col = objCont.col;
                        }
                        else
                        {
                            pasos.row = paso.row.Value;
                            pasos.col = paso.col.Value;
                        }
                        if (paso.id_adjunto != 0)
                        {
                            ingreso_paso_modelF objIngPmodel = ingresos_x_paso.getByAdjunto(paso.id_adjunto);
                            pasos.id_ingreso_paso = objIngPmodel.id_ingreso_paso;
                            pasos.nombre_ingreso_paso = objIngPmodel.nombre_ingreso_paso;
                            pasos.orden_ingreso_paso = objIngPmodel.orden;
                        }
                        else
                        {
                            pasos.id_ingreso_paso = Convert.ToInt32(paso.id_ingreso_paso);
                            pasos.nombre_ingreso_paso = paso.nombre;
                            pasos.orden_ingreso_paso = paso.orden_paso;
                        }


                        pasos.id_tramites = idTramites;
                        pasos.id_paso = idPaso;
                        pasos.orden_paso = 1;
                        pasos.id_formulario = paso.id_formulario.Value;
                        pasos.id_adjunto = paso.id_adjunto;
                        pasos.id_ddjj = paso.id_ddjj;
                        int idPasos = Pasos.insert(pasos);
                        if (paso.id_ddjj != 0)
                            Ddjjs.insert(new Ddjjs()
                            {
                                id = 0,
                                ddjj = paso.objDDJJs.respuesta_usuario,
                                id_pasos = idPasos
                            });
                        if (paso.id_formulario != 0)
                        {
                            Formulario byPk = Formulario.getByPk(paso.id_formulario.Value);
                            int num = Formularios.insert(new Formularios()
                            {
                                id_formulario = paso.id_formulario.Value,
                                nombre = byPk.nombre,
                                descripcion = byPk.descripcion,
                                id_pasos = idPasos
                            });
                            foreach (ObjFormulario objFormulario in paso.objFormulario)
                                Respuesta_formulario.insert(new Respuesta_formulario()
                                {
                                    id_formularios = num,
                                    nombre_campo = objFormulario.nombre_campo,
                                    id_tipo_campo = Convert.ToInt32(objFormulario.id_tipo_campo),
                                    etiqueta_campo = objFormulario.etiqueta_campo,
                                    respuesta_usuario = objFormulario.respuesta_usuario,
                                    orden = 0//paso.orden_paso_IP.Value
                                });
                        }
                        if (paso.id_adjunto != 0)
                        {
                            //StringValues stringValues2 = form["img_ContentPlaceHolder1_fUp_2[]"];
                            Adjuntos adjuntos = new Adjuntos();
                            Adjunto byPk = Adjunto.getByPk(paso.id_adjunto);
                            adjuntos.id = Convert.ToInt32(paso.id_adjunto);
                            adjuntos.nombre = byPk.etiqueta;
                            adjuntos.id_pasos = idPasos;
                            adjuntos.archivo = paso.objAdjuntos.respuesta_usuario;
                            adjuntos.extenciones_aceptadas = byPk.extenciones_aceptadas;
                            adjuntos.multiple = byPk.multiple;
                            int idAdjuntos = Adjuntos.insert(adjuntos);

                            string carpetaImagenes = "C:\\inetpub\\wwwroot\\img\\MWF";
                            if (!Directory.Exists(carpetaImagenes))
                                Directory.CreateDirectory(carpetaImagenes);
                            int f = 0;
                            List<ContenidoAdjunto> lstContenido = new List<ContenidoAdjunto>();
                            foreach (IFormFile formFile in (IEnumerable<IFormFile>)files)
                            {
                                if (formFile.Length > 0L)
                                {
                                    string nombreImagen = "Tramite_" + idTramites.ToString() + "_Paso_" + idPasos.ToString() + "_Adjunto_" + idAdjuntos.ToString() + "_" + f.ToString() + Path.GetExtension(formFile.FileName);
                                    using (FileStream stream = new FileStream(Path.Combine(carpetaImagenes, nombreImagen), FileMode.Create))
                                        formFile.CopyTo(stream);
                                    lstContenido.Add(new ContenidoAdjunto(idAdjuntos, nombreImagen));
                                    ++f;
                                    nombreImagen = (string)null;
                                }
                            }
                            Adjuntos.setArchivo(idAdjuntos, JsonConvert.SerializeObject((object)lstContenido));
                            carpetaImagenes = (string)null;
                            lstContenido = (List<ContenidoAdjunto>)null;
                        }
                        Movimiento_tramites.insert(new Movimiento_tramites()
                        {
                            fecha = DateTime.Now,
                            cuit = formData.cuit,
                            accion = "INICIO",
                            en_vecino = true,
                            id_tramites = idTramites,
                            cod_oficina_destino = formData.idOficina.Value
                        });
                    }
                }
                return "";
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        [HttpPost]
        public string SavePasoMunicipal2()
        {
            try
            {
                var form = Request.Form["data"];

                var estado = Request.Form["estado"];
                Int32 idTramites = int.Parse(Request.Form["idTramites"]);

                IFormFileCollection files = Request.Form.Files;
                MOTOR_WORKFLOW.Models.RespuestaTramite respuestaTramite =
                    JsonConvert.DeserializeObject<MOTOR_WORKFLOW.Models.RespuestaTramite>((string)form);
                var cod_usuario = Request.Form["cod_usuario"];
                if (respuestaTramite != null)
                {
                    int idPaso = respuestaTramite.idPaso.Value;
                    MOTOR_WORKFLOW.Entities.Paso objPaso = MOTOR_WORKFLOW.Entities.Paso.getByPk(idPaso);
                    int idTramite = respuestaTramite.idTramite.Value;
                    //int idTramites = Tramites.insert(new Tramites()
                    //{
                    //    id_tramite = respuestaTramite.idTramite.Value,
                    //    cuit = respuestaTramite.cuit,
                    //    cuit_representado = respuestaTramite.cuitRepresentado,
                    //    fecha = DateTime.Now,
                    //    paso_actual = respuestaTramite.idPaso.Value,
                    //    id_oficina = objPaso.id_oficina
                    //});
                    foreach (MOTOR_WORKFLOW.Models.Paso paso in respuestaTramite.pasos)
                    {
                        Pasos pasos = new Pasos();
                        if (paso.id_formulario != 0)
                        {
                            ingreso_paso_modelF objForm = ingresos_x_paso.getByFormulario(
                                paso.id_formulario.Value);
                            pasos.id_ingreso_paso = objForm.id_ingreso_paso;
                            pasos.nombre_ingreso_paso = objForm.nombre_ingreso_paso;
                            pasos.orden_ingreso_paso = objForm.orden;
                            pasos.row = objForm.row;
                            pasos.col = objForm.col;
                        }
                        if (paso.id_adjunto != 0)
                        {
                            ingreso_paso_modelF objIngPmodel = ingresos_x_paso.getByAdjunto(paso.id_adjunto);
                            pasos.id_ingreso_paso = objIngPmodel.id_ingreso_paso;
                            pasos.nombre_ingreso_paso = objIngPmodel.nombre_ingreso_paso;
                            pasos.orden_ingreso_paso = objIngPmodel.orden;
                            pasos.row = objIngPmodel.row;
                            pasos.col = objIngPmodel.col;
                        }
                        pasos.id_tramites = idTramites;
                        pasos.id_paso = idPaso;
                        pasos.id_formulario = paso.id_formulario.Value;
                        pasos.id_adjunto = paso.id_adjunto;
                        pasos.id_ddjj = paso.id_ddjj;
                        int idPasos = Pasos.insert(pasos);
                        if (paso.id_ddjj != 0)
                            Ddjjs.insert(new Ddjjs()
                            {
                                id = 0,
                                ddjj = paso.objDDJJs.respuesta_usuario,
                                id_pasos = idPasos
                            });
                        if (paso.id_formulario != 0)
                        {
                            Formulario byPk1 = Formulario.getByPk(paso.id_formulario.Value);
                            int num = Formularios.insert(new Formularios()
                            {
                                id_formulario = paso.id_formulario.Value,
                                nombre = byPk1.nombre,
                                descripcion = byPk1.descripcion,
                                id_pasos = idPasos
                            });
                            foreach (ObjFormulario objFormulario in paso.objFormulario)
                                Respuesta_formulario.insert(new Respuesta_formulario()
                                {
                                    id_formularios = num,
                                    nombre_campo = objFormulario.nombre_campo,
                                    id_tipo_campo = Convert.ToInt32(objFormulario.id_tipo_campo),
                                    etiqueta_campo = objFormulario.etiqueta_campo,
                                    respuesta_usuario = objFormulario.respuesta_usuario,
                                    orden = paso.orden_paso_IP.Value
                                });
                        }
                        if (paso.id_adjunto != 0)
                        {
                            //var stringValues2 = form["img_ContentPlaceHolder1_fUp_2[]"];
                            Adjuntos adjuntos = new Adjuntos();
                            Adjunto byPk2 = Adjunto.getByPk(paso.id_adjunto);
                            adjuntos.id = Convert.ToInt32(paso.id_adjunto);
                            adjuntos.nombre = byPk2.etiqueta;
                            adjuntos.id_pasos = idPasos;
                            adjuntos.archivo = paso.objAdjuntos.respuesta_usuario;
                            adjuntos.extenciones_aceptadas = byPk2.extenciones_aceptadas;
                            adjuntos.multiple = byPk2.multiple;
                            int idAdjuntos = Adjuntos.insert(adjuntos);

                            string carpetaImagenes = "C:\\inetpub\\wwwroot\\img\\MWF";
                            if (!Directory.Exists(carpetaImagenes))
                                Directory.CreateDirectory(carpetaImagenes);
                            int f = 0;
                            List<ContenidoAdjunto> lstContenido = new List<ContenidoAdjunto>();
                            foreach (IFormFile formFile in (IEnumerable<IFormFile>)files)
                            {
                                if (formFile.Length > 0L)
                                {
                                    string nombreImagen = "Tramite_" + idTramites.ToString() + "_Paso_" + idPasos.ToString() + "_Adjunto_" + idAdjuntos.ToString() + "_" + f.ToString() + Path.GetExtension(formFile.FileName);
                                    using (FileStream stream = new FileStream(Path.Combine(carpetaImagenes, nombreImagen), FileMode.Create))
                                        formFile.CopyTo(stream);
                                    lstContenido.Add(new ContenidoAdjunto(idAdjuntos, nombreImagen));
                                    ++f;
                                    nombreImagen = (string)null;
                                }
                            }
                            Adjuntos.setArchivo(idAdjuntos, JsonConvert.SerializeObject((object)lstContenido));
                            carpetaImagenes = (string)null;
                            lstContenido = (List<ContenidoAdjunto>)null;
                        }
                        if (objPaso.es_final)
                        {
                            Tramites.finalizar_rechazar(idTramites, int.Parse((string)estado));
                            string str = "";
                            switch ((string)estado)
                            {
                                case "3":
                                    str = "RECHAZA";
                                    break;
                                case "4":
                                    str = "APRUEBA";
                                    break;
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
                    }
                }
                return "";
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        [HttpPost]
        public async Task<IActionResult> savePasoMunicipal()
        {
            PasoController pasoController1 = this;
            try
            {
                IFormCollection form = await pasoController1.Request.ReadFormAsync();
                var stringValues1 = form["data"];
                var estado = form["estado"];
                IFormFileCollection files = form.Files;
                var cod_usuario = form["cod_usuario"];
                int idTramites = Convert.ToInt32((string)form["idTramites"]);
                MOTOR_WORKFLOW.Models.RespuestaTramite objeto = JsonConvert.DeserializeObject<MOTOR_WORKFLOW.Models.RespuestaTramite>((string)stringValues1);
                MOTOR_WORKFLOW.Entities.Paso objPaso = MOTOR_WORKFLOW.Entities.Paso.getByPk(objeto.idPaso.Value);
                Pasos objPasos = new Pasos();
                for (int i = 0; i < objeto.pasos.Count; ++i)
                {
                    ingresos_x_paso byPk1 = ingresos_x_paso.getByPk(objeto.pasos[i].id_ingreso_paso.Value);
                    objPasos.id_tramites = Convert.ToInt32(idTramites);
                    objPasos.id_paso = objPaso.id;
                    objPasos.orden_paso = objPaso.orden;
                    objPasos.id_ingreso_paso = byPk1.id;
                    objPasos.orden_ingreso_paso = byPk1.orden;
                    objPasos.nombre_ingreso_paso = byPk1.titulo;
                    objPasos.row = Convert.ToInt32(objeto.pasos[i].row);
                    objPasos.col = Convert.ToInt32(objeto.pasos[i].col);
                    objPasos.id_formulario = Convert.ToInt32(objeto.pasos[0].id_formulario);
                    objPasos.id_adjunto = Convert.ToInt32(objeto.pasos[i].id_adjunto);
                    objPasos.id_ddjj = Convert.ToInt32(objeto.pasos[i].id_ddjj);
                    int idPasos = Pasos.insert(objPasos);
                    if (objeto.pasos[i].id_ddjj != 0)
                        Ddjjs.insert(new Ddjjs()
                        {
                            id = objeto.pasos[i].id_ddjj,
                            ddjj = objeto.pasos[i].objDDJJs.respuesta_usuario,
                            id_pasos = Convert.ToInt32(idPasos)
                        });
                    if (objeto.pasos[i].id_formulario != 0)
                    {
                        Formulario byPk2 = Formulario.getByPk(objeto.pasos[i].id_formulario.Value);
                        int num = Formularios.insert(new Formularios()
                        {
                            id_formulario = objeto.pasos[i].id_formulario.Value,
                            nombre = byPk2.nombre,
                            descripcion = byPk2.descripcion,
                            id_pasos = idPasos
                        });
                        foreach (ObjFormulario objFormulario in objeto.pasos[i].objFormulario)
                        {
                            Respuesta_formulario respuestaFormulario = new Respuesta_formulario();
                            campos_x_formulario byPk3 = campos_x_formulario.getByPk(objFormulario.id);
                            respuestaFormulario.id_formularios = num;
                            respuestaFormulario.nombre_campo = byPk3.nombre;
                            respuestaFormulario.id_tipo_campo = byPk3.id_tipo_campo;
                            respuestaFormulario.etiqueta_campo = byPk3.etiqueta;
                            switch (respuestaFormulario.id_tipo_campo)
                            {
                                case 1:
                                    respuestaFormulario.respuesta_usuario = objFormulario.respuesta_usuario;
                                    break;
                                case 2:
                                    respuestaFormulario.respuesta_usuario = objFormulario.respuesta_usuario;
                                    break;
                                case 3:
                                    respuestaFormulario.respuesta_usuario = Convert.ToString(objFormulario.respuesta_usuario);
                                    break;
                                case 4:
                                    respuestaFormulario.respuesta_usuario = objFormulario.respuesta_usuario;
                                    break;
                                case 5:
                                    respuestaFormulario.respuesta_usuario = objFormulario.respuesta_usuario;
                                    break;
                                case 6:
                                    respuestaFormulario.respuesta_usuario = Convert.ToString(objFormulario.respuesta_usuario);
                                    break;
                                case 7:
                                    respuestaFormulario.respuesta_usuario = Convert.ToString(objFormulario.respuesta_usuario);
                                    break;
                                case 8:
                                    respuestaFormulario.respuesta_usuario = Convert.ToString(objFormulario.respuesta_usuario);
                                    break;
                                case 9:
                                    respuestaFormulario.respuesta_usuario = JsonConvert.SerializeObject((object)objFormulario.respuesta_usuario);
                                    break;
                                case 14:
                                    respuestaFormulario.respuesta_usuario = Convert.ToString(objFormulario.respuesta_usuario);
                                    break;
                            }
                            respuestaFormulario.orden = Convert.ToInt32(objFormulario.orden);
                            Respuesta_formulario.insert(respuestaFormulario);
                        }
                    }
                    if (objeto.pasos[i].id_adjunto != 0)
                    {
                        var stringValues2 = form["img_ContentPlaceHolder1_fUp_2[]"];
                        Adjuntos adjuntos = new Adjuntos();
                        Adjunto byPk4 = Adjunto.getByPk(objeto.pasos[i].id_adjunto);
                        adjuntos.id = Convert.ToInt32(objeto.pasos[i].id_adjunto);
                        adjuntos.nombre = byPk4.etiqueta;
                        adjuntos.id_pasos = idPasos;
                        adjuntos.archivo = objeto.pasos[i].objAdjuntos.respuesta_usuario;
                        adjuntos.extenciones_aceptadas = byPk4.extenciones_aceptadas;
                        adjuntos.multiple = byPk4.multiple;
                        int idAdjuntos = Adjuntos.insert(adjuntos);
                        if (files == null || files.Count == 0)
                            return (IActionResult)pasoController1.BadRequest((object)"No se han proporcionado imágenes.");
                        string carpetaImagenes = "C:\\inetpub\\wwwroot\\img\\MWF";
                        if (!Directory.Exists(carpetaImagenes))
                            Directory.CreateDirectory(carpetaImagenes);
                        int f = 0;
                        List<ContenidoAdjunto> lstContenido = new List<ContenidoAdjunto>();
                        foreach (IFormFile formFile in (IEnumerable<IFormFile>)files)
                        {
                            if (formFile.Length > 0L)
                            {
                                string nombreImagen = "Tramite_" + idTramites.ToString() + "_Paso_" + idPasos.ToString() + "_Adjunto_" + idAdjuntos.ToString() + "_" + f.ToString() + Path.GetExtension(formFile.FileName);
                                using (FileStream stream = new FileStream(Path.Combine(carpetaImagenes, nombreImagen), FileMode.Create))
                                    await formFile.CopyToAsync((Stream)stream);
                                lstContenido.Add(new ContenidoAdjunto(idAdjuntos, nombreImagen));
                                ++f;
                                nombreImagen = (string)null;
                            }
                        }
                        Adjuntos.setArchivo(idAdjuntos, JsonConvert.SerializeObject((object)lstContenido));
                        carpetaImagenes = (string)null;
                        lstContenido = (List<ContenidoAdjunto>)null;
                    }
                }
                if (objPaso.es_final)
                {
                    Tramites.finalizar_rechazar(idTramites, int.Parse((string)estado));
                    string str = "";
                    switch ((string)estado)
                    {
                        case "3":
                            str = "RECHAZA";
                            break;
                        case "4":
                            str = "APRUEBA";
                            break;
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
                return (IActionResult)pasoController1.Ok();
            }
            catch (Exception ex)
            {
                return (IActionResult)this.StatusCode(500);
            }
        }

        [HttpGet]
        public IActionResult read(int idTramite)
        {
            List<MOTOR_WORKFLOW.Entities.Paso> pasoList = this._PasoService.read(idTramite);
            return pasoList == null ? (IActionResult)this.BadRequest((object)new
            {
                message = "Error al obtener los datos"
            }) : (IActionResult)this.Ok((object)pasoList);
        }
        [HttpGet]
        public IActionResult getByPk(int ID)
        {
            MOTOR_WORKFLOW.Entities.Paso byPk = this._PasoService.getByPk(ID);
            return byPk == null ? (IActionResult)this.BadRequest((object)new
            {
                message = "Error al obtener los datos"
            }) : (IActionResult)this.Ok((object)byPk);
        }
        [HttpGet]
        public IActionResult readBackEnd(int idTramite)
        {
            List<MOTOR_WORKFLOW.Entities.Paso> pasoList = this._PasoService.readBackEnd(idTramite);
            return pasoList == null ? (IActionResult)this.BadRequest((object)new
            {
                message = "Error al obtener los datos"
            }) : (IActionResult)this.Ok((object)pasoList);
        }

        [HttpPost]
        public IActionResult insert(PasoModel obj)
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
        public IActionResult update(PasoModel obj)
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
    }
}