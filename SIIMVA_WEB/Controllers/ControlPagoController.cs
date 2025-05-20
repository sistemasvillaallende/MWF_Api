
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MOTOR_WORKFLOW.Entities;
using MOTOR_WORKFLOW.Services;
using System.Collections.Generic;

namespace MOTOR_WORKFLOW.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ControlPagoController : Controller
    {
        private IControlPagoServices _ControlPagoServices;
        public ControlPagoController(IControlPagoServices ControlPagoServices)
        {
            this._ControlPagoServices = ControlPagoServices;
        }
        [Authorize]
        [HttpGet]
        public IActionResult getByPk(int nro_transaccion)
        {
            ControlPago obj = this._ControlPagoServices.getByPk(nro_transaccion);
            return obj == null ? (IActionResult)this.BadRequest(new
            {
                message = "Error al obtener los datos"
            }) : (IActionResult)this.Ok(obj);
        }
    }
}
