using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MOTOR_WORKFLOW.Entities
{
    public class Ws_parametros_x_campo_formulario : DALBase
    {
        public int ID_CAMPO_X_FORMULARIO { get; set; }
        public int ID_WS_URL_PARAMETERS { get; set; }
        public string NOMBRE_PARAMETRO { get; set; }
        public string VALOR_PARAMETROS { get; set; }

        public Ws_parametros_x_campo_formulario()
        {
            ID_CAMPO_X_FORMULARIO = 0;
            ID_WS_URL_PARAMETERS = 0;
            NOMBRE_PARAMETRO = string.Empty;
            VALOR_PARAMETROS = string.Empty;
        }

        private static List<Ws_parametros_x_campo_formulario> mapeo(SqlDataReader dr)
        {
            List<Ws_parametros_x_campo_formulario> lst = new List<Ws_parametros_x_campo_formulario>();
            Ws_parametros_x_campo_formulario obj;
            if (dr.HasRows)
            {
                int ID_CAMPO_X_FORMULARIO = dr.GetOrdinal("ID_CAMPO_X_FORMULARIO");
                int ID_WS_URL_PARAMETERS = dr.GetOrdinal("ID_WS_URL_PARAMETERS");
                int NOMBRE_PARAMETRO = dr.GetOrdinal("NOMBRE_PARAMETRO");
                int VALOR_PARAMETROS = dr.GetOrdinal("VALOR_PARAMETROS");
                while (dr.Read())
                {
                    obj = new Ws_parametros_x_campo_formulario();
                    if (!dr.IsDBNull(ID_CAMPO_X_FORMULARIO)) { obj.ID_CAMPO_X_FORMULARIO = dr.GetInt32(ID_CAMPO_X_FORMULARIO); }
                    if (!dr.IsDBNull(ID_WS_URL_PARAMETERS)) { obj.ID_WS_URL_PARAMETERS = dr.GetInt32(ID_WS_URL_PARAMETERS); }
                    if (!dr.IsDBNull(NOMBRE_PARAMETRO)) { obj.NOMBRE_PARAMETRO = dr.GetString(NOMBRE_PARAMETRO); }
                    if (!dr.IsDBNull(VALOR_PARAMETROS)) { obj.VALOR_PARAMETROS = dr.GetString(VALOR_PARAMETROS); }
                    lst.Add(obj);
                }
            }
            return lst;
        }

        public static List<Ws_parametros_x_campo_formulario> read()
        {
            try
            {
                List<Ws_parametros_x_campo_formulario> lst = new List<Ws_parametros_x_campo_formulario>();
                using (SqlConnection con = GetConnection())
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT *FROM Ws_parametros_x_campo_formulario";
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

        public static Ws_parametros_x_campo_formulario getByPk(
        int ID_CAMPO_X_FORMULARIO, int ID_WS_URL_PARAMETERS)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT *FROM Ws_parametros_x_campo_formulario WHERE");
                sql.AppendLine("ID_CAMPO_X_FORMULARIO = @ID_CAMPO_X_FORMULARIO");
                sql.AppendLine("AND ID_WS_URL_PARAMETERS = @ID_WS_URL_PARAMETERS");
                Ws_parametros_x_campo_formulario obj = null;
                using (SqlConnection con = GetConnection())
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sql.ToString();
                    cmd.Parameters.AddWithValue("@ID_CAMPO_X_FORMULARIO", ID_CAMPO_X_FORMULARIO);
                    cmd.Parameters.AddWithValue("@ID_WS_URL_PARAMETERS", ID_WS_URL_PARAMETERS);
                    cmd.Connection.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    List<Ws_parametros_x_campo_formulario> lst = mapeo(dr);
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

        public static int insert(Ws_parametros_x_campo_formulario obj)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("INSERT INTO Ws_parametros_x_campo_formulario(");
                sql.AppendLine("ID_CAMPO_X_FORMULARIO");
                sql.AppendLine(", ID_WS_URL_PARAMETERS");
                sql.AppendLine(", NOMBRE_PARAMETRO");
                sql.AppendLine(", VALOR_PARAMETROS");
                sql.AppendLine(")");
                sql.AppendLine("VALUES");
                sql.AppendLine("(");
                sql.AppendLine("@ID_CAMPO_X_FORMULARIO");
                sql.AppendLine(", @ID_WS_URL_PARAMETERS");
                sql.AppendLine(", @NOMBRE_PARAMETRO");
                sql.AppendLine(", @VALOR_PARAMETROS");
                sql.AppendLine(")");
                using (SqlConnection con = GetConnection())
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sql.ToString();
                    cmd.Parameters.AddWithValue("@ID_CAMPO_X_FORMULARIO", obj.ID_CAMPO_X_FORMULARIO);
                    cmd.Parameters.AddWithValue("@ID_WS_URL_PARAMETERS", obj.ID_WS_URL_PARAMETERS);
                    cmd.Parameters.AddWithValue("@NOMBRE_PARAMETRO", obj.NOMBRE_PARAMETRO);
                    cmd.Parameters.AddWithValue("@VALOR_PARAMETROS", obj.VALOR_PARAMETROS);
                    cmd.Connection.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void update(Ws_parametros_x_campo_formulario obj)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("UPDATE  Ws_parametros_x_campo_formulario SET");
                sql.AppendLine("NOMBRE_PARAMETRO=@NOMBRE_PARAMETRO");
                sql.AppendLine(", VALOR_PARAMETROS=@VALOR_PARAMETROS");
                sql.AppendLine("WHERE");
                sql.AppendLine("ID_CAMPO_X_FORMULARIO=@ID_CAMPO_X_FORMULARIO");
                sql.AppendLine("AND ID_WS_URL_PARAMETERS=@ID_WS_URL_PARAMETERS");
                using (SqlConnection con = GetConnection())
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sql.ToString();
                    cmd.Parameters.AddWithValue("@ID_CAMPO_X_FORMULARIO", obj.ID_CAMPO_X_FORMULARIO);
                    cmd.Parameters.AddWithValue("@ID_WS_URL_PARAMETERS", obj.ID_WS_URL_PARAMETERS);
                    cmd.Parameters.AddWithValue("@NOMBRE_PARAMETRO", obj.NOMBRE_PARAMETRO);
                    cmd.Parameters.AddWithValue("@VALOR_PARAMETROS", obj.VALOR_PARAMETROS);
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void delete(Ws_parametros_x_campo_formulario obj)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("DELETE  Ws_parametros_x_campo_formulario ");
                sql.AppendLine("WHERE");
                sql.AppendLine("ID_CAMPO_X_FORMULARIO=@ID_CAMPO_X_FORMULARIO");
                sql.AppendLine("AND ID_WS_URL_PARAMETERS=@ID_WS_URL_PARAMETERS");
                using (SqlConnection con = GetConnection())
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sql.ToString();
                    cmd.Parameters.AddWithValue("@ID_CAMPO_X_FORMULARIO", obj.ID_CAMPO_X_FORMULARIO);
                    cmd.Parameters.AddWithValue("@ID_WS_URL_PARAMETERS", obj.ID_WS_URL_PARAMETERS);
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

