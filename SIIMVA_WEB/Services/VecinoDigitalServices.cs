using MOTOR_WORKFLOW.Entities;

namespace MOTOR_WORKFLOW.Services
{
    public class VecinoDigitalServices:IVecinoDigitalServices
    {
        public VecinoDigital getByCuit(string cuit)
        {
			try
			{
				return Entities.VecinoDigital.getByPk(cuit);
			}
			catch (Exception ex)
			{
				throw ex;
			}
        }
    }
}
