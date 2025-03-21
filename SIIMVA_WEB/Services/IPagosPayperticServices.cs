using MOTOR_WORKFLOW.Entities;

namespace MOTOR_WORKFLOW.Services
{
    public interface IPagosPayperticServices
    {
        public List<PAGOS_PAYPERTIC> read();
        public List<PAGOS_PAYPERTIC> readcuit(string cuit, string dni);
        public PAGOS_PAYPERTIC getByPk(Int64 NRO_CEDULON);
        public int insert(PAGOS_PAYPERTIC obj);
        public void update(PAGOS_PAYPERTIC obj);
        public void delete(PAGOS_PAYPERTIC obj);
    }
}
