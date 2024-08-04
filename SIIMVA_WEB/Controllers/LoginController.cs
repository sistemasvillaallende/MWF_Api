// Decompiled with JetBrains decompiler
// Type: MOTOR_WORKFLOW.Controllers.LoginController
// Assembly: MOTOR_WORKFLOW, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 007B8F5F-49BB-4EE7-8464-22FD2F567A18
// Assembly location: C:\Muni\DEV\WebApiMWF\MOTOR_WORKFLOW.dll

using Microsoft.AspNetCore.Mvc;
using MOTOR_WORKFLOW.Services.LOGIN;

#nullable enable
namespace MOTOR_WORKFLOW.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class LoginController : ControllerBase
    {
        private readonly IUsuarioConOficina _iusuarioConOficinaService;

        public LoginController(IUsuarioConOficina iusuarioConOficinaService)
        {
            this._iusuarioConOficinaService = iusuarioConOficinaService;
        }

        [HttpGet]
        public IActionResult ValidaUsuarioConOficina(string user, string password)
        {
            return (IActionResult)this.Ok(this._iusuarioConOficinaService.ValidUser(user, password));
        }

        [HttpGet]
        public IActionResult ValidaPermisoConOficina(string user, string proceso)
        {
            return (IActionResult)this.Ok(this._iusuarioConOficinaService.ValidaPermiso(user, proceso));
        }
    }
}
