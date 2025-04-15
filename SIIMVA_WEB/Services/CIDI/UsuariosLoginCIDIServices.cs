using MOTOR_WORKFLOW.Entities.LOGIN;

namespace MOTOR_WORKFLOW.Services.CIDI
{
    public class UsuariosLoginCIDIServices : IUsuariosLoginCIDIServices
    {

        public UsuarioLoginCIDI getByCuit(string cuit)
        {
            try
            {
                return UsuarioLoginCIDI.getByCuit(cuit);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
