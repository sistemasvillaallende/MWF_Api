// Decompiled with JetBrains decompiler
// Type: MOTOR_WORKFLOW.Controllers.CallesController
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
  public class CallesController : Controller
  {
    private ICallesService _CallesService;

    public CallesController(ICallesService CallesService) => this._CallesService = CallesService;

    [HttpGet]
    public IActionResult getByPk(int COD_CALLE)
    {
      Calles byPk = this._CallesService.getByPk(COD_CALLE);
      return byPk == null ? (IActionResult) this.BadRequest( new
      {
        message = "Error al obtener los datos"
      }) : (IActionResult) this.Ok( byPk);
    }

    [HttpGet]
    public IActionResult read()
    {
      List<Combo> comboList = this._CallesService.read();
      return comboList == null ? (IActionResult) this.BadRequest( new
      {
        message = "Error al obtener los datos"
      }) : (IActionResult) this.Ok( comboList);
    }
  }
}
