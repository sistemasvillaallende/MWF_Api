using Microsoft.AspNetCore.Mvc;
using MOTOR_WORKFLOW.Entities;
using MOTOR_WORKFLOW.Services;

namespace MOTOR_WORKFLOW.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ValidacionesController : Controller
    {
        private IValidacionesServices _ValidacionesService;

        public ValidacionesController(IValidacionesServices ValidacionesService) => this._ValidacionesService = ValidacionesService;

        [HttpGet]
        public IActionResult getByPk(int circunscripcion, int seccion, int manzana, int parcela, int p_h)
        {
            Models.ValidaInmuebleModel byPk = this._ValidacionesService.getByDenominacion(circunscripcion,
                seccion, manzana, parcela, p_h);
            return byPk == null ? (IActionResult)this.BadRequest(new
            {
                message = "Error al obtener los datos"
            }) : (IActionResult)this.Ok(byPk);
        }
    }
}
