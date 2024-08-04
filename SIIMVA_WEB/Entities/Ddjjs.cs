// Decompiled with JetBrains decompiler
// Type: MOTOR_WORKFLOW.Entities.Ddjjs
// Assembly: MOTOR_WORKFLOW, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 007B8F5F-49BB-4EE7-8464-22FD2F567A18
// Assembly location: C:\Muni\DEV\WebApiMWF\MOTOR_WORKFLOW.dll

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

#nullable enable
namespace MOTOR_WORKFLOW.Entities
{
    public class Ddjjs : DALBase
    {
        public int id { get; set; }

        public int id_pasos { get; set; }

        public string ddjj { get; set; }

        public int orden { get; set; }

        public Ddjjs()
        {
            this.id = 0;
            this.id_pasos = 0;
            this.ddjj = string.Empty;
            this.orden = 0;
        }

        private static List<Ddjjs> mapeo(SqlDataReader dr)
        {
            List<Ddjjs> ddjjsList = new List<Ddjjs>();
            if (dr.HasRows)
            {
                int ordinal1 = dr.GetOrdinal("id");
                int ordinal2 = dr.GetOrdinal("id_pasos");
                int ordinal3 = dr.GetOrdinal("ddjj");
                int ordinal4 = dr.GetOrdinal("orden");
                while (dr.Read())
                {
                    Ddjjs ddjjs = new Ddjjs();
                    if (!dr.IsDBNull(ordinal1))
                        ddjjs.id = dr.GetInt32(ordinal1);
                    if (!dr.IsDBNull(ordinal2))
                        ddjjs.id_pasos = dr.GetInt32(ordinal2);
                    if (!dr.IsDBNull(ordinal3))
                        ddjjs.ddjj = dr.GetString(ordinal3);
                    if (!dr.IsDBNull(ordinal4))
                        ddjjs.orden = dr.GetInt32(ordinal4);
                    ddjjsList.Add(ddjjs);
                }
            }
            return ddjjsList;
        }

        public static List<Ddjjs> read()
        {
            try
            {
                List<Ddjjs> ddjjsList = new List<Ddjjs>();
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT *FROM Ddjjs";
                    command.Connection.Open();
                    return Ddjjs.mapeo(command.ExecuteReader());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Ddjjs getByPk(int id)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("SELECT *FROM Ddjjs WHERE");
                stringBuilder.AppendLine("id = @id");
                Ddjjs byPk = (Ddjjs)null;
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@id", id);
                    command.Connection.Open();
                    List<Ddjjs> ddjjsList = Ddjjs.mapeo(command.ExecuteReader());
                    if (ddjjsList.Count != 0)
                        byPk = ddjjsList[0];
                }
                return byPk;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Ddjjs getByIdPasos(int id_pasos)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("SELECT *FROM Ddjjs WHERE");
                stringBuilder.AppendLine("id_pasos = @id_pasos");
                Ddjjs byIdPasos = (Ddjjs)null;
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@id_pasos", id_pasos);
                    command.Connection.Open();
                    List<Ddjjs> ddjjsList = Ddjjs.mapeo(command.ExecuteReader());
                    if (ddjjsList.Count != 0)
                        byIdPasos = ddjjsList[0];
                }
                return byIdPasos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int insert(Ddjjs obj)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("INSERT INTO Ddjjs(");
                stringBuilder.AppendLine("id_pasos");
                stringBuilder.AppendLine(", ddjj");
                stringBuilder.AppendLine(", orden");
                stringBuilder.AppendLine(")");
                stringBuilder.AppendLine("VALUES");
                stringBuilder.AppendLine("(");
                stringBuilder.AppendLine("@id_pasos");
                stringBuilder.AppendLine(", @ddjj");
                stringBuilder.AppendLine(", @orden");
                stringBuilder.AppendLine(")");
                stringBuilder.AppendLine("SELECT SCOPE_IDENTITY()");
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@id_pasos", obj.id_pasos);
                    command.Parameters.AddWithValue("@ddjj", obj.ddjj);
                    command.Parameters.AddWithValue("@orden", obj.orden);
                    command.Connection.Open();
                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void update(Ddjjs obj)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("UPDATE  Ddjjs SET");
                stringBuilder.AppendLine("id_pasos=@id_pasos");
                stringBuilder.AppendLine(", ddjj=@ddjj");
                stringBuilder.AppendLine(", orden=@orden");
                stringBuilder.AppendLine("WHERE");
                stringBuilder.AppendLine("id=@id");
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@id_pasos", obj.id_pasos);
                    command.Parameters.AddWithValue("@ddjj", obj.ddjj);
                    command.Parameters.AddWithValue("@orden", obj.orden);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void delete(Ddjjs obj)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("DELETE  Ddjjs ");
                stringBuilder.AppendLine("WHERE");
                stringBuilder.AppendLine("id=@id");
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@id", obj.id);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
