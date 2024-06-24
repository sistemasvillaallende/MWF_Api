// Decompiled with JetBrains decompiler
// Type: MOTOR_WORKFLOW.Controllers.Ingresos_x_pasoController
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
  public class Ingresos_x_pasoController : Controller
  {
    private IIngresos_x_pasoService _Ingresos_x_pasoService;

    public Ingresos_x_pasoController(IIngresos_x_pasoService Ingresos_x_pasoService)
    {
      this._Ingresos_x_pasoService = Ingresos_x_pasoService;
    }

    [HttpGet]
    public IActionResult getByPk(int ID)
    {
      ingresos_x_paso byPk = this._Ingresos_x_pasoService.getByPk(ID);
      return byPk == null ? (IActionResult) this.BadRequest((object) new
      {
        message = "Error al obtener los datos"
      }) : (IActionResult) this.Ok((object) byPk);
    }

    [HttpGet]
    public IActionResult read(int idPaso)
    {
      List<ingresos_x_paso> ingresosXPasoList = this._Ingresos_x_pasoService.read(idPaso);
      return ingresosXPasoList == null ? (IActionResult) this.BadRequest((object) new
      {
        message = "Error al obtener los datos"
      }) : (IActionResult) this.Ok((object) ingresosXPasoList);
    }

    [HttpPost]
    public IActionResult insert(ingreso_paso_model obj)
    {
      try
      {
        this._Ingresos_x_pasoService.insert(obj);
        return (IActionResult) this.Ok();
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    [HttpPost]
    public IActionResult update(ingreso_paso_model obj)
    {
      try
      {
        this._Ingresos_x_pasoService.update(obj);
        return (IActionResult) this.Ok();
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }
  }
}
