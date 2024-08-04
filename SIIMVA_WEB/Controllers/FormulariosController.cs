// Decompiled with JetBrains decompiler
// Type: MOTOR_WORKFLOW.Controllers.FormulariosController
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
  public class FormulariosController : Controller
  {
    private IFormulariosService _FormulariosService;

    public FormulariosController(IFormulariosService FormulariosService)
    {
      this._FormulariosService = FormulariosService;
    }

    [HttpGet]
    public IActionResult getByPk(int id)
    {
      Formularios byPk = this._FormulariosService.getByPk(id);
      return byPk == null ? (IActionResult) this.BadRequest( new
      {
        message = "Error al obtener los datos"
      }) : (IActionResult) this.Ok( byPk);
    }
  }
}
