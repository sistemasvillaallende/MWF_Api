// Decompiled with JetBrains decompiler
// Type: MOTOR_WORKFLOW.Controllers.DdjjController
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
  public class DdjjController : Controller
  {
    private IDdjjService _DdjjService;

    public DdjjController(IDdjjService DdjjService) => this._DdjjService = DdjjService;
    [Authorize]
    [HttpGet]
    public IActionResult getByPk(int ID)
    {
      ddjj byPk = this._DdjjService.getByPk(ID);
      return byPk == null ? (IActionResult) this.BadRequest( new
      {
        message = "Error al obtener los datos"
      }) : (IActionResult) this.Ok( byPk);
    }
  }
}
