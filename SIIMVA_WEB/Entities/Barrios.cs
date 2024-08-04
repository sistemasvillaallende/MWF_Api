// Decompiled with JetBrains decompiler
// Type: MOTOR_WORKFLOW.Entities.Barrios
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
    public class Barrios : DALBase
    {
        public int COD_BARRIO { get; set; }

        public string NOM_BARRIO { get; set; }

        public short BarrioCerrado { get; set; }

        public Barrios()
        {
            this.COD_BARRIO = 0;
            this.NOM_BARRIO = string.Empty;
            this.BarrioCerrado = (short)0;
        }

        private static List<Barrios> mapeo(SqlDataReader dr)
        {
            List<Barrios> barriosList = new List<Barrios>();
            if (dr.HasRows)
            {
                int ordinal1 = dr.GetOrdinal("COD_BARRIO");
                int ordinal2 = dr.GetOrdinal("NOM_BARRIO");
                int ordinal3 = dr.GetOrdinal("BarrioCerrado");
                while (dr.Read())
                {
                    Barrios barrios = new Barrios();
                    if (!dr.IsDBNull(ordinal1))
                        barrios.COD_BARRIO = dr.GetInt32(ordinal1);
                    if (!dr.IsDBNull(ordinal2))
                        barrios.NOM_BARRIO = dr.GetString(ordinal2);
                    if (!dr.IsDBNull(ordinal3))
                        barrios.BarrioCerrado = dr.GetInt16(ordinal3);
                    barriosList.Add(barrios);
                }
            }
            return barriosList;
        }

        public static List<Combo> read()
        {
            try
            {
                List<Combo> comboList = new List<Combo>();
                using (SqlConnection connectionSiimva = DALBase.GetConnectionSIIMVA())
                {
                    SqlCommand command = connectionSiimva.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT *FROM Barrios ORDER BY NOM_BARRIO ASC";
                    command.Connection.Open();
                    return Barrios.mapeoReducido(command.ExecuteReader());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static List<Combo> mapeoReducido(SqlDataReader dr)
        {
            List<Combo> comboList = new List<Combo>();
            if (dr.HasRows)
            {
                int ordinal1 = dr.GetOrdinal("COD_BARRIO");
                int ordinal2 = dr.GetOrdinal("NOM_BARRIO");
                while (dr.Read())
                {
                    Combo combo = new Combo();
                    if (!dr.IsDBNull(ordinal1))
                        combo.value = dr.GetInt32(ordinal1).ToString();
                    if (!dr.IsDBNull(ordinal2))
                        combo.text = dr.GetString(ordinal2);
                    comboList.Add(combo);
                }
            }
            return comboList;
        }

        public static Barrios getByPk(int COD_BARRIO)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("SELECT *FROM Barrios WHERE");
                stringBuilder.AppendLine("COD_BARRIO = @COD_BARRIO");
                Barrios byPk = (Barrios)null;
                using (SqlConnection connectionSiimva = DALBase.GetConnectionSIIMVA())
                {
                    SqlCommand command = connectionSiimva.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@COD_BARRIO", COD_BARRIO);
                    command.Connection.Open();
                    List<Barrios> barriosList = Barrios.mapeo(command.ExecuteReader());
                    if (barriosList.Count != 0)
                        byPk = barriosList[0];
                }
                return byPk;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int insert(Barrios obj)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("INSERT INTO Barrios(");
                stringBuilder.AppendLine("COD_BARRIO");
                stringBuilder.AppendLine(", NOM_BARRIO");
                stringBuilder.AppendLine(", BarrioCerrado");
                stringBuilder.AppendLine(")");
                stringBuilder.AppendLine("VALUES");
                stringBuilder.AppendLine("(");
                stringBuilder.AppendLine("@COD_BARRIO");
                stringBuilder.AppendLine(", @NOM_BARRIO");
                stringBuilder.AppendLine(", @BarrioCerrado");
                stringBuilder.AppendLine(")");
                using (SqlConnection connectionSiimva = DALBase.GetConnectionSIIMVA())
                {
                    SqlCommand command = connectionSiimva.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@COD_BARRIO", obj.COD_BARRIO);
                    command.Parameters.AddWithValue("@NOM_BARRIO", obj.NOM_BARRIO);
                    command.Parameters.AddWithValue("@BarrioCerrado", obj.BarrioCerrado);
                    command.Connection.Open();
                    return command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void update(Barrios obj)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("UPDATE  Barrios SET");
                stringBuilder.AppendLine("NOM_BARRIO=@NOM_BARRIO");
                stringBuilder.AppendLine(", BarrioCerrado=@BarrioCerrado");
                stringBuilder.AppendLine("WHERE");
                stringBuilder.AppendLine("COD_BARRIO=@COD_BARRIO");
                using (SqlConnection connectionSiimva = DALBase.GetConnectionSIIMVA())
                {
                    SqlCommand command = connectionSiimva.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@COD_BARRIO", obj.COD_BARRIO);
                    command.Parameters.AddWithValue("@NOM_BARRIO", obj.NOM_BARRIO);
                    command.Parameters.AddWithValue("@BarrioCerrado", obj.BarrioCerrado);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void delete(Barrios obj)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("DELETE  Barrios ");
                stringBuilder.AppendLine("WHERE");
                stringBuilder.AppendLine("COD_BARRIO=@COD_BARRIO");
                using (SqlConnection connectionSiimva = DALBase.GetConnectionSIIMVA())
                {
                    SqlCommand command = connectionSiimva.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@COD_BARRIO", obj.COD_BARRIO);
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
