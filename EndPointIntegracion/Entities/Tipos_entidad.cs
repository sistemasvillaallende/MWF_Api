using System.Data.SqlClient;
using System.Data;
using EndPointIntegracion.Models;

namespace EndPointIntegracion.Entities
{
    public class Tipos_entidad:DALBase
    {
        public static List<Combo> read()
        {
            try
            {
                List<Combo> lst = new List<Combo>();
                using (SqlConnection con = GetConnection())
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM CARACTER_ENTIDADES";
                    cmd.Connection.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    Combo? obj;
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            obj = new Combo();
                            if (!dr.IsDBNull(0)) { obj.value = Convert.ToString(dr.GetInt32(0)); }
                            if (!dr.IsDBNull(1)) { obj.text = dr.GetString(1); }
                            //if (!dr.IsDBNull(2)) { obj.campo_enlace = string.Empty; }
                            lst.Add(obj);
                        }
                    }
                    return lst;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
