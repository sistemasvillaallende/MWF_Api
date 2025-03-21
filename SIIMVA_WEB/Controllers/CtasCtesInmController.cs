using Microsoft.AspNetCore.Mvc;
using MOTOR_WORKFLOW.Services;
using System.Text.RegularExpressions;
using MOTOR_WORKFLOW.Entities;
using MOTOR_WORKFLOW.Models;

namespace MOTOR_WORKFLOW.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class CtasCtesInmController : Controller
    {
        private ICtasCtesInmServices _Ctasctes_inmueblesServices;

        public CtasCtesInmController(ICtasCtesInmServices CtasCtesInmService) => this._Ctasctes_inmueblesServices = CtasCtesInmService;

        [HttpPost]
        public IActionResult NuevaDeuda(CtasCtes_Con_Auditoria obj, string estado)
        {
            var objCta = obj.lstCtastes[0];

            _Ctasctes_inmueblesServices.NuevaDeuda(obj, estado);
            return Ok(new { message = "Se genero nueva deuda" });

        }
    }
}
