using System.Data.SqlClient;
using EndPointIntegracion.Services;

namespace EndPointIntegracion.Entities
{
    public class DALBase
    {
        public static SqlConnection GetConnection()
        {
            try
            {
                return new SqlConnection("Data Source=10.0.0.8; Initial Catalog=SIIMVA;User ID=general");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
