using MOTOR_WORKFLOW.Entities;

namespace MOTOR_WORKFLOW.Services
{
    public interface IVecinoDigitalServices
    {
        public VecinoDigital getByCuit(string cuit);
    }
}
