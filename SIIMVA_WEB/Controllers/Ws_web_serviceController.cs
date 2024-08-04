// Decompiled with JetBrains decompiler
// Type: MOTOR_WORKFLOW.Controllers.Ws_web_serviceController
// Assembly: MOTOR_WORKFLOW, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 007B8F5F-49BB-4EE7-8464-22FD2F567A18
// Assembly location: C:\Muni\DEV\WebApiMWF\MOTOR_WORKFLOW.dll

using Microsoft.AspNetCore.Mvc;
using MOTOR_WORKFLOW.Entities;
using MOTOR_WORKFLOW.Services;
using System;
using System.Collections.Generic;

#nullable enable
namespace MOTOR_WORKFLOW.Controllers
{
  [ApiController]
  [Route("[controller]/[action]")]
  public class Ws_web_serviceController : Controller
  {
    private IWs_web_serviceService _Ws_web_serviceService;

    public Ws_web_serviceController(IWs_web_serviceService Ws_web_serviceService)
    {
      this._Ws_web_serviceService = Ws_web_serviceService;
    }

    [HttpGet]
    public IActionResult read(int ID)
    {
      List<Ws_web_service> wsWebServiceList = this._Ws_web_serviceService.read();
      return wsWebServiceList == null ? (IActionResult) this.BadRequest( new
      {
        message = "Error al obtener los datos"
      }) : (IActionResult) this.Ok( wsWebServiceList);
    }

    [HttpPost]
    public IActionResult insert(Ws_web_service obj)
    {
      try
      {
        this._Ws_web_serviceService.insert(obj);
        return (IActionResult) this.Ok();
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    [HttpPost]
    public IActionResult update(Ws_web_service obj)
    {
      try
      {
        this._Ws_web_serviceService.update(obj);
        return (IActionResult) this.Ok();
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }
  }
}
