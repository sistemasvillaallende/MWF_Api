using MOTOR_WORKFLOW.Entities;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace MOTOR_WORKFLOW.Services
{
    public class PagosPayPerTicServices: IPagosPayperticServices
    {
        public List<PAGOS_PAYPERTIC> read()
        {
            try
            {
                return Entities.PAGOS_PAYPERTIC.read();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<PAGOS_PAYPERTIC> readcuit(string cuit, string dni)
        {
            try
            {
                return Entities.PAGOS_PAYPERTIC.read(cuit, dni);    
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public PAGOS_PAYPERTIC getByPk(Int64 NRO_CEDULON)
        {
            try
            {
                return Entities.PAGOS_PAYPERTIC.getByPk(NRO_CEDULON);   
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int insert(PAGOS_PAYPERTIC obj)
        {
            try
            {
                return Entities.PAGOS_PAYPERTIC.insert(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void update(PAGOS_PAYPERTIC obj)
        {
            try
            {
                Entities.PAGOS_PAYPERTIC.update(obj);   
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void delete(PAGOS_PAYPERTIC obj)
        {
            try
            {
                PAGOS_PAYPERTIC.delete(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
