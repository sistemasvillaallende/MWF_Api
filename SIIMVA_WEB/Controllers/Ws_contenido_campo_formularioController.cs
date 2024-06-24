// Decompiled with JetBrains decompiler
// Type: MOTOR_WORKFLOW.Controllers.Ws_contenido_campo_formularioController
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
  public class Ws_contenido_campo_formularioController : Controller
  {
    private IWs_contenido_campo_formularioService _Ws_contenido_campo_formularioService;

    public Ws_contenido_campo_formularioController(
      IWs_contenido_campo_formularioService Ws_contenido_campo_formularioService)
    {
      this._Ws_contenido_campo_formularioService = Ws_contenido_campo_formularioService;
    }

    [HttpGet]
    public IActionResult getByPk()
    {
      Ws_contenido_campo_formulario byPk = this._Ws_contenido_campo_formularioService.getByPk();
      return byPk == null ? (IActionResult) this.BadRequest((object) new
      {
        message = "Error al obtener los datos"
      }) : (IActionResult) this.Ok((object) byPk);
    }
  }
}
