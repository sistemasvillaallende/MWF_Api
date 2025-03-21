using MOTOR_WORKFLOW.Entities;

namespace MOTOR_WORKFLOW.Services
{
    public class Inmuebles_rentasServices : IInmuebles_rentasServices
    {
        public Inmuebles_rentas getByPk(double nro_cta)
        {
			try
			{
				return Entities.Inmuebles_rentas.getByPk(nro_cta);
			}
			catch (Exception ex)
			{
				throw ex;
			}
        }
        public Inmuebles_rentas getByCoordenadas(decimal lat, decimal lng)
        {
            try
            {
                return Entities.Inmuebles_rentas.getByCoordenadas(lat, lng);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
