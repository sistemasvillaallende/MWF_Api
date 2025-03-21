using EjemploCiDi.Models;
using EndPointIntegracion;
using Microsoft.AspNetCore.Mvc;
using MOTOR_WORKFLOW.Entities;
using MOTOR_WORKFLOW.Services;
using System.Data.SqlClient;


namespace MOTOR_WORKFLOW.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class CIDIController : Controller
    {
        private ICIDIServices _CIDIServices;

        public CIDIController(ICIDIServices CIDIServices)
        {
            this._CIDIServices = CIDIServices;
        }
        [HttpGet]
        public IActionResult getByPk(string cuit, string hash)
        {
            Entrada entrada = new Entrada();
            entrada.IdAplicacion = Config.CiDiIdAplicacion;
            entrada.Contrasenia = Config.CiDiPassAplicacion;
            entrada.CUIL = cuit;
            entrada.HashCookie = hash;
            entrada.TimeStamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");
            entrada.TokenValue = Config.ObtenerToken_SHA1(entrada.TimeStamp);

            EjemploCiDi.Models.Usuario usuario = Config.LlamarWebAPI<Entrada,
                EjemploCiDi.Models.Usuario>(APICuenta.Usuario.Obtener_Usuario, entrada);


            return usuario.Respuesta.Resultado != Config.CiDi_OK ?
                BadRequest(new
                {
                    message = "Error al obtener los datos"
                }) : Ok(usuario);


        }
    }
}
