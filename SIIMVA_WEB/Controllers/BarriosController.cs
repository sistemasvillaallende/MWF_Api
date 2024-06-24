// Decompiled with JetBrains decompiler
// Type: MOTOR_WORKFLOW.Controllers.BarriosController
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
  public class BarriosController : Controller
  {
    private IBarriosService _BarriosService;

    public BarriosController(IBarriosService BarriosService)
    {
      this._BarriosService = BarriosService;
    }

    [HttpGet]
    public IActionResult getByPk()
    {
      List<Combo> comboList = this._BarriosService.read();
      return comboList == null ? (IActionResult) this.BadRequest((object) new
      {
        message = "Error al obtener los datos"
      }) : (IActionResult) this.Ok((object) comboList);
    }

    [HttpGet]
    public IActionResult read()
    {
      List<Combo> comboList = this._BarriosService.read();
      return comboList == null ? (IActionResult) this.BadRequest((object) new
      {
        message = "Error al obtener los datos"
      }) : (IActionResult) this.Ok((object) comboList);
    }
  }
}
