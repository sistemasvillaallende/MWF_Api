// Decompiled with JetBrains decompiler
// Type: MOTOR_WORKFLOW.Controllers.Ws_headers_parametersController
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
  public class Ws_headers_parametersController : Controller
  {
    private IWs_headers_parametersService _Ws_headers_parametersService;

    public Ws_headers_parametersController(
      IWs_headers_parametersService Ws_headers_parametersService)
    {
      this._Ws_headers_parametersService = Ws_headers_parametersService;
    }

    [HttpGet]
    public IActionResult getByPk(int ID)
    {
      Ws_headers_parameters byPk = this._Ws_headers_parametersService.getByPk(ID);
      return byPk == null ? (IActionResult) this.BadRequest( new
      {
        message = "Error al obtener los datos"
      }) : (IActionResult) this.Ok( byPk);
    }
  }
}
