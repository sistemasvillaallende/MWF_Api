using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace MOTOR_WORKFLOW.Entities
{
    public class PAGOS_PAYPERTIC:DALBase
    {
        public Int64 NRO_CEDULON { get; set; }
        public string CUIT { get; set; }
        public DateTime FECHA { get; set; }
        public string DNI { get; set; }
        public string APELLIDO { get; set; }
        public string NOMBRE { get; set; }
        public string TELEFONO { get; set; }
        public string MAIL { get; set; }
        public int COD_TARJETA_PAYPERTIC { get; set; }
        public string DESC_TARJETA { get; set; }
        public int CANT_CUOTAS { get; set; }
        public int ESTADO { get; set; }
        public string HASH_TRANSACCION { get; set; }
        public int SUBSISTEMA { get; set; }
        public bool VECINO_DIGITAL { get; set; }
        public int CIR { get; set; }
        public int SEC { get; set; }
        public int MAN { get; set; }
        public int PAR { get; set; }
        public int P_H { get; set; }
        public int LEG { get; set; }
        public string DOMINIO { get; set; }
        public int NRO_PROCURACION { get; set; }
        public string ESTADO_PAYPERTIC { get; set; }
        public int ULTIMOS_4 { get; set; }
        public string LOTE { get; set; }
        public DateTime FECHA_PAGO { get; set; }
        public DateTime FECHA_ACREDITACION { get; set; }
        public int PRIMEROS_6 { get; set; }
        public int CUPON { get; set; }
        public int NRO_LIQ { get; set; }
        public DateTime FECHA_LIQ { get; set; }
        public int USUARIO_LIQ { get; set; }
        public decimal MONTO { get; set; }
        public int COD_TARJETA_INTERNO { get; set; }
        public string TIPO_CEM { get; set; }
        public int MANZANA_CEM { get; set; }
        public int LOTE_CEM { get; set; }
        public int PARCELA_CEM { get; set; }
        public int NIVEL_CEM { get; set; }
        public int NRO_PLAN { get; set; }
        public bool PAGO_TELEFONICO { get; set; }
        public int USUARIO_TELEFONICO { get; set; }
        public int NRO_CUOTA { get; set; }
        public string CONCEPTO { get; set; }

        public string MEDIO_PAGO { get; set; }

        public PAGOS_PAYPERTIC()
        {
            NRO_CEDULON = 0;
            CUIT = string.Empty;
            FECHA = DateTime.Now;
            DNI = string.Empty;
            APELLIDO = string.Empty;
            NOMBRE = string.Empty;
            TELEFONO = string.Empty;
            MAIL = string.Empty;
            COD_TARJETA_PAYPERTIC = 0;
            DESC_TARJETA = string.Empty;
            CANT_CUOTAS = 0;
            ESTADO = 0;
            HASH_TRANSACCION = string.Empty;
            SUBSISTEMA = 0;
            VECINO_DIGITAL = false;
            CIR = 0;
            SEC = 0;
            MAN = 0;
            PAR = 0;
            P_H = 0;
            LEG = 0;
            DOMINIO = string.Empty;
            NRO_PROCURACION = 0;
            ESTADO_PAYPERTIC = string.Empty;
            ULTIMOS_4 = 0;
            LOTE = string.Empty;
            FECHA_PAGO = DateTime.Now;
            FECHA_ACREDITACION = DateTime.Now;
            PRIMEROS_6 = 0;
            CUPON = 0;
            NRO_LIQ = 0;
            FECHA_LIQ = DateTime.Now;
            USUARIO_LIQ = 0;
            MONTO = 0;
            COD_TARJETA_INTERNO = 0;
            TIPO_CEM = string.Empty;
            MANZANA_CEM = 0;
            LOTE_CEM = 0;
            PARCELA_CEM = 0;
            NIVEL_CEM = 0;
            NRO_PLAN = 0;
            PAGO_TELEFONICO = false;
            USUARIO_TELEFONICO = 0;
            NRO_CUOTA = 0;
            CONCEPTO = string.Empty;
            MEDIO_PAGO = string.Empty;
        }

        private static List<PAGOS_PAYPERTIC> mapeo(SqlDataReader dr)
        {
            List<PAGOS_PAYPERTIC> lst = new List<PAGOS_PAYPERTIC>();
            PAGOS_PAYPERTIC obj;
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    obj = new PAGOS_PAYPERTIC();
                    if (!dr.IsDBNull(0)) { obj.NRO_CEDULON = dr.GetInt64(0); }
                    if (!dr.IsDBNull(1)) { obj.CUIT = dr.GetString(1); }
                    if (!dr.IsDBNull(2)) { obj.FECHA = dr.GetDateTime(2); }
                    if (!dr.IsDBNull(3)) { obj.DNI = dr.GetString(3); }
                    if (!dr.IsDBNull(4)) { obj.APELLIDO = dr.GetString(4); }
                    if (!dr.IsDBNull(5)) { obj.NOMBRE = dr.GetString(5); }
                    if (!dr.IsDBNull(6)) { obj.TELEFONO = dr.GetString(6); }
                    if (!dr.IsDBNull(7)) { obj.MAIL = dr.GetString(7); }
                    if (!dr.IsDBNull(8)) { obj.COD_TARJETA_PAYPERTIC = dr.GetInt32(8); }
                    if (!dr.IsDBNull(9)) { obj.DESC_TARJETA = dr.GetString(9); }
                    if (!dr.IsDBNull(10)) { obj.CANT_CUOTAS = dr.GetInt32(10); }
                    if (!dr.IsDBNull(11)) { obj.ESTADO = dr.GetInt32(11); }
                    if (!dr.IsDBNull(12)) { obj.HASH_TRANSACCION = dr.GetString(12); }
                    if (!dr.IsDBNull(13)) { obj.SUBSISTEMA = dr.GetInt32(13); }
                    if (!dr.IsDBNull(14)) { obj.VECINO_DIGITAL = dr.GetBoolean(14); }
                    if (!dr.IsDBNull(15)) { obj.CIR = dr.GetInt32(15); }
                    if (!dr.IsDBNull(16)) { obj.SEC = dr.GetInt32(16); }
                    if (!dr.IsDBNull(17)) { obj.MAN = dr.GetInt32(17); }
                    if (!dr.IsDBNull(18)) { obj.PAR = dr.GetInt32(18); }
                    if (!dr.IsDBNull(19)) { obj.P_H = dr.GetInt32(19); }
                    if (!dr.IsDBNull(20)) { obj.LEG = dr.GetInt32(20); }
                    if (!dr.IsDBNull(21)) { obj.DOMINIO = dr.GetString(21); }
                    if (!dr.IsDBNull(22)) { obj.NRO_PROCURACION = dr.GetInt32(22); }
                    if (!dr.IsDBNull(23)) { obj.ESTADO_PAYPERTIC = dr.GetString(23); }
                    if (!dr.IsDBNull(24)) { obj.ULTIMOS_4 = dr.GetInt32(24); }
                    if (!dr.IsDBNull(25)) { obj.LOTE = dr.GetString(25); }
                    if (!dr.IsDBNull(26)) { obj.FECHA_PAGO = dr.GetDateTime(26); }
                    if (!dr.IsDBNull(27)) { obj.FECHA_ACREDITACION = dr.GetDateTime(27); }
                    if (!dr.IsDBNull(28)) { obj.PRIMEROS_6 = dr.GetInt32(28); }
                    if (!dr.IsDBNull(29)) { obj.CUPON = dr.GetInt32(29); }
                    if (!dr.IsDBNull(30)) { obj.NRO_LIQ = dr.GetInt32(30); }
                    if (!dr.IsDBNull(31)) { obj.FECHA_LIQ = dr.GetDateTime(31); }
                    if (!dr.IsDBNull(32)) { obj.USUARIO_LIQ = dr.GetInt32(32); }
                    if (!dr.IsDBNull(33)) { obj.MONTO = dr.GetDecimal(33); }
                    if (!dr.IsDBNull(34)) { obj.COD_TARJETA_INTERNO = dr.GetInt32(34); }
                    if (!dr.IsDBNull(35)) { obj.TIPO_CEM = dr.GetString(35); }
                    if (!dr.IsDBNull(36)) { obj.MANZANA_CEM = dr.GetInt32(36); }
                    if (!dr.IsDBNull(37)) { obj.LOTE_CEM = dr.GetInt32(37); }
                    if (!dr.IsDBNull(38)) { obj.PARCELA_CEM = dr.GetInt32(38); }
                    if (!dr.IsDBNull(39)) { obj.NIVEL_CEM = dr.GetInt32(39); }

                    if (!dr.IsDBNull(40)) { obj.NRO_PLAN = dr.GetInt32(40); }
                    if (!dr.IsDBNull(41)) { obj.PAGO_TELEFONICO = dr.GetBoolean(41); }
                    if (!dr.IsDBNull(42)) { obj.USUARIO_TELEFONICO = dr.GetInt32(42); }
                    if (!dr.IsDBNull(43)) { obj.NRO_CUOTA = dr.GetInt32(43); }
                    if (!dr.IsDBNull(44)) { obj.CONCEPTO = dr.GetString(44); }
                    lst.Add(obj);
                }
            }
            return lst;
        }

        public static List<PAGOS_PAYPERTIC> read()
        {
            try
            {
                List<PAGOS_PAYPERTIC> lst = new List<PAGOS_PAYPERTIC>();
                using (SqlConnection con = GetConnection())
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT *FROM PAGOS_PAYPERTIC";
                    cmd.Connection.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    lst = mapeo(dr);
                    return lst;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<PAGOS_PAYPERTIC> read(string cuit, string dni)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT A.*, B.des_tarjeta FROM PAGOS_PAYPERTIC A");
                sql.AppendLine("INNER JOIN TARJETAS_DEBITOS B ON A.COD_TARJETA_INTERNO=B.cod_tarjeta");
                sql.AppendLine("WHERE (CUIT = @CUIT OR CUIT = @DNI");
                sql.AppendLine("OR DNI = @DNI) AND (ESTADO_PAYPERTIC = 'approved' OR");
                sql.AppendLine("ESTADO_PAYPERTIC = 'APR') ORDER BY A.FECHA DESC");

                List<PAGOS_PAYPERTIC> lst = new List<PAGOS_PAYPERTIC>();
                using (SqlConnection con = GetConnection())
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sql.ToString();
                    cmd.Parameters.AddWithValue("@CUIT", cuit);
                    cmd.Parameters.AddWithValue("@DNI", dni);
                    cmd.Connection.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    lst = mapeo(dr);
                    return lst;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static PAGOS_PAYPERTIC getByPk(
        Int64 NRO_CEDULON)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT A.*, B.des_tarjeta FROM PAGOS_PAYPERTIC A ");
                sql.AppendLine("INNER JOIN TARJETAS_DEBITOS B ON A.COD_TARJETA_INTERNO=B.cod_tarjeta");
                sql.AppendLine("WHERE NRO_CEDULON = @NRO_CEDULON");
                PAGOS_PAYPERTIC obj = null;
                using (SqlConnection con = GetConnectionSIIMVA())
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sql.ToString();
                    cmd.Parameters.AddWithValue("@NRO_CEDULON", NRO_CEDULON);
                    cmd.Connection.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    List<PAGOS_PAYPERTIC> lst = mapeo(dr);
                    if (lst.Count != 0)
                        obj = lst[0];
                }
                return obj;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int insert(PAGOS_PAYPERTIC obj)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("INSERT INTO PAGOS_PAYPERTIC(");
                sql.AppendLine("NRO_CEDULON");
                sql.AppendLine(", CUIT");
                sql.AppendLine(", FECHA");
                sql.AppendLine(", DNI");
                sql.AppendLine(", APELLIDO");
                sql.AppendLine(", NOMBRE");
                sql.AppendLine(", TELEFONO");
                sql.AppendLine(", MAIL");
                sql.AppendLine(", COD_TARJETA_PAYPERTIC");
                sql.AppendLine(", DESC_TARJETA");
                sql.AppendLine(", CANT_CUOTAS");
                sql.AppendLine(", ESTADO");
                sql.AppendLine(", HASH_TRANSACCION");
                sql.AppendLine(", SUBSISTEMA");
                sql.AppendLine(", VECINO_DIGITAL");
                sql.AppendLine(", CIR");
                sql.AppendLine(", SEC");
                sql.AppendLine(", MAN");
                sql.AppendLine(", PAR");
                sql.AppendLine(", P_H");
                sql.AppendLine(", LEG");
                sql.AppendLine(", DOMINIO");
                sql.AppendLine(", NRO_PROCURACION");
                sql.AppendLine(", ESTADO_PAYPERTIC");
                sql.AppendLine(", ULTIMOS_4");
                sql.AppendLine(", LOTE");
                sql.AppendLine(", FECHA_PAGO");
                sql.AppendLine(", FECHA_ACREDITACION");
                sql.AppendLine(", PRIMEROS_6");
                sql.AppendLine(", CUPON");
                sql.AppendLine(", NRO_LIQ");
                sql.AppendLine(", FECHA_LIQ");
                sql.AppendLine(", USUARIO_LIQ");
                sql.AppendLine(", MONTO");
                sql.AppendLine(", COD_TARJETA_INTERNO");
                sql.AppendLine(", TIPO_CEM");
                sql.AppendLine(", MANZANA_CEM");
                sql.AppendLine(", LOTE_CEM");
                sql.AppendLine(", PARCELA_CEM");
                sql.AppendLine(", NIVEL_CEM");
                sql.AppendLine(")");
                sql.AppendLine("VALUES");
                sql.AppendLine("(");
                sql.AppendLine("@NRO_CEDULON");
                sql.AppendLine(", @CUIT");
                sql.AppendLine(", @FECHA");
                sql.AppendLine(", @DNI");
                sql.AppendLine(", @APELLIDO");
                sql.AppendLine(", @NOMBRE");
                sql.AppendLine(", @TELEFONO");
                sql.AppendLine(", @MAIL");
                sql.AppendLine(", @COD_TARJETA_PAYPERTIC");
                sql.AppendLine(", @DESC_TARJETA");
                sql.AppendLine(", @CANT_CUOTAS");
                sql.AppendLine(", @ESTADO");
                sql.AppendLine(", @HASH_TRANSACCION");
                sql.AppendLine(", @SUBSISTEMA");
                sql.AppendLine(", @VECINO_DIGITAL");
                sql.AppendLine(", @CIR");
                sql.AppendLine(", @SEC");
                sql.AppendLine(", @MAN");
                sql.AppendLine(", @PAR");
                sql.AppendLine(", @P_H");
                sql.AppendLine(", @LEG");
                sql.AppendLine(", @DOMINIO");
                sql.AppendLine(", @NRO_PROCURACION");
                sql.AppendLine(", @ESTADO_PAYPERTIC");
                sql.AppendLine(", @ULTIMOS_4");
                sql.AppendLine(", @LOTE");
                sql.AppendLine(", @FECHA_PAGO");
                sql.AppendLine(", @FECHA_ACREDITACION");
                sql.AppendLine(", @PRIMEROS_6");
                sql.AppendLine(", @CUPON");
                sql.AppendLine(", @NRO_LIQ");
                sql.AppendLine(", @FECHA_LIQ");
                sql.AppendLine(", @USUARIO_LIQ");
                sql.AppendLine(", @MONTO");
                sql.AppendLine(", @COD_TARJETA_INTERNO");
                sql.AppendLine(", @TIPO_CEM");
                sql.AppendLine(", @MANZANA_CEM");
                sql.AppendLine(", @LOTE_CEM");
                sql.AppendLine(", @PARCELA_CEM");
                sql.AppendLine(", @NIVEL_CEM");
                sql.AppendLine(")");
                sql.AppendLine("SELECT SCOPE_IDENTITY()");
                using (SqlConnection con = GetConnection())
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sql.ToString();
                    cmd.Parameters.AddWithValue("@NRO_CEDULON", obj.NRO_CEDULON);
                    cmd.Parameters.AddWithValue("@CUIT", obj.CUIT);
                    cmd.Parameters.AddWithValue("@FECHA", obj.FECHA);
                    cmd.Parameters.AddWithValue("@DNI", obj.DNI);
                    cmd.Parameters.AddWithValue("@APELLIDO", obj.APELLIDO);
                    cmd.Parameters.AddWithValue("@NOMBRE", obj.NOMBRE);
                    cmd.Parameters.AddWithValue("@TELEFONO", obj.TELEFONO);
                    cmd.Parameters.AddWithValue("@MAIL", obj.MAIL);
                    cmd.Parameters.AddWithValue("@COD_TARJETA_PAYPERTIC", obj.COD_TARJETA_PAYPERTIC);
                    cmd.Parameters.AddWithValue("@DESC_TARJETA", obj.DESC_TARJETA);
                    cmd.Parameters.AddWithValue("@CANT_CUOTAS", obj.CANT_CUOTAS);
                    cmd.Parameters.AddWithValue("@ESTADO", obj.ESTADO);
                    cmd.Parameters.AddWithValue("@HASH_TRANSACCION", obj.HASH_TRANSACCION);
                    cmd.Parameters.AddWithValue("@SUBSISTEMA", obj.SUBSISTEMA);
                    cmd.Parameters.AddWithValue("@VECINO_DIGITAL", obj.VECINO_DIGITAL);
                    cmd.Parameters.AddWithValue("@CIR", obj.CIR);
                    cmd.Parameters.AddWithValue("@SEC", obj.SEC);
                    cmd.Parameters.AddWithValue("@MAN", obj.MAN);
                    cmd.Parameters.AddWithValue("@PAR", obj.PAR);
                    cmd.Parameters.AddWithValue("@P_H", obj.P_H);
                    cmd.Parameters.AddWithValue("@LEG", obj.LEG);
                    cmd.Parameters.AddWithValue("@DOMINIO", obj.DOMINIO);
                    cmd.Parameters.AddWithValue("@NRO_PROCURACION", obj.NRO_PROCURACION);
                    cmd.Parameters.AddWithValue("@ESTADO_PAYPERTIC", obj.ESTADO_PAYPERTIC);
                    cmd.Parameters.AddWithValue("@ULTIMOS_4", obj.ULTIMOS_4);
                    cmd.Parameters.AddWithValue("@LOTE", obj.LOTE);
                    cmd.Parameters.AddWithValue("@FECHA_PAGO", obj.FECHA_PAGO);
                    cmd.Parameters.AddWithValue("@FECHA_ACREDITACION", obj.FECHA_ACREDITACION);
                    cmd.Parameters.AddWithValue("@PRIMEROS_6", obj.PRIMEROS_6);
                    cmd.Parameters.AddWithValue("@CUPON", obj.CUPON);
                    cmd.Parameters.AddWithValue("@NRO_LIQ", obj.NRO_LIQ);
                    cmd.Parameters.AddWithValue("@FECHA_LIQ", obj.FECHA_LIQ);
                    cmd.Parameters.AddWithValue("@USUARIO_LIQ", obj.USUARIO_LIQ);
                    cmd.Parameters.AddWithValue("@MONTO", obj.MONTO);
                    cmd.Parameters.AddWithValue("@COD_TARJETA_INTERNO", obj.COD_TARJETA_INTERNO);
                    cmd.Parameters.AddWithValue("@TIPO_CEM", obj.TIPO_CEM);
                    cmd.Parameters.AddWithValue("@MANZANA_CEM", obj.MANZANA_CEM);
                    cmd.Parameters.AddWithValue("@LOTE_CEM", obj.LOTE_CEM);
                    cmd.Parameters.AddWithValue("@PARCELA_CEM", obj.PARCELA_CEM);
                    cmd.Parameters.AddWithValue("@NIVEL_CEM", obj.NIVEL_CEM);
                    cmd.Connection.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void update(PAGOS_PAYPERTIC obj)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("UPDATE  PAGOS_PAYPERTIC SET");
                sql.AppendLine("CUIT=@CUIT");
                sql.AppendLine(", FECHA=@FECHA");
                sql.AppendLine(", DNI=@DNI");
                sql.AppendLine(", APELLIDO=@APELLIDO");
                sql.AppendLine(", NOMBRE=@NOMBRE");
                sql.AppendLine(", TELEFONO=@TELEFONO");
                sql.AppendLine(", MAIL=@MAIL");
                sql.AppendLine(", COD_TARJETA_PAYPERTIC=@COD_TARJETA_PAYPERTIC");
                sql.AppendLine(", DESC_TARJETA=@DESC_TARJETA");
                sql.AppendLine(", CANT_CUOTAS=@CANT_CUOTAS");
                sql.AppendLine(", ESTADO=@ESTADO");
                sql.AppendLine(", HASH_TRANSACCION=@HASH_TRANSACCION");
                sql.AppendLine(", SUBSISTEMA=@SUBSISTEMA");
                sql.AppendLine(", VECINO_DIGITAL=@VECINO_DIGITAL");
                sql.AppendLine(", CIR=@CIR");
                sql.AppendLine(", SEC=@SEC");
                sql.AppendLine(", MAN=@MAN");
                sql.AppendLine(", PAR=@PAR");
                sql.AppendLine(", P_H=@P_H");
                sql.AppendLine(", LEG=@LEG");
                sql.AppendLine(", DOMINIO=@DOMINIO");
                sql.AppendLine(", NRO_PROCURACION=@NRO_PROCURACION");
                sql.AppendLine(", ESTADO_PAYPERTIC=@ESTADO_PAYPERTIC");
                sql.AppendLine(", ULTIMOS_4=@ULTIMOS_4");
                sql.AppendLine(", LOTE=@LOTE");
                sql.AppendLine(", FECHA_PAGO=@FECHA_PAGO");
                sql.AppendLine(", FECHA_ACREDITACION=@FECHA_ACREDITACION");
                sql.AppendLine(", PRIMEROS_6=@PRIMEROS_6");
                sql.AppendLine(", CUPON=@CUPON");
                sql.AppendLine(", NRO_LIQ=@NRO_LIQ");
                sql.AppendLine(", FECHA_LIQ=@FECHA_LIQ");
                sql.AppendLine(", USUARIO_LIQ=@USUARIO_LIQ");
                sql.AppendLine(", MONTO=@MONTO");
                sql.AppendLine(", COD_TARJETA_INTERNO=@COD_TARJETA_INTERNO");
                sql.AppendLine(", TIPO_CEM=@TIPO_CEM");
                sql.AppendLine(", MANZANA_CEM=@MANZANA_CEM");
                sql.AppendLine(", LOTE_CEM=@LOTE_CEM");
                sql.AppendLine(", PARCELA_CEM=@PARCELA_CEM");
                sql.AppendLine(", NIVEL_CEM=@NIVEL_CEM");
                sql.AppendLine("WHERE");
                sql.AppendLine("NRO_CEDULON=@NRO_CEDULON");
                using (SqlConnection con = GetConnection())
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sql.ToString();
                    cmd.Parameters.AddWithValue("@NRO_CEDULON", obj.NRO_CEDULON);
                    cmd.Parameters.AddWithValue("@CUIT", obj.CUIT);
                    cmd.Parameters.AddWithValue("@FECHA", obj.FECHA);
                    cmd.Parameters.AddWithValue("@DNI", obj.DNI);
                    cmd.Parameters.AddWithValue("@APELLIDO", obj.APELLIDO);
                    cmd.Parameters.AddWithValue("@NOMBRE", obj.NOMBRE);
                    cmd.Parameters.AddWithValue("@TELEFONO", obj.TELEFONO);
                    cmd.Parameters.AddWithValue("@MAIL", obj.MAIL);
                    cmd.Parameters.AddWithValue("@COD_TARJETA_PAYPERTIC", obj.COD_TARJETA_PAYPERTIC);
                    cmd.Parameters.AddWithValue("@DESC_TARJETA", obj.DESC_TARJETA);
                    cmd.Parameters.AddWithValue("@CANT_CUOTAS", obj.CANT_CUOTAS);
                    cmd.Parameters.AddWithValue("@ESTADO", obj.ESTADO);
                    cmd.Parameters.AddWithValue("@HASH_TRANSACCION", obj.HASH_TRANSACCION);
                    cmd.Parameters.AddWithValue("@SUBSISTEMA", obj.SUBSISTEMA);
                    cmd.Parameters.AddWithValue("@VECINO_DIGITAL", obj.VECINO_DIGITAL);
                    cmd.Parameters.AddWithValue("@CIR", obj.CIR);
                    cmd.Parameters.AddWithValue("@SEC", obj.SEC);
                    cmd.Parameters.AddWithValue("@MAN", obj.MAN);
                    cmd.Parameters.AddWithValue("@PAR", obj.PAR);
                    cmd.Parameters.AddWithValue("@P_H", obj.P_H);
                    cmd.Parameters.AddWithValue("@LEG", obj.LEG);
                    cmd.Parameters.AddWithValue("@DOMINIO", obj.DOMINIO);
                    cmd.Parameters.AddWithValue("@NRO_PROCURACION", obj.NRO_PROCURACION);
                    cmd.Parameters.AddWithValue("@ESTADO_PAYPERTIC", obj.ESTADO_PAYPERTIC);
                    cmd.Parameters.AddWithValue("@ULTIMOS_4", obj.ULTIMOS_4);
                    cmd.Parameters.AddWithValue("@LOTE", obj.LOTE);
                    cmd.Parameters.AddWithValue("@FECHA_PAGO", obj.FECHA_PAGO);
                    cmd.Parameters.AddWithValue("@FECHA_ACREDITACION", obj.FECHA_ACREDITACION);
                    cmd.Parameters.AddWithValue("@PRIMEROS_6", obj.PRIMEROS_6);
                    cmd.Parameters.AddWithValue("@CUPON", obj.CUPON);
                    cmd.Parameters.AddWithValue("@NRO_LIQ", obj.NRO_LIQ);
                    cmd.Parameters.AddWithValue("@FECHA_LIQ", obj.FECHA_LIQ);
                    cmd.Parameters.AddWithValue("@USUARIO_LIQ", obj.USUARIO_LIQ);
                    cmd.Parameters.AddWithValue("@MONTO", obj.MONTO);
                    cmd.Parameters.AddWithValue("@COD_TARJETA_INTERNO", obj.COD_TARJETA_INTERNO);
                    cmd.Parameters.AddWithValue("@TIPO_CEM", obj.TIPO_CEM);
                    cmd.Parameters.AddWithValue("@MANZANA_CEM", obj.MANZANA_CEM);
                    cmd.Parameters.AddWithValue("@LOTE_CEM", obj.LOTE_CEM);
                    cmd.Parameters.AddWithValue("@PARCELA_CEM", obj.PARCELA_CEM);
                    cmd.Parameters.AddWithValue("@NIVEL_CEM", obj.NIVEL_CEM);
                    cmd.Parameters.AddWithValue("@NRO_CEDULON", obj.NRO_CEDULON);
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void delete(PAGOS_PAYPERTIC obj)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("DELETE  PAGOS_PAYPERTIC ");
                sql.AppendLine("WHERE");
                sql.AppendLine("NRO_CEDULON=@NRO_CEDULON");
                using (SqlConnection con = GetConnection())
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sql.ToString();
                    cmd.Parameters.AddWithValue("@NRO_CEDULON", obj.NRO_CEDULON);
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
