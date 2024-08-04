using MOTOR_WORKFLOW.Models;

namespace MOTOR_WORKFLOW.Services
{
    public interface IValidacionesServices
    {
        public ValidaInmuebleModel getByDenominacion(int circunscripcion, int seccion,
            int manzana, int parcela, int p_h);

    }
}
