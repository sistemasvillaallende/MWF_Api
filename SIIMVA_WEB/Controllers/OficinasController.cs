// Decompiled with JetBrains decompiler
// Type: MOTOR_WORKFLOW.Controllers.OficinasController
// Assembly: MOTOR_WORKFLOW, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 007B8F5F-49BB-4EE7-8464-22FD2F567A18
// Assembly location: C:\Muni\DEV\WebApiMWF\MOTOR_WORKFLOW.dll

using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using MOTOR_WORKFLOW.Entities;
using MOTOR_WORKFLOW.Services;
using System.Collections.Generic;

#nullable enable
namespace MOTOR_WORKFLOW.Controllers
{
  [ApiController]
  [Route("[controller]/[action]")]
  public class OficinasController : ControllerBase
  {
    private readonly IWebHostEnvironment _HostEnvironment;
    private IOficinasService _OficinaService;

    public OficinasController(IOficinasService OficinaService)
    {
      this._OficinaService = OficinaService;
    }

    [HttpGet]
    public IActionResult read()
    {
      List<Oficinas> oficinasList = this._OficinaService.read();
      return oficinasList == null ? (IActionResult) this.BadRequest( new
      {
        message = "Error al obtener los datos"
      }) : (IActionResult) this.Ok( oficinasList);
    }
  }
}
