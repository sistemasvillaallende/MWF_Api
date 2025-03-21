using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace MOTOR_WORKFLOW.Entities
{
    public class ControlPago:DALBase
    {
        public int tipo_transaccion { get; set; }
        public int nro_transaccion { get; set; }
        public int legajo { get; set; }
        public string periodo { get; set; }
        public bool pagado { get; set; }
        public long nro_cedulon_paypertic { get; set; }

        public ControlPago() 
        { 
            tipo_transaccion = 0;
            nro_transaccion = 0;
            legajo = 0;
            periodo=string.Empty;
            pagado = false;
            nro_cedulon_paypertic = 0;
        }

        private static ControlPago mapeo(SqlDataReader dr)
        {
            ControlPago obj = null;
            if (dr.HasRows)
            {
                int tipo_transaccion = dr.GetOrdinal("tipo_transaccion");
                int nro_transaccion = dr.GetOrdinal("nro_transaccion");
                int legajo = dr.GetOrdinal("legajo");
                int pagado = dr.GetOrdinal("pagado");
                int nro_cedulon_paypertic = dr.GetOrdinal("nro_cedulon_paypertic");
                while (dr.Read())
                {
                    obj = new ControlPago();
                    if (!dr.IsDBNull(tipo_transaccion))
                        obj.tipo_transaccion = dr.GetInt32(tipo_transaccion);
                    if (!dr.IsDBNull(nro_transaccion))
                        obj.nro_transaccion = dr.GetInt32(nro_transaccion);
                    if (!dr.IsDBNull(legajo))
                        obj.legajo = dr.GetInt32(legajo);
                    if (!dr.IsDBNull(pagado))
                        obj.pagado = dr.GetBoolean(pagado);
                    if (!dr.IsDBNull(nro_cedulon_paypertic))
                        obj.nro_cedulon_paypertic = dr.GetInt64(nro_cedulon_paypertic);
                }
            }
            return obj;
        }
        public static ControlPago getByPk(int nro_transaccion)
        {
            try
            {
                ControlPago obj = null;
                using (SqlConnection connection = DALBase.GetConnectionSIIMVA())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = @"
                        SELECT 
	                        tipo_transaccion, 
	                        nro_transaccion, 
	                        legajo, 
	                        periodo,
	                        pagado, 
	                        nro_cedulon_paypertic
                        FROM CTASCTES_INDYCOM
                        WHERE nro_transaccion=@nro_transaccion";
                    command.Parameters.AddWithValue("@nro_transaccion", nro_transaccion);
                    command.Connection.Open();
                    obj = mapeo(command.ExecuteReader());
                }
                return obj;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
