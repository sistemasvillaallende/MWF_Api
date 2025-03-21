using System.Data;
using System.Data.SqlClient;

namespace MOTOR_WORKFLOW.Entities
{
    public class VecinoDigital:DALBase
    {
        public string CUIT { get; set; }
        public string APELLIDO { get; set; }
        public string NOMBRE { get; set; }
        public DateTime FECHA_NACIMIENTO { get; set; }
        public string DIRECCION { get; set; }
        public string LOCALIDAD { get; set; }
        public int COD_PROVINCIA { get; set; }
        public string DESC_PROVINCIA { get; set; }
        public string COD_POSTAL { get; set; }
        public string TELEFONO { get; set; }
        public string MAIL { get; set; }
        public string PASSWORD { get; set; }
        public string TIPODOCUMENTO { get; set; }
        public bool activo { get; set; }
        public bool confirmado { get; set; }
        public string NRO_DOC { get; set; }
        public DateTime FECHA_ALTA { get; set; }
        public string SEXO { get; set; }
        public string MENSAF { get; set; }
        public int NIVEL_CIDI { get; set; }

        public int CEL_COD_AREA { get; set; }
        public int CEL_NUMERO { get; set; }
        public bool CEL_VALIDADO { get; set; }
        public int CEL_COD_VALIDACION { get; set; }
        public DateTime CEL_VIGENCIA_COD_VALIDACION { get; set; }
        public string LINK { get; set; }
        public bool cidi = false;
        public string sessionHash { get; set; }
        public VecinoDigital()
        {
            CUIT = string.Empty;
            APELLIDO = string.Empty;
            NOMBRE = string.Empty;
            FECHA_NACIMIENTO = Convert.ToDateTime("01/01/1900");
            DIRECCION = string.Empty;
            LOCALIDAD = string.Empty;
            COD_PROVINCIA = 0;
            DESC_PROVINCIA = string.Empty;
            COD_POSTAL = string.Empty;
            TELEFONO = string.Empty;
            MAIL = string.Empty;
            PASSWORD = string.Empty;
            TIPODOCUMENTO = string.Empty;
            NRO_DOC = string.Empty;
            FECHA_ALTA = DateTime.Now;
            SEXO = string.Empty;
            MENSAF = String.Empty;
            NIVEL_CIDI = 0;
            CEL_COD_AREA = 0;
            CEL_NUMERO = 0;
            CEL_VALIDADO = false;
            CEL_COD_VALIDACION = 0;
            CEL_VIGENCIA_COD_VALIDACION = DateTime.Now;
        }

