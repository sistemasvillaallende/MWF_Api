using MOTOR_WORKFLOW.Entities.CIDI.Comunicacion;

namespace MOTOR_WORKFLOW.Services.CIDI
{
    public class ComunicacionesService : IComunicacionesService
    {
        public ResultadoEmail enviarNotificacionCUIT(string CUIT, Email email)
        {
            try
            {
                return Config.LlamarWebAPI<Email, ResultadoEmail>
                (APIComunicacion.Email.Enviar, email);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
