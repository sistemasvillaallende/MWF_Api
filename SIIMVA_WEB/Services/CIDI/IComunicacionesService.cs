using MOTOR_WORKFLOW.Entities.CIDI.Comunicacion;

namespace MOTOR_WORKFLOW.Services.CIDI
{
    public interface IComunicacionesService
    {
        public ResultadoEmail enviarNotificacionCUIT(string CUIT, Email email);
    }
}