        private static VecinoDigital mapeo(SqlDataReader dr)
        {
            try
            {
                VecinoDigital obj = null;
                if (dr.HasRows)
                {
                    int CUIT = dr.GetOrdinal("CUIT");
                    int APELLIDO = dr.GetOrdinal("APELLIDO");
                    int NOMBRE = dr.GetOrdinal("NOMBRE");
                    int FECHA_NACIMIENTO = dr.GetOrdinal("FECHA_NACIMIENTO");
                    int DIRECCION = dr.GetOrdinal("DIRECCION");
                    int LOCALIDAD = dr.GetOrdinal("LOCALIDAD");
                    int COD_PROVINCIA = dr.GetOrdinal("COD_PROVINCIA");
                    int DESC_PROVINCIA = dr.GetOrdinal("DESC_PROVINCIA");
                    int COD_POSTAL = dr.GetOrdinal("COD_POSTAL");
                    int TELEFONO = dr.GetOrdinal("TELEFONO");
                    int MAIL = dr.GetOrdinal("MAIL");
                    int PASSWORD = dr.GetOrdinal("PASSWORD");
                    int TIPODOCUMENTO = dr.GetOrdinal("TIPODOCUMENTO");
                    int ACTIVO = dr.GetOrdinal("ACTIVO");
                    int CONFIRMADO = dr.GetOrdinal("CONFIRMADO");
                    int NRO_DOC = dr.GetOrdinal("NRO_DOC");
                    int SEXO = dr.GetOrdinal("SEXO");
                    int MENSAF = dr.GetOrdinal("MENSAF");
                    int NIVEL_CIDI = dr.GetOrdinal("NIVEL_CIDI");

                    int CEL_COD_AREA = dr.GetOrdinal("CEL_COD_AREA");
                    int CEL_NUMERO = dr.GetOrdinal("CEL_NUMERO");
                    int CEL_VALIDADO = dr.GetOrdinal("CEL_VALIDADO");
                    int CEL_COD_VALIDACION = dr.GetOrdinal("CEL_COD_VALIDACION");
                    int CEL_VIGENCIA_COD_VALIDACION = dr.GetOrdinal("CEL_VIGENCIA_COD_VALIDACION");
                    int FECHA_ALTA = dr.GetOrdinal("FECHA_ALTA");


                    while (dr.Read())
                    {
                        obj = new VecinoDigital();
                        if (!dr.IsDBNull(CUIT))
                            obj.CUIT = dr.GetString(CUIT);
                        if (!dr.IsDBNull(APELLIDO))
                            obj.APELLIDO = dr.GetString(APELLIDO);
                        if (!dr.IsDBNull(NOMBRE))
                            obj.NOMBRE = dr.GetString(NOMBRE);
                        if (!dr.IsDBNull(FECHA_NACIMIENTO))
                            obj.FECHA_NACIMIENTO = dr.GetDateTime(FECHA_NACIMIENTO);
                        if (!dr.IsDBNull(DIRECCION))
                            obj.DIRECCION = dr.GetString(DIRECCION);
                        if (!dr.IsDBNull(LOCALIDAD))
                            obj.LOCALIDAD = dr.GetString(LOCALIDAD);
                        if (!dr.IsDBNull(COD_PROVINCIA))
                            obj.COD_PROVINCIA = dr.GetInt32(COD_PROVINCIA);
                        if (!dr.IsDBNull(DESC_PROVINCIA))
                            obj.DESC_PROVINCIA = dr.GetString(DESC_PROVINCIA);
                        if (!dr.IsDBNull(COD_POSTAL))
                            obj.COD_POSTAL = dr.GetString(COD_POSTAL);
                        if (!dr.IsDBNull(TELEFONO))
                            obj.TELEFONO = dr.GetString(TELEFONO);
                        if (!dr.IsDBNull(MAIL))
                            obj.MAIL = dr.GetString(MAIL);
                        if (!dr.IsDBNull(PASSWORD))
                            obj.PASSWORD = dr.GetString(PASSWORD);
                        if (!dr.IsDBNull(TIPODOCUMENTO))
                            obj.TIPODOCUMENTO = dr.GetString(TIPODOCUMENTO);
                        if (!dr.IsDBNull(NRO_DOC))
                            obj.NRO_DOC = dr.GetString(NRO_DOC);

                        if (!dr.IsDBNull(ACTIVO))
                            obj.activo = dr.GetBoolean(ACTIVO);
                        if (!dr.IsDBNull(CONFIRMADO))
                            obj.confirmado = dr.GetBoolean(CONFIRMADO);

                        if (!dr.IsDBNull(SEXO))
                            obj.SEXO = dr.GetString(SEXO);
                        if (!dr.IsDBNull(MENSAF))
                            obj.MENSAF = dr.GetString(MENSAF);

                        if (!dr.IsDBNull(NIVEL_CIDI))
                            obj.NIVEL_CIDI = dr.GetInt32(NIVEL_CIDI);

                        if (!dr.IsDBNull(CEL_COD_AREA))
                            obj.CEL_COD_AREA = dr.GetInt32(CEL_COD_AREA);
                        if (!dr.IsDBNull(CEL_NUMERO))
                            obj.CEL_NUMERO = dr.GetInt32(CEL_NUMERO);
                        if (!dr.IsDBNull(CEL_VALIDADO))
                            obj.CEL_VALIDADO = dr.GetBoolean(CEL_VALIDADO);
                        if (!dr.IsDBNull(CEL_COD_VALIDACION))
                            obj.CEL_COD_VALIDACION = dr.GetInt32(CEL_COD_VALIDACION);
                        if (!dr.IsDBNull(CEL_VIGENCIA_COD_VALIDACION))
                            obj.CEL_VIGENCIA_COD_VALIDACION = dr.GetDateTime(CEL_VIGENCIA_COD_VALIDACION);
                        if (!dr.IsDBNull(FECHA_ALTA))
                            obj.FECHA_ALTA = dr.GetDateTime(FECHA_ALTA);

                    }
                }
                return obj;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static VecinoDigital getByPk(string _CUIT)
        {
            try
            {
                using (SqlConnection con = GetConnectionSIIMVA())
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT *FROM VECINO_DIGITAL WHERE CUIT = @CUIT";
                    cmd.Parameters.AddWithValue("@CUIT", _CUIT);
                    cmd.Connection.Open();

                    SqlDataReader dr = cmd.ExecuteReader();
                    return mapeo(dr);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
