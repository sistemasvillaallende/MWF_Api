// Decompiled with JetBrains decompiler
// Type: MOTOR_WORKFLOW.Controllers.TramiteController
// Assembly: MOTOR_WORKFLOW, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 007B8F5F-49BB-4EE7-8464-22FD2F567A18
// Assembly location: C:\Muni\DEV\WebApiMWF\MOTOR_WORKFLOW.dll

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

        public TramiteController(ITramiteService TramiteService)
        {
            this._TramiteService = TramiteService;
        }

        [HttpGet]
        public IActionResult getByPk(int ID)
        {
            Tramite byPk = this._TramiteService.getByPk(ID);
            return byPk == null ? (IActionResult)this.BadRequest((object)new
            {
                message = "Error al obtener los datos"
            }) : (IActionResult)this.Ok((object)byPk);
        }

        [HttpGet]
        public IActionResult read()
        {
            List<Tramite> tramiteList = this._TramiteService.read();
            return tramiteList == null ? (IActionResult)this.BadRequest((object)new
            {
                message = "Error al obtener los datos"
            }) : (IActionResult)this.Ok((object)tramiteList);
        }

        [HttpGet]
        public IActionResult readBack()
        {
            List<Tramite> tramiteList = this._TramiteService.readBack();
            return tramiteList == null ? (IActionResult)this.BadRequest((object)new
            {
                message = "Error al obtener los datos"
            }) : (IActionResult)this.Ok((object)tramiteList);
        }

        [HttpGet]
        public IActionResult IniciaTramite(int ID)
        {
            Tramite byPk = this._TramiteService.getByPk(ID);
            return byPk == null ? (IActionResult)this.BadRequest((object)new
            {
                message = "Error al obtener los datos"
            }) : (IActionResult)this.Ok((object)byPk);
        }

        [HttpGet]
        public IActionResult getDatosIniciador(int ID)
        {
            Tramite byPk = this._TramiteService.getByPk(ID);
            return byPk == null ? (IActionResult)this.BadRequest((object)new
            {
                message = "Error al obtener los datos"
            }) : (IActionResult)this.Ok((object)byPk);
        }

        [HttpPost]
        public IActionResult insert(Tramite obj)
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
        public IActionResult update(Tramite obj)
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
        public IActionResult activaDesactiva(Tramite obj)
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
    }
}
