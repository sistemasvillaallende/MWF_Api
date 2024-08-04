using MOTOR_WORKFLOW.Models;

namespace MOTOR_WORKFLOW.Services
{
    public class ValidacionesServices : IValidacionesServices
    {
        public ValidaInmuebleModel getByDenominacion(int circunscripcion, int seccion, int manzana, int parcela, int p_h)
        {
            try
            {
                return Entities.ValidaInmueble.getByPk(circunscripcion, seccion, manzana, parcela, p_h);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
