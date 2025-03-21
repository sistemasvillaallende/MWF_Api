using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;
using MOTOR_WORKFLOW.Entities;
using MOTOR_WORKFLOW.Services;
using System.Collections.Generic;

namespace MOTOR_WORKFLOW.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class VecinoDigitalController : Controller
    {
        private IVecinoDigitalServices _VecinoDigitalService;

        public VecinoDigitalController(IVecinoDigitalServices VecinoDigitalService)
        {
            this._VecinoDigitalService = VecinoDigitalService;
        }

        [HttpGet]
        public IActionResult getByPk(string cuit)
        {
            VecinoDigital vecino = this._VecinoDigitalService.getByCuit(cuit);
            return vecino == null ? (IActionResult)this.BadRequest(new
            {
                message = "Error al obtener los datos"
            }) : (IActionResult)this.Ok(vecino);
        }
    }
}
