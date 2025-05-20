using EjemploCiDi.Models;
using EndPointIntegracion;
using Microsoft.AspNetCore.Mvc;
using MOTOR_WORKFLOW.Entities;
using MOTOR_WORKFLOW.Services;
using MOTOR_WORKFLOW.Services.JWT;
using System.Data.SqlClient;
using Newtonsoft.Json;


namespace MOTOR_WORKFLOW.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class CIDIController : Controller
    {
        private ICIDIServices _CIDIServices;
        private readonly JwtTokenService _jwtTokenService;

        public CIDIController(ICIDIServices CIDIServices, JwtTokenService jwtTokenService)
        {
            this._CIDIServices = CIDIServices;
            this._jwtTokenService = jwtTokenService;
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

            if (usuario.Respuesta.Resultado != Config.CiDi_OK)
            {
                return BadRequest(new
                {
                    message = "Error al obtener los datos"
                });
            }
            // Generar el JWT para el usuario
            var token = _jwtTokenService.GenerateToken(usuario.CUIL);

            // Retornar el usuario y el token JWT
            return Ok(new { Usuario = usuario, Token = token });


        }
    }
}
