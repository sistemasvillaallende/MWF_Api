using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

#nullable enable
namespace MOTOR_WORKFLOW.Entities
{
    public class Calles : DALBase
    {
        public int cod_calle { get; set; }

        public string nom_calle { get; set; }

        public int cod_barrio { get; set; }

        public Calles()
        {
            this.cod_calle = 0;
            this.nom_calle = string.Empty;
        }

        private static List<Calles> mapeo(SqlDataReader dr)
        {
            List<Calles> callesList = new List<Calles>();
            if (dr.HasRows)
            {
                int ordinal1 = dr.GetOrdinal("COD_CALLE");
                int ordinal2 = dr.GetOrdinal("NOM_CALLE");
                int ordinal3 = dr.GetOrdinal("cod_barrio");
                while (dr.Read())
                {
                    Calles calles = new Calles();
                    if (!dr.IsDBNull(ordinal1))
                        calles.cod_calle = dr.GetInt32(ordinal1);
                    if (!dr.IsDBNull(ordinal2))
                        calles.nom_calle = dr.GetString(ordinal2);
                    if (!dr.IsDBNull(ordinal3))
                        calles.cod_barrio = dr.GetInt32(ordinal3);
                    callesList.Add(calles);
                }
            }
            return callesList;
        }

        private static List<Combo> mapeoReducido(SqlDataReader dr)
        {
            List<Combo> comboList = new List<Combo>();
            if (dr.HasRows)
            {
                int ordinal1 = dr.GetOrdinal("COD_CALLE");
                int ordinal2 = dr.GetOrdinal("NOM_CALLE");
                int ordinal3 = dr.GetOrdinal("cod_barrio");
                while (dr.Read())
                {
                    Combo combo1 = new Combo();
                    int int32;
                    if (!dr.IsDBNull(ordinal1))
                    {
                        Combo combo2 = combo1;
                        int32 = dr.GetInt32(ordinal1);
                        string str = int32.ToString();
                        combo2.value = str;
                    }
                    if (!dr.IsDBNull(ordinal2))
                        combo1.text = dr.GetString(ordinal2);
                    if (!dr.IsDBNull(ordinal3))
                    {
                        Combo combo3 = combo1;
                        int32 = dr.GetInt32(ordinal3);
                        string str = int32.ToString();
                        combo3.cod_enlaza = str;
                    }
                    comboList.Add(combo1);
                }
            }
            return comboList;
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
                    command.CommandText = @"
                            SELECT A.*, B.COD_BARRIO FROM Calles A                 
                            INNER JOIN CALLES_X_BARRIO B ON
                            A.COD_CALLE=B.cod_calle
                            ORDER BY A.NOM_CALLE ASC";
                    command.Connection.Open();
                    return Calles.mapeoReducido(command.ExecuteReader());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<Calles> read(int cod_barrio)
        {
            try
            {
                List<Calles> callesList = new List<Calles>();
                using (SqlConnection connectionSiimva = DALBase.GetConnectionSIIMVA())
                {
                    SqlCommand command = connectionSiimva.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = @"
                        SELECT A.*, B.COD_BARRIO FROM Calles A
                        INNER JOIN CALLES_X_BARRIO B ON A.COD_CALLE=B.cod_calle
                        WHERE B.cod_barrio=@COD_BARRIO
                        ORDER BY A.NOM_CALLE ASC";
                    command.Parameters.AddWithValue("@cod_barrio", cod_barrio);
                    command.Connection.Open();
                    return Calles.mapeo(command.ExecuteReader());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Calles getByPk(int COD_CALLE)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                Calles byPk = (Calles)null;
                using (SqlConnection connectionSiimva = DALBase.GetConnectionSIIMVA())
                {
                    SqlCommand command = connectionSiimva.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = @"
                            SELECT A.*, B.COD_BARRIO FROM Calles A
                            INNER JOIN CALLES_X_BARRIO B ON A.COD_CALLE=B.cod_calle
                            WHERE B.COD_CALLE=@COD_CALLE
                            ORDER BY NOM_CALLE";
                    command.Parameters.AddWithValue("@COD_CALLE", COD_CALLE);
                    command.Connection.Open();
                    List<Calles> callesList = Calles.mapeo(command.ExecuteReader());
                    if (callesList.Count != 0)
                        byPk = callesList[0];
                }
                return byPk;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
