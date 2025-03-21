using Microsoft.AspNetCore.Mvc;
using MOTOR_WORKFLOW.Entities;
using MOTOR_WORKFLOW.Services;

namespace MOTOR_WORKFLOW.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class PagosPayperTicController : Controller
    {
        private IPagosPayperticServices _PagosPayperticServices;

        public PagosPayperTicController(IPagosPayperticServices PagosPayperticServices)
        {
            this._PagosPayperticServices = PagosPayperticServices;
        }
        [HttpGet]
        public IActionResult getByPk(Int64 nro_cedulon)
        {
            PAGOS_PAYPERTIC obj = this._PagosPayperticServices.getByPk(nro_cedulon);
            return obj == null ? (IActionResult)this.BadRequest(new
            {
                message = "Error al obtener los datos"
            }) : (IActionResult)this.Ok(obj);
        }
    }
}
