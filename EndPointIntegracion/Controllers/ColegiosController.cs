using EndPointIntegracion.Services;
using Microsoft.AspNetCore.Mvc;

namespace EndPointIntegracion.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ColegiosController : Controller
    {
        private IColegiosServices _ColeioServices;

        public ColegiosController(IColegiosServices ColegioServices)
        {
            this._ColeioServices = ColegioServices;
        }
        [HttpGet]
        public IActionResult read()
        {
            var lst = _ColeioServices.read();

            return Ok(lst);
        }
    }
}
