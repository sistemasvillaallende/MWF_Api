using MOTOR_WORKFLOW.Entities;

namespace MOTOR_WORKFLOW.Services
{
    public interface IInmuebles_rentasServices
    {
        public Inmuebles_rentas getByPk(double nro_cta);
        public Inmuebles_rentas getByCoordenadas(decimal lat, decimal lon);

    }
}
