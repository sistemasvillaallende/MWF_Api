using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MOTOR_WORKFLOW.Entities
{
    public class Contenido_ingreso_paso_particular : DALBase
    {
        public int ID { get; set; }
        public int ID_INGRESO_PASO { get; set; }
        public int ORDEN { get; set; }
        public int ROW { get; set; }
        public int COL { get; set; }
        public bool ACTIVO { get; set; }
        public int ID_TRAMITES { get; set; }
        public string NOMBRE_ADJUNTO { get; set; }
        public string OBSERVACIONES { get; set; }
        public Contenido_ingreso_paso_particular()
        {
            ID = 0;
            ID_INGRESO_PASO = 0;
            ORDEN = 0;
            ROW = 0;
            COL = 0;
            ACTIVO = false;
            ID_TRAMITES = 0;
            NOMBRE_ADJUNTO = string.Empty;
            OBSERVACIONES = string.Empty;
        }

        private static List<Contenido_ingreso_paso_particular> mapeo(SqlDataReader dr)
        {
            List<Contenido_ingreso_paso_particular> lst = new List<Contenido_ingreso_paso_particular>();
            Contenido_ingreso_paso_particular obj;
            if (dr.HasRows)
            {
                int ID = dr.GetOrdinal("ID");
                int ID_INGRESO_PASO = dr.GetOrdinal("ID_INGRESO_PASO");
                int ORDEN = dr.GetOrdinal("ORDEN");
                int ROW = dr.GetOrdinal("ROW");
                int COL = dr.GetOrdinal("COL");
                int ACTIVO = dr.GetOrdinal("ACTIVO");
                int ID_TRAMITES = dr.GetOrdinal("ID_TRAMITES");
                int NOMBRE_ADJUNTO = dr.GetOrdinal("NOMBRE_ADJUNTO");
                int OBSERVACIONES = dr.GetOrdinal("OBSERVACIONES");

                while (dr.Read())
                {
                    obj = new Contenido_ingreso_paso_particular();
                    if (!dr.IsDBNull(ID)) { obj.ID = dr.GetInt32(ID); }
                    if (!dr.IsDBNull(ID_INGRESO_PASO)) { obj.ID_INGRESO_PASO = dr.GetInt32(ID_INGRESO_PASO); }
                    if (!dr.IsDBNull(ORDEN)) { obj.ORDEN = dr.GetInt32(ORDEN); }
                    if (!dr.IsDBNull(ROW)) { obj.ROW = dr.GetInt32(ROW); }
                    if (!dr.IsDBNull(COL)) { obj.COL = dr.GetInt32(COL); }
                    if (!dr.IsDBNull(ACTIVO)) { obj.ACTIVO = dr.GetBoolean(ACTIVO); }
                    if (!dr.IsDBNull(ID_TRAMITES)) { obj.ID_TRAMITES = dr.GetInt32(ID_TRAMITES); }
                    if (!dr.IsDBNull(NOMBRE_ADJUNTO)) { obj.NOMBRE_ADJUNTO = dr.GetString(NOMBRE_ADJUNTO); }
                    if (!dr.IsDBNull(OBSERVACIONES)) { obj.OBSERVACIONES = dr.GetString(OBSERVACIONES); }

                    lst.Add(obj);
                }
            }
            return lst;
        }

        public static List<Contenido_ingreso_paso_particular> read()
        {
            try
            {
                List<Contenido_ingreso_paso_particular> lst = new List<Contenido_ingreso_paso_particular>();
                using (SqlConnection con = GetConnection())
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT *FROM Contenido_ingreso_paso_particular";
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

        public static Contenido_ingreso_paso_particular getByPk(
        int ID)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT *FROM Contenido_ingreso_paso_particular WHERE");
                sql.AppendLine("ID = @ID");
                Contenido_ingreso_paso_particular obj = null;
                using (SqlConnection con = GetConnection())
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sql.ToString();
                    cmd.Parameters.AddWithValue("@ID", ID);
                    cmd.Connection.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    List<Contenido_ingreso_paso_particular> lst = mapeo(dr);
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
        public static Contenido_ingreso_paso_particular getByTramitesPaso(
        int ID_TRAMITES, int ID_INGRESO_PASO)
        {
            try
            {
                string sql =
                    @"SELECT *FROM Contenido_ingreso_paso_particular 
                      WHERE
                        ID_INGRESO_PASO = @ID_INGRESO_PASO
                        AND ID_TRAMITES = @ID_TRAMITES";

                Contenido_ingreso_paso_particular obj = null;
                using (SqlConnection con = GetConnection())
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sql.ToString();
                    cmd.Parameters.AddWithValue("@ID_INGRESO_PASO", ID_INGRESO_PASO);
                    cmd.Parameters.AddWithValue("@ID_TRAMITES", ID_TRAMITES);


                    cmd.Connection.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    List<Contenido_ingreso_paso_particular> lst = mapeo(dr);
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
        public static int insert(Contenido_ingreso_paso_particular obj)
        {
            try
            {
                using (SqlConnection con = GetConnection())
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "INSERT_RECHAZO_ADJUNTO";
                    cmd.Parameters.AddWithValue("@ID_INGRESO_PASO", obj.ID_INGRESO_PASO);
                    cmd.Parameters.AddWithValue("@ID_TRAMITES", obj.ID_TRAMITES);
                    cmd.Parameters.AddWithValue("@NOMBRE_ADJUNTO", obj.NOMBRE_ADJUNTO);
                    cmd.Parameters.AddWithValue("@OBSERVACIONES", obj.OBSERVACIONES);

                    cmd.Connection.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void update(Contenido_ingreso_paso_particular obj)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("UPDATE  Contenido_ingreso_paso_particular SET");
                sql.AppendLine("ID_INGRESO_PASO=@ID_INGRESO_PASO");
                sql.AppendLine(", ORDEN=@ORDEN");
                sql.AppendLine(", ROW=@ROW");
                sql.AppendLine(", COL=@COL");
                sql.AppendLine(", ACTIVO=@ACTIVO");
                sql.AppendLine(", ID_TRAMITES=@ID_TRAMITES");
                sql.AppendLine(", NOMBRE_ADJUNTO=@NOMBRE_ADJUNTO");
                sql.AppendLine(", OBSERVACIONES=@OBSERVACIONES");
                sql.AppendLine("WHERE");
                sql.AppendLine("ID=@ID");
                using (SqlConnection con = GetConnection())
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sql.ToString();
                    cmd.Parameters.AddWithValue("@ID_INGRESO_PASO", obj.ID_INGRESO_PASO);
                    cmd.Parameters.AddWithValue("@ORDEN", obj.ORDEN);
                    cmd.Parameters.AddWithValue("@ROW", obj.ROW);
                    cmd.Parameters.AddWithValue("@COL", obj.COL);
                    cmd.Parameters.AddWithValue("@ACTIVO", obj.ACTIVO);
                    cmd.Parameters.AddWithValue("@ID_TRAMITES", obj.ID_TRAMITES);
                    cmd.Parameters.AddWithValue("@NOMBRE_ADJUNTO", obj.NOMBRE_ADJUNTO);
                    cmd.Parameters.AddWithValue("@OBSERVACIONES", obj.OBSERVACIONES);

                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void delete(Contenido_ingreso_paso_particular obj)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("DELETE  Contenido_ingreso_paso_particular ");
                sql.AppendLine("WHERE");
                sql.AppendLine("ID=@ID");
                using (SqlConnection con = GetConnection())
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sql.ToString();
                    cmd.Parameters.AddWithValue("@ID", obj.ID);
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

