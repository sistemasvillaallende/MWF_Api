// Decompiled with JetBrains decompiler
// Type: MOTOR_WORKFLOW.Entities.Pasos
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
    public class Pasos : DALBase
    {
        public int id { get; set; }

        public int id_tramites { get; set; }

        public int id_paso { get; set; }

        public int orden_paso { get; set; }

        public int id_ingreso_paso { get; set; }

        public int orden_ingreso_paso { get; set; }

        public string nombre_ingreso_paso { get; set; }

        public int row { get; set; }

        public int col { get; set; }

        public int id_formulario { get; set; }

        public int id_adjunto { get; set; }

        public int id_ddjj { get; set; }

        public Formularios objFormulario { get; set; }

        public Ddjjs objDDJJs { get; set; }

        public Adjuntos objAdjuntos { get; set; }

        public Pasos()
        {
            this.id = 0;
            this.id_tramites = 0;
            this.id_paso = 0;
            this.orden_paso = 0;
            this.id_ingreso_paso = 0;
            this.orden_ingreso_paso = 0;
            this.nombre_ingreso_paso = string.Empty;
            this.row = 0;
            this.col = 0;
            this.id_formulario = 0;
            this.id_adjunto = 0;
            this.id_ddjj = 0;
            this.objFormulario = new Formularios();
            this.objDDJJs = new Ddjjs();
            this.objAdjuntos = new Adjuntos();
        }

        private static List<Pasos> mapeo(SqlDataReader dr)
        {
            List<Pasos> pasosList = new List<Pasos>();
            if (dr.HasRows)
            {
                int ordinal1 = dr.GetOrdinal("id");
                int ordinal2 = dr.GetOrdinal("id_tramites");
                int ordinal3 = dr.GetOrdinal("id_paso");
                int ordinal4 = dr.GetOrdinal("orden_paso");
                int ordinal5 = dr.GetOrdinal("id_ingreso_paso");
                int ordinal6 = dr.GetOrdinal("orden_ingreso_paso");
                int ordinal7 = dr.GetOrdinal("nombre_ingreso_paso");
                int ordinal8 = dr.GetOrdinal("row");
                int ordinal9 = dr.GetOrdinal("col");
                int ordinal10 = dr.GetOrdinal("id_formulario");
                int ordinal11 = dr.GetOrdinal("id_adjunto");
                int ordinal12 = dr.GetOrdinal("id_ddjj");
                while (dr.Read())
                {
                    Pasos pasos = new Pasos();
                    if (!dr.IsDBNull(ordinal1))
                        pasos.id = dr.GetInt32(ordinal1);
                    if (!dr.IsDBNull(ordinal2))
                        pasos.id_tramites = dr.GetInt32(ordinal2);
                    if (!dr.IsDBNull(ordinal3))
                        pasos.id_paso = dr.GetInt32(ordinal3);
                    if (!dr.IsDBNull(ordinal4))
                        pasos.orden_paso = dr.GetInt32(ordinal4);
                    if (!dr.IsDBNull(ordinal5))
                        pasos.id_ingreso_paso = dr.GetInt32(ordinal5);
                    if (!dr.IsDBNull(ordinal6))
                        pasos.orden_ingreso_paso = dr.GetInt32(ordinal6);
                    if (!dr.IsDBNull(ordinal7))
                        pasos.nombre_ingreso_paso = dr.GetString(ordinal7);
                    if (!dr.IsDBNull(ordinal8))
                        pasos.row = dr.GetInt32(ordinal8);
                    if (!dr.IsDBNull(ordinal9))
                        pasos.col = dr.GetInt32(ordinal9);
                    if (!dr.IsDBNull(ordinal10))
                        pasos.id_formulario = dr.GetInt32(ordinal10);
                    if (!dr.IsDBNull(ordinal11))
                        pasos.id_adjunto = dr.GetInt32(ordinal11);
                    if (!dr.IsDBNull(ordinal12))
                        pasos.id_ddjj = dr.GetInt32(ordinal12);
                    if (pasos.id_formulario != 0)
                        pasos.objFormulario = Formularios.getByIdPasos(pasos.id);
                    if (pasos.id_adjunto != 0)
                        pasos.objAdjuntos = Adjuntos.getByIdPasos(pasos.id);
                    if (pasos.id_ddjj != 0)
                        pasos.objDDJJs = Ddjjs.getByIdPasos(pasos.id);
                    pasosList.Add(pasos);
                }
            }
            return pasosList;
        }

        public static List<Pasos> read(int id_tramites)
        {
            try
            {
                List<Pasos> pasosList = new List<Pasos>();
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT *FROM Pasos WHERE id_tramites=@id_tramites";
                    command.Parameters.AddWithValue("@id_tramites", (object)id_tramites);
                    command.Connection.Open();
                    return Pasos.mapeo(command.ExecuteReader());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Pasos getByPk(int id)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                Pasos byPk = (Pasos)null;
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT *FROM PASOS WHERE ID=@ID";
                    command.Parameters.AddWithValue("@ID", (object)id);
                    command.Connection.Open();
                    List<Pasos> pasosList = Pasos.mapeo(command.ExecuteReader());
                    if (pasosList.Count != 0)
                        byPk = pasosList[0];
                }
                return byPk;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int insert(Pasos obj)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("INSERT INTO Pasos(");
                stringBuilder.AppendLine("id_tramites");
                stringBuilder.AppendLine(", id_paso");
                stringBuilder.AppendLine(", orden_paso");
                stringBuilder.AppendLine(", id_ingreso_paso");
                stringBuilder.AppendLine(", orden_ingreso_paso");
                stringBuilder.AppendLine(", nombre_ingreso_paso");
                stringBuilder.AppendLine(", row");
                stringBuilder.AppendLine(", col");
                stringBuilder.AppendLine(", id_formulario");
                stringBuilder.AppendLine(", id_adjunto");
                stringBuilder.AppendLine(", id_ddjj");
                stringBuilder.AppendLine(")");
                stringBuilder.AppendLine("VALUES");
                stringBuilder.AppendLine("(");
                stringBuilder.AppendLine("@id_tramites");
                stringBuilder.AppendLine(", @id_paso");
                stringBuilder.AppendLine(", @orden_paso");
                stringBuilder.AppendLine(", @id_ingreso_paso");
                stringBuilder.AppendLine(", @orden_ingreso_paso");
                stringBuilder.AppendLine(", @nombre_ingreso_paso");
                stringBuilder.AppendLine(", @row");
                stringBuilder.AppendLine(", @col");
                stringBuilder.AppendLine(", @id_formulario");
                stringBuilder.AppendLine(", @id_adjunto");
                stringBuilder.AppendLine(", @id_ddjj");
                stringBuilder.AppendLine(")");
                stringBuilder.AppendLine("SELECT SCOPE_IDENTITY()");
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@id_tramites", (object)obj.id_tramites);
                    command.Parameters.AddWithValue("@id_paso", (object)obj.id_paso);
                    command.Parameters.AddWithValue("@orden_paso", (object)obj.orden_paso);
                    command.Parameters.AddWithValue("@id_ingreso_paso", (object)obj.id_ingreso_paso);
                    command.Parameters.AddWithValue("@orden_ingreso_paso", (object)obj.orden_ingreso_paso);
                    command.Parameters.AddWithValue("@nombre_ingreso_paso", (object)obj.nombre_ingreso_paso);
                    command.Parameters.AddWithValue("@row", (object)obj.row);
                    command.Parameters.AddWithValue("@col", (object)obj.col);
                    command.Parameters.AddWithValue("@id_formulario", (object)obj.id_formulario);
                    command.Parameters.AddWithValue("@id_adjunto", (object)obj.id_adjunto);
                    command.Parameters.AddWithValue("@id_ddjj", (object)obj.id_ddjj);
                    command.Connection.Open();
                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void update(Pasos obj)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("UPDATE  Pasos SET");
                stringBuilder.AppendLine("id_tramites=@id_tramites");
                stringBuilder.AppendLine(", id_paso=@id_paso");
                stringBuilder.AppendLine(", orden_paso=@orden_paso");
                stringBuilder.AppendLine(", id_ingreso_paso=@id_ingreso_paso");
                stringBuilder.AppendLine(", orden_ingreso_paso=@orden_ingreso_paso");
                stringBuilder.AppendLine(", nombre_ingreso_paso=@nombre_ingreso_paso");
                stringBuilder.AppendLine(", row=@row");
                stringBuilder.AppendLine(", col=@col");
                stringBuilder.AppendLine(", id_formulario=@id_formulario");
                stringBuilder.AppendLine(", id_adjunto=@id_adjunto");
                stringBuilder.AppendLine(", id_ddjj=@id_ddjj");
                stringBuilder.AppendLine("WHERE");
                stringBuilder.AppendLine("id=@id");
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@id_tramites", (object)obj.id_tramites);
                    command.Parameters.AddWithValue("@id_paso", (object)obj.id_paso);
                    command.Parameters.AddWithValue("@orden_paso", (object)obj.orden_paso);
                    command.Parameters.AddWithValue("@id_ingreso_paso", (object)obj.id_ingreso_paso);
                    command.Parameters.AddWithValue("@orden_ingreso_paso", (object)obj.orden_ingreso_paso);
                    command.Parameters.AddWithValue("@nombre_ingreso_paso", (object)obj.nombre_ingreso_paso);
                    command.Parameters.AddWithValue("@row", (object)obj.row);
                    command.Parameters.AddWithValue("@col", (object)obj.col);
                    command.Parameters.AddWithValue("@id_formulario", (object)obj.id_formulario);
                    command.Parameters.AddWithValue("@id_adjunto", (object)obj.id_adjunto);
                    command.Parameters.AddWithValue("@id_ddjj", (object)obj.id_ddjj);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void delete(Pasos obj)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("DELETE  Pasos ");
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
