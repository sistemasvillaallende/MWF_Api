// Decompiled with JetBrains decompiler
// Type: MOTOR_WORKFLOW.Controllers.Tipo_campoController
// Assembly: MOTOR_WORKFLOW, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 007B8F5F-49BB-4EE7-8464-22FD2F567A18
// Assembly location: C:\Muni\DEV\WebApiMWF\MOTOR_WORKFLOW.dll

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MOTOR_WORKFLOW.Entities;
using MOTOR_WORKFLOW.Services;

#nullable enable
namespace MOTOR_WORKFLOW.Controllers
{
  [ApiController]
  [Route("[controller]/[action]")]
  public class Tipo_campoController : Controller
  {
    private ITipo_campoService _Tipo_campoService;

    public Tipo_campoController(ITipo_campoService Tipo_campoService)
    {
      this._Tipo_campoService = Tipo_campoService;
    }
        [Authorize]
        [HttpGet]
    public IActionResult getByPk(int ID)
    {
      Tipo_campo byPk = this._Tipo_campoService.getByPk(ID);
      return byPk == null ? (IActionResult) this.BadRequest( new
      {
        message = "Error al obtener los datos"
      }) : Ok( byPk);
    }
  }
}
