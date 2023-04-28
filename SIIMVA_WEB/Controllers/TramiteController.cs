using Microsoft.AspNetCore.Mvc;
using Newtonsoft;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;
using Newtonsoft.Json;
using MOTOR_WORKFLOW.Services;

namespace MOTOR_WORKFLOW.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class TramiteController : Controller
    {
        private ITramiteService _TramiteService;
        public TramiteController(ITramiteService TramiteService)
        {
            _TramiteService = TramiteService;
        }
        [HttpGet]
        public IActionResult getByPk(
        int ID)
        {
            var Tramite = _TramiteService.getByPk(ID);
            if (Tramite == null)
            {
                return BadRequest(new { message = "Error al obtener los datos" });
            }
            return Ok(Tramite);
        }
        [HttpGet]
        public IActionResult IniciaTramite(
        int ID)
        {
            var Tramite = _TramiteService.getByPk(ID);
            if (Tramite == null)
            {
                return BadRequest(new { message = "Error al obtener los datos" });
            }
            return Ok(Tramite);
        }
        [HttpGet]
        public IActionResult getDatosIniciador(
        int ID)
        {
            var Tramite = _TramiteService.getByPk(ID);
            if (Tramite == null)
            {
                return BadRequest(new { message = "Error al obtener los datos" });
            }
            return Ok(Tramite);
        }





    }
}

