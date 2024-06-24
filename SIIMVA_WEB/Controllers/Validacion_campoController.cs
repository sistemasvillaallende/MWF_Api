// Decompiled with JetBrains decompiler
// Type: MOTOR_WORKFLOW.Controllers.Validacion_campoController
// Assembly: MOTOR_WORKFLOW, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 007B8F5F-49BB-4EE7-8464-22FD2F567A18
// Assembly location: C:\Muni\DEV\WebApiMWF\MOTOR_WORKFLOW.dll

using Microsoft.AspNetCore.Mvc;
using MOTOR_WORKFLOW.Entities;
using MOTOR_WORKFLOW.Services;

#nullable enable
namespace MOTOR_WORKFLOW.Controllers
{
  [ApiController]
  [Route("[controller]/[action]")]
  public class Validacion_campoController : Controller
  {
    private IValidacion_campoService _Validacion_campoService;

    public Validacion_campoController(IValidacion_campoService Validacion_campoService)
    {
      this._Validacion_campoService = Validacion_campoService;
    }

    [HttpGet]
    public IActionResult getByPk(int ID)
    {
      Validacion_campo byPk = this._Validacion_campoService.getByPk(ID);
      return byPk == null ? (IActionResult) this.BadRequest((object) new
      {
        message = "Error al obtener los datos"
      }) : (IActionResult) this.Ok((object) byPk);
    }
  }
}
