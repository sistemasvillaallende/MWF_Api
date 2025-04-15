using MOTOR_WORKFLOW.Entities.LOGIN;

namespace MOTOR_WORKFLOW.Services.CIDI
{
    public interface IUsuariosLoginCIDIServices
    {
        public UsuarioLoginCIDI getByCuit(string cuit);
    }
}
