using EjemploCiDi.Models;

namespace MOTOR_WORKFLOW.Services
{
    public interface ICIDIServices
    {
        public Usuario getbyCuit(string cuit, string hash);
    }
}
