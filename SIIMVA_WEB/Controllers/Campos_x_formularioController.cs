// Decompiled with JetBrains decompiler
// Type: MOTOR_WORKFLOW.Controllers.Campos_x_formularioController
// Assembly: MOTOR_WORKFLOW, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 007B8F5F-49BB-4EE7-8464-22FD2F567A18
// Assembly location: C:\Muni\DEV\WebApiMWF\MOTOR_WORKFLOW.dll

using Microsoft.AspNetCore.Mvc;
using MOTOR_WORKFLOW.Entities;
using MOTOR_WORKFLOW.Services;
using System;

#nullable enable
namespace MOTOR_WORKFLOW.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class Campos_x_formularioController : Controller
    {
        private ICampos_x_formularioService _Campos_x_formularioService;

        public Campos_x_formularioController(
          ICampos_x_formularioService Campos_x_formularioService)
        {
            this._Campos_x_formularioService = Campos_x_formularioService;
        }

        [HttpGet]
        public IActionResult getByPk(int ID)
        {
            campos_x_formulario byPk = this._Campos_x_formularioService.getByPk(ID);
            return byPk == null ? (IActionResult)this.BadRequest(new
            {
                message = "Error al obtener los datos"
            }) : (IActionResult)this.Ok(byPk);
        }

        [HttpPost]
        public IActionResult insert(Entities.CampoTextoModel obj)
        {
            try
            {
                this._Campos_x_formularioService.insert(obj);
                return (IActionResult)this.Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpPost]
        public IActionResult insertEnlazados(List<Entities.CampoTextoModel> lst)
        {
            try
            {
                this._Campos_x_formularioService.insertEnlazados(lst);
                return (IActionResult)this.Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpPost]
        public IActionResult update(CampoTextoModel obj)
        {
            try
            {
                this._Campos_x_formularioService.update(obj);
                return (IActionResult)this.Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        public IActionResult delete(int id)
        {
            try
            {
                this._Campos_x_formularioService.delete(id);
                return (IActionResult)this.Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
