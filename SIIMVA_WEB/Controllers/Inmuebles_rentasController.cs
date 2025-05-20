using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MOTOR_WORKFLOW.Entities;
using MOTOR_WORKFLOW.Services;

#nullable enable
namespace MOTOR_WORKFLOW.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class Inmuebles_rentasController : Controller
    {
        private IInmuebles_rentasServices _Inmuebles_rentasServices;

        public Inmuebles_rentasController(IInmuebles_rentasServices Inmuebles_rentasServices) => this._Inmuebles_rentasServices = Inmuebles_rentasServices;
        [Authorize]
        [HttpGet]
        public IActionResult getByPk(double nro_cta)
        {
            Entities.Inmuebles_rentas byPk = this._Inmuebles_rentasServices.getByPk(nro_cta);
            return byPk == null ? (IActionResult)this.BadRequest(new
            {
                message = "Error al obtener los datos"
            }) : (IActionResult)this.Ok(byPk);
        }
        [Authorize]
        [HttpGet]
        public IActionResult getByCoordenadas(decimal lat, decimal lng)
        {
            Entities.Inmuebles_rentas byPk = this._Inmuebles_rentasServices.getByCoordenadas(lat, lng);
            return byPk == null ? (IActionResult)this.BadRequest(new
            {
                message = "Error al obtener los datos"
            }) : (IActionResult)this.Ok(byPk);
        }
    }
}
