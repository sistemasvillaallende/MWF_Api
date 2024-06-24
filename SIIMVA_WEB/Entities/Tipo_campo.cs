// Decompiled with JetBrains decompiler
// Type: MOTOR_WORKFLOW.Entities.Tipo_campo
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
    public class Tipo_campo : DALBase
    {
        public int id { get; set; }

        public string nombre { get; set; }

        public Tipo_campo()
        {
            this.id = 0;
            this.nombre = string.Empty;
        }

        private static List<Tipo_campo> mapeo(SqlDataReader dr)
        {
            List<Tipo_campo> tipoCampoList = new List<Tipo_campo>();
            if (dr.HasRows)
            {
                int ordinal1 = dr.GetOrdinal("id");
                int ordinal2 = dr.GetOrdinal("nombre");
                while (dr.Read())
                {
                    Tipo_campo tipoCampo = new Tipo_campo();
                    if (!dr.IsDBNull(ordinal1))
                        tipoCampo.id = dr.GetInt32(ordinal1);
                    if (!dr.IsDBNull(ordinal2))
                        tipoCampo.nombre = dr.GetString(ordinal2);
                    tipoCampoList.Add(tipoCampo);
                }
            }
            return tipoCampoList;
        }

        public static List<Tipo_campo> read()
        {
            try
            {
                List<Tipo_campo> tipoCampoList = new List<Tipo_campo>();
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT *FROM Tipo_campo";
                    command.Connection.Open();
                    return Tipo_campo.mapeo(command.ExecuteReader());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Tipo_campo getByPk(int ID)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("SELECT *FROM Tipo_campo WHERE");
                stringBuilder.AppendLine("id = @id");
                Tipo_campo byPk = (Tipo_campo)null;
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@id", (object)ID);
                    command.Connection.Open();
                    List<Tipo_campo> tipoCampoList = Tipo_campo.mapeo(command.ExecuteReader());
                    if (tipoCampoList.Count != 0)
                        byPk = tipoCampoList[0];
                }
                return byPk;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int insert(Tipo_campo obj)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("INSERT INTO Tipo_campo(");
                stringBuilder.AppendLine("nombre");
                stringBuilder.AppendLine(")");
                stringBuilder.AppendLine("VALUES");
                stringBuilder.AppendLine("(");
                stringBuilder.AppendLine("@nombre");
                stringBuilder.AppendLine(")");
                stringBuilder.AppendLine("SELECT SCOPE_IDENTITY()");
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@nombre", (object)obj.nombre);
                    command.Connection.Open();
                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void update(Tipo_campo obj)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("UPDATE  Tipo_campo SET");
                stringBuilder.AppendLine("nombre=@nombre");
                stringBuilder.AppendLine("WHERE");
                stringBuilder.AppendLine("id=@id");
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@nombre", (object)obj.nombre);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void delete(Tipo_campo obj)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("DELETE  Tipo_campo ");
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
    }
}
