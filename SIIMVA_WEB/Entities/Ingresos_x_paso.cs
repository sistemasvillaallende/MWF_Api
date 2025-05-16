// Decompiled with JetBrains decompiler
// Type: MOTOR_WORKFLOW.Entities.ingresos_x_paso
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
    public class ingresos_x_paso : DALBase
    {
        public int id { get; set; }

        public int id_paso { get; set; }

        public string titulo { get; set; }

        public string subtitulo { get; set; }

        public int orden { get; set; }

        public bool activo { get; set; }

        public List<contenido_ingreso_paso> lstContenido { get; set; }

        public ingresos_x_paso()
        {
            this.id = 0;
            this.id_paso = 0;
            this.titulo = string.Empty;
            this.subtitulo = string.Empty;
            this.orden = 0;
            this.activo = true;
            this.lstContenido = new List<contenido_ingreso_paso>();
        }

        private static List<ingresos_x_paso> mapeo(SqlDataReader dr)
        {
            List<ingresos_x_paso> ingresosXPasoList = new List<ingresos_x_paso>();
            if (dr.HasRows)
            {
                int ordinal1 = dr.GetOrdinal("id");
                int ordinal2 = dr.GetOrdinal("id_paso");
                int ordinal3 = dr.GetOrdinal("titulo");
                int ordinal4 = dr.GetOrdinal("subtitulo");
                int ordinal5 = dr.GetOrdinal("orden");
                int ordinal6 = dr.GetOrdinal("activo");
                while (dr.Read())
                {
                    ingresos_x_paso ingresosXPaso = new ingresos_x_paso();
                    if (!dr.IsDBNull(ordinal1))
                        ingresosXPaso.id = dr.GetInt32(ordinal1);
                    if (!dr.IsDBNull(ordinal2))
                        ingresosXPaso.id_paso = dr.GetInt32(ordinal2);
                    if (!dr.IsDBNull(ordinal3))
                        ingresosXPaso.titulo = dr.GetString(ordinal3);
                    if (!dr.IsDBNull(ordinal4))
                        ingresosXPaso.subtitulo = dr.GetString(ordinal4);
                    if (!dr.IsDBNull(ordinal5))
                        ingresosXPaso.orden = dr.GetInt32(ordinal5);
                    if (!dr.IsDBNull(ordinal6))
                        ingresosXPaso.activo = dr.GetBoolean(ordinal6);
                    ingresosXPaso.lstContenido = contenido_ingreso_paso.read(ingresosXPaso.id);
                    ingresosXPasoList.Add(ingresosXPaso);
                }
            }
            return ingresosXPasoList;
        }

        public static List<ingresos_x_paso> read(int idPaso)
        {
            try
            {
                List<ingresos_x_paso> ingresosXPasoList = new List<ingresos_x_paso>();
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT *FROM ingresos_x_paso WHERE id_paso=@id_paso";
                    command.Parameters.AddWithValue("@id_paso", idPaso);
                    command.Connection.Open();
                    return ingresos_x_paso.mapeo(command.ExecuteReader());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static ingresos_x_paso getByPk(int ID)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("SELECT *FROM ingresos_x_paso WHERE");
                stringBuilder.AppendLine("id = @id");
                ingresos_x_paso byPk = (ingresos_x_paso)null;
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@id", ID);
                    command.Connection.Open();
                    List<ingresos_x_paso> ingresosXPasoList = ingresos_x_paso.mapeo(command.ExecuteReader());
                    if (ingresosXPasoList.Count != 0)
                        byPk = ingresosXPasoList[0];
                }
                return byPk;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static ingreso_paso_modelF getByAdjunto(int idAdjunto)
        {
            try
            {
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = @"
                        SELECT A.ID_INGRESO_PASO, C.TITULO, B.NOMBRE, C.ORDEN, A.ROW, A.COL
                        FROM CONTENIDO_INGRESO_PASO A
                            INNER JOIN ADJUNTO B ON B.ID_CONTENIDO_INGRESO_PASO = A.ID
                            INNER JOIN INGRESOS_X_PASO C ON A.ID_INGRESO_PASO=C.ID
                        WHERE B.ID = @ID_ADJUNTO";
                    command.Parameters.AddWithValue("@ID_ADJUNTO", idAdjunto);
                    command.Connection.Open();
                    ingreso_paso_modelF obj = new ingreso_paso_modelF();
                    SqlDataReader dr = command.ExecuteReader();
                    if (dr.HasRows)
                    {
                        int id_ingreso_paso = dr.GetOrdinal("ID_INGRESO_PASO");
                        int nombre_paso = dr.GetOrdinal("TITULO");
                        int nombre_ingreso_paso = dr.GetOrdinal("NOMBRE");
                        int orden = dr.GetOrdinal("ORDEN");
                        int row = dr.GetOrdinal("ROW");
                        int col = dr.GetOrdinal("COL");

                        while (dr.Read())
                        {
                            if (!dr.IsDBNull(id_ingreso_paso))
                                obj.id_ingreso_paso = dr.GetInt32(id_ingreso_paso);
                            if (!dr.IsDBNull(nombre_paso))
                                obj.nombre_paso = dr.GetString(nombre_paso);
                            if (!dr.IsDBNull(nombre_ingreso_paso))
                                obj.nombre_ingreso_paso = dr.GetString(nombre_ingreso_paso);
                            if (!dr.IsDBNull(orden))
                                obj.orden = dr.GetInt32(orden);
                            if (!dr.IsDBNull(row))
                                obj.row = dr.GetInt32(row);
                            if (!dr.IsDBNull(col))
                                obj.col = dr.GetInt32(col);
                        }
                    }
                    return obj;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static ingreso_paso_modelF getByFormulario(int idFormulario)
        {
            try
            {
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = @"
                        SELECT A.ID_INGRESO_PASO, C.TITULO, B.NOMBRE, C.ORDEN, A.ROW, A.COL
                        FROM CONTENIDO_INGRESO_PASO A
                            INNER JOIN FORMULARIO B ON B.ID_CONTENIDO_INGRESO_PASO = A.ID
                            INNER JOIN INGRESOS_X_PASO C ON A.ID_INGRESO_PASO=C.ID
                        WHERE B.ID=@ID_FORMULARIO";
                    command.Parameters.AddWithValue("@ID_FORMULARIO", idFormulario);
                    command.Connection.Open();
                    ingreso_paso_modelF obj = new ingreso_paso_modelF();
                    SqlDataReader dr = command.ExecuteReader();
                    if (dr.HasRows)
                    {
                        int id_ingreso_paso = dr.GetOrdinal("ID_INGRESO_PASO");
                        int nombre_paso = dr.GetOrdinal("TITULO");
                        int nombre_ingreso_paso = dr.GetOrdinal("NOMBRE");
                        int orden = dr.GetOrdinal("ORDEN");
                        int row = dr.GetOrdinal("ROW");
                        int col = dr.GetOrdinal("COL");

                        while (dr.Read())
                        {
                            if (!dr.IsDBNull(id_ingreso_paso))
                                obj.id_ingreso_paso = dr.GetInt32(id_ingreso_paso);
                            if (!dr.IsDBNull(nombre_paso))
                                obj.nombre_paso = dr.GetString(nombre_paso);
                            if (!dr.IsDBNull(nombre_ingreso_paso))
                                obj.nombre_ingreso_paso = dr.GetString(nombre_ingreso_paso);
                            if (!dr.IsDBNull(orden))
                                obj.orden = dr.GetInt32(orden);
                            if (!dr.IsDBNull(row))
                                obj.row = dr.GetInt32(row);
                            if (!dr.IsDBNull(col))
                                obj.col = dr.GetInt32(col);
                        }
                    }
                    return obj;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static int maxOrden(int idPaso)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = @"
                        SELECT ISNULL(MAX(ORDEN), 0)                                
                        FROM INGRESOS_X_PASO                               
                        WHERE ID_PASO = @ID_PASO";
                    command.Parameters.AddWithValue("@ID_PASO", idPaso);
                    command.Connection.Open();
                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string getNombreByPk(int ID)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("SELECT titulo FROM ingresos_x_paso WHERE");
                stringBuilder.AppendLine("id = @id");
                string empty = string.Empty;
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@id", ID);
                    command.Connection.Open();
                    SqlDataReader sqlDataReader = command.ExecuteReader();
                    if (sqlDataReader.HasRows)
                    {
                        int ordinal = sqlDataReader.GetOrdinal("titulo");
                        while (sqlDataReader.Read())
                        {
                            if (!sqlDataReader.IsDBNull(ordinal))
                                empty = sqlDataReader.GetString(ordinal);
                        }
                    }
                }
                return empty;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int insert(ingreso_paso_model obj)
        {
            try
            {
                int num = ingresos_x_paso.maxOrden(obj.id_paso) + 1;
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("INSERT INTO ingresos_x_paso(");
                stringBuilder.AppendLine("id_paso");
                stringBuilder.AppendLine(", titulo");
                stringBuilder.AppendLine(", orden");
                stringBuilder.AppendLine(", activo");
                stringBuilder.AppendLine(")");
                stringBuilder.AppendLine("VALUES");
                stringBuilder.AppendLine("(");
                stringBuilder.AppendLine("@id_paso");
                stringBuilder.AppendLine(", @titulo");
                stringBuilder.AppendLine(", @orden");
                stringBuilder.AppendLine(", 1");
                stringBuilder.AppendLine(")");
                stringBuilder.AppendLine("SELECT SCOPE_IDENTITY()");
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@id_paso", obj.id_paso);
                    command.Parameters.AddWithValue("@titulo", obj.titulo);
                    command.Parameters.AddWithValue("@orden", num);
                    command.Connection.Open();
                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static int insertValidaForm(int id_paso)
        {
            try
            {
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "Sp_genera_form_valida_inmueble";
                    command.Parameters.AddWithValue("@id_paso", id_paso);
                    command.Connection.Open();
                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static int insertValidaPersona(int id_paso)
        {
            try
            {
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "Sp_genera_form_valida_persona";
                    command.Parameters.AddWithValue("@id_paso", id_paso);
                    command.Connection.Open();
                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static int insertMultiNota(int id_paso)
        {
            try
            {
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "Sp_genera_multinota";
                    command.Parameters.AddWithValue("@id_paso", id_paso);
                    command.Connection.Open();
                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void update(ingreso_paso_model obj)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("UPDATE  ingresos_x_paso SET");
                stringBuilder.AppendLine("titulo=@titulo,");
                stringBuilder.AppendLine("subtitulo=@subtitulo");
                stringBuilder.AppendLine("WHERE");
                stringBuilder.AppendLine("id=@id");
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@id", obj.id);
                    command.Parameters.AddWithValue("@titulo", obj.titulo);
                    command.Parameters.AddWithValue("@subtitulo", obj.subtitulo);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void activaDesactiva(ingreso_paso_model obj)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("UPDATE  ingresos_x_paso SET");
                stringBuilder.AppendLine("titulo=@titulo");
                stringBuilder.AppendLine("WHERE");
                stringBuilder.AppendLine("id=@id");
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@id", obj.id);
                    command.Parameters.AddWithValue("@titulo", obj.titulo);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void delete(string id)
        {
            try
            {
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "Sp_ingreso_x_paso_delete";
                    command.Parameters.AddWithValue("@ingreso_x_paso", id);
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
