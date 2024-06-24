// Decompiled with JetBrains decompiler
// Type: MOTOR_WORKFLOW.Controllers.TramitesController
// Assembly: MOTOR_WORKFLOW, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 007B8F5F-49BB-4EE7-8464-22FD2F567A18
// Assembly location: C:\Muni\DEV\WebApiMWF\MOTOR_WORKFLOW.dll

using Microsoft.AspNetCore.Mvc;
using MOTOR_WORKFLOW.Entities;
using MOTOR_WORKFLOW.Services;
using System.Collections.Generic;

#nullable enable
namespace MOTOR_WORKFLOW.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class TramitesController : Controller
    {
        private ITramitesService _TramitesService;

        public TramitesController(ITramitesService TramitesService)
        {
            this._TramitesService = TramitesService;
        }

        [HttpGet]
        public IActionResult getByPk(int id)
        {
            Tramites byPk = this._TramitesService.getByPk(id);
            return byPk == null ? (IActionResult)this.BadRequest((object)new
            {
                message = "Error al obtener los datos"
            }) : (IActionResult)this.Ok((object)byPk);
        }

        [HttpGet]
        public IActionResult getByPkSimple(int id)
        {
            Tramites byPkSimple = this._TramitesService.getByPkSimple(id);
            return byPkSimple == null ? (IActionResult)this.BadRequest((object)new
            {
                message = "Error al obtener los datos"
            }) : (IActionResult)this.Ok((object)byPkSimple);
        }

        [HttpGet]
        public IActionResult getResultados(int id)
        {
            List<ResultadoTramites> resultados = this._TramitesService.getResultados(id);
            return resultados == null ? (IActionResult)this.BadRequest((object)new
            {
                message = "Error al obtener los datos"
            }) : (IActionResult)this.Ok((object)resultados);
        }

        [HttpGet]
        public IActionResult read(string cuit)
        {
            List<Tramites> tramitesList = this._TramitesService.read(cuit);
            return tramitesList == null ? (IActionResult)this.BadRequest((object)new
            {
                message = "Error al obtener los datos"
            }) : (IActionResult)this.Ok((object)tramitesList);
        }

        [HttpGet]
        public IActionResult readAdministrador()
        {
            List<Tramites> tramitesList = this._TramitesService.read();
            return tramitesList == null ? (IActionResult)this.BadRequest((object)new
            {
                message = "Error al obtener los datos"
            }) : (IActionResult)this.Ok((object)tramitesList);
        }

        [HttpGet]
        public IActionResult readOficinas(int id_oficina)
        {
            List<Tramites> tramitesList = this._TramitesService.readOficina(id_oficina);
            return tramitesList == null ? (IActionResult)this.BadRequest((object)new
            {
                message = "Error al obtener los datos"
            }) : (IActionResult)this.Ok((object)tramitesList);
        }

        [HttpGet]
        public IActionResult recibir(
          int id_tramite,
          int paso_actual,
          int id_tramites,
          int cod_usuario)
        {
            return (IActionResult)this.Ok((object)this._TramitesService.recibir(id_tramite, paso_actual, id_tramites, cod_usuario));
        }
    }
}
