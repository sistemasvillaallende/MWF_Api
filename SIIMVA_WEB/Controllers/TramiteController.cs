// Decompiled with JetBrains decompiler
// Type: MOTOR_WORKFLOW.Controllers.TramiteController
// Assembly: MOTOR_WORKFLOW, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 007B8F5F-49BB-4EE7-8464-22FD2F567A18
// Assembly location: C:\Muni\DEV\WebApiMWF\MOTOR_WORKFLOW.dll

using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using MOTOR_WORKFLOW.Entities;
using MOTOR_WORKFLOW.Services;
using System;
using System.Collections.Generic;

#nullable enable
namespace MOTOR_WORKFLOW.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class TramiteController : Controller
    {
        private ITramiteService _TramiteService;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public TramiteController(ITramiteService TramiteService, IWebHostEnvironment webHostEnvironment)
        {
            this._TramiteService = TramiteService;
            _webHostEnvironment = webHostEnvironment;
        }

        [HttpGet]
        public IActionResult getByPk(int ID)
        {
            Tramite byPk = this._TramiteService.getByPk(ID);
            return byPk == null ? (IActionResult)this.BadRequest(new
            {
                message = "Error al obtener los datos"
            }) : (IActionResult)this.Ok(byPk);
        }
        [HttpGet]
        public IActionResult VerificaConsistencia(int ID)
        {
            string error = this._TramiteService.VerificaConsistencia(ID);
            return Ok(error);
        }
        [HttpGet]
        public IActionResult read()
        {
            List<Tramite> tramiteList = this._TramiteService.read();
            return tramiteList == null ? (IActionResult)this.BadRequest(new
            {
                message = "Error al obtener los datos"
            }) : (IActionResult)this.Ok(tramiteList);
        }

        [HttpGet]
        public IActionResult readBack()
        {
            List<Tramite> tramiteList = this._TramiteService.readBack();
            return tramiteList == null ? (IActionResult)this.BadRequest(new
            {
                message = "Error al obtener los datos"
            }) : (IActionResult)this.Ok(tramiteList);
        }

        [HttpGet]
        public IActionResult IniciaTramite(int ID)
        {
            Tramite byPk = this._TramiteService.getByPk(ID);
            return byPk == null ? (IActionResult)this.BadRequest(new
            {
                message = "Error al obtener los datos"
            }) : (IActionResult)this.Ok(byPk);
        }

        [HttpGet]
        public IActionResult getDatosIniciador(int ID)
        {
            Tramite byPk = this._TramiteService.getByPk(ID);
            return byPk == null ? (IActionResult)this.BadRequest(new
            {
                message = "Error al obtener los datos"
            }) : (IActionResult)this.Ok(byPk);
        }

        [HttpPost]
        public IActionResult insert(Models.TramiteInsert obj)
        {
            try
            {
                this._TramiteService.insert(obj);
                return (IActionResult)this.Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpPost]
        public IActionResult duplicar(Models.TramiteDuplicar obj)
        {
            try
            {
                this._TramiteService.duplicar(obj);
                return (IActionResult)this.Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public IActionResult update(Models.TramiteInsert obj)
        {
            try
            {
                this._TramiteService.update(obj);
                return (IActionResult)this.Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public IActionResult activaDesactiva(Models.TramiteActivar obj)
        {
            try
            {

                this._TramiteService.activaDesactiva(obj);
                return (IActionResult)this.Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpGet]
        public IActionResult delete(int id_tramite)
        {
            try
            {
                this._TramiteService.delete(id_tramite);
                return (IActionResult)this.Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
