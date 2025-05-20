// Decompiled with JetBrains decompiler
// Type: MOTOR_WORKFLOW.Controllers.Contenido_ingreso_pasoController
// Assembly: MOTOR_WORKFLOW, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 007B8F5F-49BB-4EE7-8464-22FD2F567A18
// Assembly location: C:\Muni\DEV\WebApiMWF\MOTOR_WORKFLOW.dll

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc; 
using MOTOR_WORKFLOW.Entities;
using MOTOR_WORKFLOW.Models;
using MOTOR_WORKFLOW.Services;
using System;
using System.Collections.Generic;

#nullable enable
namespace MOTOR_WORKFLOW.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class Contenido_ingreso_pasoController : Controller
    {
        private IContenido_ingreso_pasoService _Contenido_ingreso_pasoService;
        private IDdjjService _DdjjService;
        private IAdjuntoService _AdjuntoService;
        private IFormularioService _FormularioService;

        public Contenido_ingreso_pasoController(
          IContenido_ingreso_pasoService Contenido_ingreso_pasoService,
          IDdjjService ddjjService,
          IAdjuntoService adjuntoService,
          IFormularioService formularioService)
        {
            this._Contenido_ingreso_pasoService = Contenido_ingreso_pasoService;
            this._DdjjService = ddjjService;
            this._AdjuntoService = adjuntoService;
            this._FormularioService = formularioService;
        }
        [Authorize]
        [HttpGet]
        public IActionResult getByPk(int ID)
        {
            contenido_ingreso_paso byPk = this._Contenido_ingreso_pasoService.getByPk(ID);
            return byPk == null ? (IActionResult)this.BadRequest(new
            {
                message = "Error al obtener los datos"
            }) : (IActionResult)this.Ok(byPk);
        }
        [Authorize]
        [HttpGet]
        public IActionResult read(int id_ingreso_paso)
        {
            List<contenido_ingreso_paso> contenidoIngresoPasoList = this._Contenido_ingreso_pasoService.read(id_ingreso_paso);
            return contenidoIngresoPasoList == null ? (IActionResult)this.BadRequest(new
            {
                message = "Error al obtener los datos"
            }) : (IActionResult)this.Ok(contenidoIngresoPasoList);
        }
        [Authorize]
        [HttpGet]
        public IActionResult maxRow(int id_ingreso_paso)
        {
            return (IActionResult)this.Ok(this._Contenido_ingreso_pasoService.maxRow(id_ingreso_paso));
        }
        [Authorize]
        [HttpPost]
        public IActionResult insertDDJJ(ddjj obj)
        {
            try
            {
                this._DdjjService.insert(obj);
                return (IActionResult)this.Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [Authorize]
        [HttpPost]
        public IActionResult updateDDJJ(ddjj obj)
        {
            try
            {
                this._DdjjService.update(obj);
                return (IActionResult)this.Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [Authorize]
        [HttpGet]
        public IActionResult deleteDDJJ(string id)
        {
            try
            {
                this._DdjjService.delete(id);
                return (IActionResult)this.Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [Authorize]
        [HttpPost]
        public IActionResult insertAdjunto(AdjuntoModel obj)
        {
            try
            {
                this._AdjuntoService.insert(obj);
                return (IActionResult)this.Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [Authorize]
        [HttpPost]
        public IActionResult updateAdjunto(AdjuntoModel obj)
        {
            try
            {
                this._AdjuntoService.update(obj);
                return (IActionResult)this.Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [Authorize]
        [HttpGet]
        public IActionResult deleteAdjunto(string id)
        {
            try
            {
                this._AdjuntoService.delete(id);
                return (IActionResult)this.Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [Authorize]
        [HttpPost]
        public IActionResult insertFormulario(FormularioModel obj)
        {
            try
            {
                this._FormularioService.insert(obj);
                return (IActionResult)this.Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [Authorize]
        [HttpPost]
        public IActionResult updateFormlario(FormularioModel obj)
        {
            try
            {
                this._FormularioService.update(obj);
                return (IActionResult)this.Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [Authorize]
        [HttpGet]
        public IActionResult deleteFormulario(string id)
        {
            try
            {
                this._FormularioService.delete(id);
                return (IActionResult)this.Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [Authorize]
        [HttpPost]
        public IActionResult insert(contenido_ingreso_paso_model obj)
        {
            try
            {
                this._Contenido_ingreso_pasoService.insert(obj);

                return (IActionResult)this.Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [Authorize]
        [HttpPost]
        public IActionResult update(contenido_ingreso_paso obj)
        {
            try
            {
                this._Contenido_ingreso_pasoService.update(obj);
                return (IActionResult)this.Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [Authorize]
        [HttpGet]
        public IActionResult delete(int id, int row)
        {
            try
            {
                this._Contenido_ingreso_pasoService.delete(id, row);
                return (IActionResult)this.Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
