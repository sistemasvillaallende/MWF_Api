// Decompiled with JetBrains decompiler
// Type: MOTOR_WORKFLOW.Entities.Oficinas
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
    public class Oficinas : DALBase
    {
        public int codigo_oficina { get; set; }

        public string nombre_oficina { get; set; }

        public bool secretaria { get; set; }

        public bool activo { get; set; }

        public string subsistema { get; set; }

        public short vecino_digital { get; set; }

        public short Genera_multas { get; set; }

        public Oficinas()
        {
            this.codigo_oficina = 0;
            this.nombre_oficina = string.Empty;
            this.secretaria = false;
            this.activo = false;
            this.subsistema = string.Empty;
            this.vecino_digital = (short)0;
            this.Genera_multas = (short)0;
        }

        private static List<Oficinas> mapeo(SqlDataReader dr)
        {
            List<Oficinas> oficinasList = new List<Oficinas>();
            if (dr.HasRows)
            {
                int ordinal1 = dr.GetOrdinal("codigo_oficina");
                int ordinal2 = dr.GetOrdinal("nombre_oficina");
                int ordinal3 = dr.GetOrdinal("secretaria");
                int ordinal4 = dr.GetOrdinal("activo");
                int ordinal5 = dr.GetOrdinal("subsistema");
                int ordinal6 = dr.GetOrdinal("vecino_digital");
                int ordinal7 = dr.GetOrdinal("Genera_multas");
                while (dr.Read())
                {
                    Oficinas oficinas = new Oficinas();
                    if (!dr.IsDBNull(ordinal1))
                        oficinas.codigo_oficina = dr.GetInt32(ordinal1);
                    if (!dr.IsDBNull(ordinal2))
                        oficinas.nombre_oficina = dr.GetString(ordinal2);
                    if (!dr.IsDBNull(ordinal3))
                        oficinas.secretaria = dr.GetBoolean(ordinal3);
                    if (!dr.IsDBNull(ordinal4))
                        oficinas.activo = dr.GetBoolean(ordinal4);
                    if (!dr.IsDBNull(ordinal5))
                        oficinas.subsistema = dr.GetString(ordinal5);
                    if (!dr.IsDBNull(ordinal6))
                        oficinas.vecino_digital = dr.GetInt16(ordinal6);
                    if (!dr.IsDBNull(ordinal7))
                        oficinas.Genera_multas = dr.GetInt16(ordinal7);
                    oficinasList.Add(oficinas);
                }
            }
            return oficinasList;
        }

        public static List<Oficinas> read()
        {
            try
            {
                List<Oficinas> oficinasList = new List<Oficinas>();
                using (SqlConnection connectionSiimva = DALBase.GetConnectionSIIMVA())
                {
                    SqlCommand command = connectionSiimva.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT *FROM Oficinas ORDER BY nombre_oficina";
                    command.Connection.Open();
                    return Oficinas.mapeo(command.ExecuteReader());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Oficinas getByPk(int codigo_oficina)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("SELECT *FROM Oficinas WHERE");
                stringBuilder.AppendLine("codigo_oficina = @codigo_oficina");
                Oficinas byPk = (Oficinas)null;
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@codigo_oficina", codigo_oficina);
                    command.Connection.Open();
                    List<Oficinas> oficinasList = Oficinas.mapeo(command.ExecuteReader());
                    if (oficinasList.Count != 0)
                        byPk = oficinasList[0];
                }
                return byPk;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int insert(Oficinas obj)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("INSERT INTO Oficinas(");
                stringBuilder.AppendLine("codigo_oficina");
                stringBuilder.AppendLine(", nombre_oficina");
                stringBuilder.AppendLine(", secretaria");
                stringBuilder.AppendLine(", activo");
                stringBuilder.AppendLine(", subsistema");
                stringBuilder.AppendLine(", vecino_digital");
                stringBuilder.AppendLine(", Genera_multas");
                stringBuilder.AppendLine(")");
                stringBuilder.AppendLine("VALUES");
                stringBuilder.AppendLine("(");
                stringBuilder.AppendLine("@codigo_oficina");
                stringBuilder.AppendLine(", @nombre_oficina");
                stringBuilder.AppendLine(", @secretaria");
                stringBuilder.AppendLine(", @activo");
                stringBuilder.AppendLine(", @subsistema");
                stringBuilder.AppendLine(", @vecino_digital");
                stringBuilder.AppendLine(", @Genera_multas");
                stringBuilder.AppendLine(")");
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@codigo_oficina", obj.codigo_oficina);
                    command.Parameters.AddWithValue("@nombre_oficina", obj.nombre_oficina);
                    command.Parameters.AddWithValue("@secretaria", obj.secretaria);
                    command.Parameters.AddWithValue("@activo", obj.activo);
                    command.Parameters.AddWithValue("@subsistema", obj.subsistema);
                    command.Parameters.AddWithValue("@vecino_digital", obj.vecino_digital);
                    command.Parameters.AddWithValue("@Genera_multas", obj.Genera_multas);
                    command.Connection.Open();
                    return command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void update(Oficinas obj)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("UPDATE  Oficinas SET");
                stringBuilder.AppendLine("nombre_oficina=@nombre_oficina");
                stringBuilder.AppendLine(", secretaria=@secretaria");
                stringBuilder.AppendLine(", activo=@activo");
                stringBuilder.AppendLine(", subsistema=@subsistema");
                stringBuilder.AppendLine(", vecino_digital=@vecino_digital");
                stringBuilder.AppendLine(", Genera_multas=@Genera_multas");
                stringBuilder.AppendLine("WHERE");
                stringBuilder.AppendLine("codigo_oficina=@codigo_oficina");
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@codigo_oficina", obj.codigo_oficina);
                    command.Parameters.AddWithValue("@nombre_oficina", obj.nombre_oficina);
                    command.Parameters.AddWithValue("@secretaria", obj.secretaria);
                    command.Parameters.AddWithValue("@activo", obj.activo);
                    command.Parameters.AddWithValue("@subsistema", obj.subsistema);
                    command.Parameters.AddWithValue("@vecino_digital", obj.vecino_digital);
                    command.Parameters.AddWithValue("@Genera_multas", obj.Genera_multas);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void delete(Oficinas obj)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("DELETE  Oficinas ");
                stringBuilder.AppendLine("WHERE");
                stringBuilder.AppendLine("codigo_oficina=@codigo_oficina");
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@codigo_oficina", obj.codigo_oficina);
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
