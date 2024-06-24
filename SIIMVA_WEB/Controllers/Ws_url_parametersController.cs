// Decompiled with JetBrains decompiler
// Type: MOTOR_WORKFLOW.Controllers.Ws_url_parametersController
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
  public class Ws_url_parametersController : Controller
  {
    private IWs_url_parametersService _Ws_url_parametersService;

    public Ws_url_parametersController(IWs_url_parametersService Ws_url_parametersService)
    {
      this._Ws_url_parametersService = Ws_url_parametersService;
    }

    [HttpGet]
    public IActionResult getByPk(int ID)
    {
      Ws_url_parameters byPk = this._Ws_url_parametersService.getByPk(ID);
      return byPk == null ? (IActionResult) this.BadRequest((object) new
      {
        message = "Error al obtener los datos"
      }) : (IActionResult) this.Ok((object) byPk);
    }
  }
}
