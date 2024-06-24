// Decompiled with JetBrains decompiler
// Type: MOTOR_WORKFLOW.Entities.ddjj
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
    public class ddjj : DALBase
    {
        public int id { get; set; }

        public string texto { get; set; }

        public int id_contenido_ingreso_paso { get; set; }

        public ddjj()
        {
            this.id = 0;
            this.texto = string.Empty;
        }

        private static List<ddjj> mapeo(SqlDataReader dr)
        {
            List<ddjj> ddjjList = new List<ddjj>();
            if (dr.HasRows)
            {
                int ordinal1 = dr.GetOrdinal("id");
                int ordinal2 = dr.GetOrdinal("texto");
                int ordinal3 = dr.GetOrdinal("ID_CONTENIDO_INGRESO_PASO");
                while (dr.Read())
                {
                    ddjj ddjj = new ddjj();
                    if (!dr.IsDBNull(ordinal1))
                        ddjj.id = dr.GetInt32(ordinal1);
                    if (!dr.IsDBNull(ordinal2))
                        ddjj.texto = dr.GetString(ordinal2);
                    if (!dr.IsDBNull(ordinal3))
                        ddjj.id_contenido_ingreso_paso = dr.GetInt32(ordinal3);
                    ddjjList.Add(ddjj);
                }
            }
            return ddjjList;
        }

        public static List<ddjj> read()
        {
            try
            {
                List<ddjj> ddjjList = new List<ddjj>();
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT *FROM ddjj";
                    command.Connection.Open();
                    return ddjj.mapeo(command.ExecuteReader());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static ddjj getByPk(int ID)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("SELECT *FROM ddjj WHERE");
                stringBuilder.AppendLine("id = @id");
                ddjj byPk = (ddjj)null;
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@id", (object)ID);
                    command.Connection.Open();
                    List<ddjj> ddjjList = ddjj.mapeo(command.ExecuteReader());
                    if (ddjjList.Count != 0)
                        byPk = ddjjList[0];
                }
                return byPk;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int insert(ddjj obj)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("INSERT INTO ddjj(");
                stringBuilder.AppendLine("texto,");
                stringBuilder.AppendLine("ID_CONTENIDO_INGRESO_PASO)");
                stringBuilder.AppendLine("VALUES");
                stringBuilder.AppendLine("(");
                stringBuilder.AppendLine("@texto,");
                stringBuilder.AppendLine("@ID_CONTENIDO_INGRESO_PASO)");
                stringBuilder.AppendLine("SELECT SCOPE_IDENTITY()");
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@texto", (object)obj.texto);
                    command.Parameters.AddWithValue("@ID_CONTENIDO_INGRESO_PASO", (object)obj.id_contenido_ingreso_paso);
                    command.Connection.Open();
                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void update(ddjj obj)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("UPDATE  ddjj SET");
                stringBuilder.AppendLine("texto=@texto");
                stringBuilder.AppendLine("WHERE");
                stringBuilder.AppendLine("id=@id");
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@texto", (object)obj.texto);
                    command.Parameters.AddWithValue("@id", (object)obj.id);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void delete(ddjj obj)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("DELETE  ddjj ");
                stringBuilder.AppendLine("WHERE");
                stringBuilder.AppendLine("id=@id");
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@id", (object)obj.id);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void delete(int ID_CONTENIDO_INGRESO_PASO)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("DELETE  ddjj ");
                stringBuilder.AppendLine("WHERE");
                stringBuilder.AppendLine("ID_CONTENIDO_INGRESO_PASO=@ID_CONTENIDO_INGRESO_PASO");
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@ID_CONTENIDO_INGRESO_PASO", (object)ID_CONTENIDO_INGRESO_PASO);
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
