﻿// Decompiled with JetBrains decompiler
// Type: MOTOR_WORKFLOW.Controllers.Ingresos_x_pasoController
// Assembly: MOTOR_WORKFLOW, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 007B8F5F-49BB-4EE7-8464-22FD2F567A18
// Assembly location: C:\Muni\DEV\WebApiMWF\MOTOR_WORKFLOW.dll

using Microsoft.AspNetCore.Authorization;
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
    public class Ingresos_x_pasoController : Controller
    {
        private IIngresos_x_pasoService _Ingresos_x_pasoService;

        public Ingresos_x_pasoController(IIngresos_x_pasoService Ingresos_x_pasoService)
        {
            this._Ingresos_x_pasoService = Ingresos_x_pasoService;
        }
        [Authorize]
        [HttpGet]
        public IActionResult getByPk(int ID)
        {
            ingresos_x_paso byPk = this._Ingresos_x_pasoService.getByPk(ID);
            return byPk == null ? (IActionResult)this.BadRequest(new
            {
                message = "Error al obtener los datos"
            }) : (IActionResult)this.Ok(byPk);
        }
        [Authorize]
        [HttpGet]
        public IActionResult read(int idPaso)
        {
            List<ingresos_x_paso> ingresosXPasoList = this._Ingresos_x_pasoService.read(idPaso);
            return ingresosXPasoList == null ? (IActionResult)this.BadRequest(new
            {
                message = "Error al obtener los datos"
            }) : (IActionResult)this.Ok(ingresosXPasoList);
        }
        [Authorize]
        [HttpPost]
        public IActionResult insert(ingreso_paso_model obj)
        {
            try
            {
                this._Ingresos_x_pasoService.insert(obj);
                return (IActionResult)this.Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [Authorize]
        [HttpPost]
        public IActionResult update(ingreso_paso_model obj)
        {
            try
            {
                this._Ingresos_x_pasoService.update(obj);
                return (IActionResult)this.Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [Authorize]
        [HttpGet]
        public IActionResult insertValidaForm(int id_paso)
        {
            try
            {
                this._Ingresos_x_pasoService.insertValidaForm(id_paso);
                return (IActionResult)this.Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [Authorize]
        [HttpGet]
        public IActionResult insertValidaPersona(int id_paso)
        {
            try
            {
                this._Ingresos_x_pasoService.insertValidaPersona(id_paso);
                return (IActionResult)this.Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [Authorize]
        [HttpGet]
        public IActionResult insertMultiNota(int id_paso)
        {
            try
            {
                this._Ingresos_x_pasoService.insertMultinota(id_paso);
                return (IActionResult)this.Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [Authorize]
        [HttpGet]
        public IActionResult delete(string id_paso)
        {
            try
            {
                this._Ingresos_x_pasoService.delete(id_paso);
                return (IActionResult)this.Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
