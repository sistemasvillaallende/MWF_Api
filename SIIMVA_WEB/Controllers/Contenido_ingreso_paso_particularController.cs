using Microsoft.AspNetCore.Mvc;
using Newtonsoft;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;
using Newtonsoft.Json;
using MOTOR_WORKFLOW.Services;
using MOTOR_WORKFLOW.Entities;

namespace MOTOR_WORKFLOW.Controllers.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class Contenido_ingreso_paso_particularController : Controller
    {
        private IContenido_ingreso_paso_particularService _Contenido_ingreso_paso_particularService;
        public Contenido_ingreso_paso_particularController(IContenido_ingreso_paso_particularService Contenido_ingreso_paso_particularService)
        {
            _Contenido_ingreso_paso_particularService = Contenido_ingreso_paso_particularService;
        }
        [HttpGet]
        public IActionResult getByPk(
        int ID)
        {
            var Contenido_ingreso_paso_particular = _Contenido_ingreso_paso_particularService.getByPk(ID);
            if (Contenido_ingreso_paso_particular == null)
            {
                return BadRequest(new { message = "Error al obtener los datos" });
            }
            return Ok(Contenido_ingreso_paso_particular);
        }


        [HttpPost]
        public IActionResult insert(Contenido_ingreso_paso_particular obj)
        {
            try
            {
                this._Contenido_ingreso_paso_particularService.insert(obj);

                return (IActionResult)this.Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




    }
}

