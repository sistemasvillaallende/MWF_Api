using MOTOR_WORKFLOW.Entities;

namespace MOTOR_WORKFLOW.Services
{
    public class ControlPagoServices : IControlPagoServices
    {
        public ControlPago getByPk(int nro_transaccion)
        {
			try
			{
				return Entities.ControlPago.getByPk(nro_transaccion);	
			}
			catch (Exception ex)
			{
				throw ex;
			}
        }
    }
}
