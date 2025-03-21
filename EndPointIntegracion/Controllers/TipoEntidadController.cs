using EndPointIntegracion.Services;
using Microsoft.AspNetCore.Mvc;

namespace EndPointIntegracion.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class TipoEntidadController : Controller
    {
        private ITipoEntidadService _itipoentidadservice;
        public TipoEntidadController(ITipoEntidadService itipoentidadservice)
        {
            _itipoentidadservice = itipoentidadservice;
        }
        [HttpGet]
        public IActionResult Tipos_entidad()
        {
            var entidad = _itipoentidadservice.Tipos_entidad();
            if (entidad == null)
            {
                return BadRequest(new { message = "No se encontraron datos" });
            }
            return Ok(entidad);
        }
    }
}
