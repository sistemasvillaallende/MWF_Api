using EndPointIntegracion.Services;
using Microsoft.AspNetCore.Mvc;

namespace EndPointIntegracion.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class UtilsController : Controller
    {
        private IUtilService _IUtilService;
        public UtilsController(IUtilService IUtilService)
        {
            _IUtilService = IUtilService;
        }
        [HttpGet]
        public IActionResult read()
        {
            var Combo = _IUtilService.getComboSiNo();
            if (Combo == null)
            {
                return BadRequest(new { message = "Error al obtener los datos" });
            }
            return Ok(Combo);
        }
    }
}
