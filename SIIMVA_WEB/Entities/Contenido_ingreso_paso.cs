// Decompiled with JetBrains decompiler
// Type: MOTOR_WORKFLOW.Entities.contenido_ingreso_paso
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
    public class contenido_ingreso_paso : DALBase
    {
        public int id { get; set; }

        public int id_ingreso_paso { get; set; }

        public int id_formulario { get; set; }

        public int id_adjunto { get; set; }

        public int id_ddjj { get; set; }

        public int orden { get; set; }

        public int row { get; set; }

        public int col { get; set; }

        public bool activo { get; set; }

        public Formulario objFormulario { get; set; }

        public Adjunto objAdjunto { get; set; }

        public ddjj objDDJJ { get; set; }

        public contenido_ingreso_paso()
        {
            this.id = 0;
            this.id_ingreso_paso = 0;
            this.id_formulario = 0;
            this.id_adjunto = 0;
            this.id_ddjj = 0;
            this.orden = 0;
            this.row = 0;
            this.col = 0;
            this.activo = false;
            this.objFormulario = new Formulario();
            this.objAdjunto = new Adjunto();
            this.objDDJJ = new ddjj();
        }

        private static List<contenido_ingreso_paso> mapeo(SqlDataReader dr)
        {
            List<contenido_ingreso_paso> contenidoIngresoPasoList = new List<contenido_ingreso_paso>();
            if (dr.HasRows)
            {
                int ordinal1 = dr.GetOrdinal("id");
                int ordinal2 = dr.GetOrdinal("id_ingreso_paso");
                int ordinal3 = dr.GetOrdinal("id_formulario");
                int ordinal4 = dr.GetOrdinal("id_adjunto");
                int ordinal5 = dr.GetOrdinal("id_ddjj");
                int ordinal6 = dr.GetOrdinal("orden");
                int ordinal7 = dr.GetOrdinal("row");
                int ordinal8 = dr.GetOrdinal("col");
                int ordinal9 = dr.GetOrdinal("activo");
                while (dr.Read())
                {
                    contenido_ingreso_paso contenidoIngresoPaso = new contenido_ingreso_paso();
                    if (!dr.IsDBNull(ordinal1))
                        contenidoIngresoPaso.id = dr.GetInt32(ordinal1);
                    if (!dr.IsDBNull(ordinal2))
                        contenidoIngresoPaso.id_ingreso_paso = dr.GetInt32(ordinal2);
                    if (!dr.IsDBNull(ordinal3))
                        contenidoIngresoPaso.id_formulario = dr.GetInt32(ordinal3);
                    if (!dr.IsDBNull(ordinal4))
                        contenidoIngresoPaso.id_adjunto = dr.GetInt32(ordinal4);
                    if (!dr.IsDBNull(ordinal5))
                        contenidoIngresoPaso.id_ddjj = dr.GetInt32(ordinal5);
                    if (!dr.IsDBNull(ordinal6))
                        contenidoIngresoPaso.orden = dr.GetInt32(ordinal6);
                    if (!dr.IsDBNull(ordinal7))
                        contenidoIngresoPaso.row = dr.GetInt32(ordinal7);
                    if (!dr.IsDBNull(ordinal8))
                        contenidoIngresoPaso.col = dr.GetInt32(ordinal8);
                    if (!dr.IsDBNull(ordinal9))
                        contenidoIngresoPaso.activo = dr.GetBoolean(ordinal9);
                    if (contenidoIngresoPaso.id_formulario != 0)
                        contenidoIngresoPaso.objFormulario = Formulario.getByPk(contenidoIngresoPaso.id_formulario);
                    if (contenidoIngresoPaso.id_adjunto != 0)
                        contenidoIngresoPaso.objAdjunto = Adjunto.getByPk(contenidoIngresoPaso.id_adjunto);
                    if (contenidoIngresoPaso.id_ddjj != 0)
                        contenidoIngresoPaso.objDDJJ = ddjj.getByPk(contenidoIngresoPaso.id_ddjj);
                    contenidoIngresoPasoList.Add(contenidoIngresoPaso);
                }
            }
            return contenidoIngresoPasoList;
        }

        public static List<contenido_ingreso_paso> read(int idIngresoPaso)
        {
            try
            {
                List<contenido_ingreso_paso> contenidoIngresoPasoList = new List<contenido_ingreso_paso>();
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = @"
                            SELECT A.*, B.id AS id_formulario,
                                C.id AS id_adjunto,
                                D.id AS id_ddjj
                            FROM contenido_ingreso_paso A
                                LEFT JOIN FORMULARIO B ON A.id=B.id_contenido_ingreso_paso
                                LEFT JOIN ADJUNTO C ON A.id=C.id_contenido_ingreso_paso
                                LEFT JOIN DDJJ D ON A.id=D.id_contenido_ingreso_paso
                            WHERE id_ingreso_paso=@id_ingreso_paso";
                    command.Parameters.AddWithValue("@id_ingreso_paso", idIngresoPaso);
                    command.Connection.Open();
                    return contenido_ingreso_paso.mapeo(command.ExecuteReader());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static contenido_ingreso_paso getByPk(int ID)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("SELECT *FROM contenido_ingreso_paso WHERE");
                stringBuilder.AppendLine("id = @id");
                contenido_ingreso_paso byPk = (contenido_ingreso_paso)null;
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = @"
                        SELECT A.*, B.id AS id_formulario, C.id AS id_adjunto,
                            D.id AS id_ddjj
                        FROM contenido_ingreso_paso A
                            LEFT JOIN FORMULARIO B ON A.id=B.ID_CONTENIDO_INGRESO_PASO
                            LEFT JOIN ADJUNTO C ON A.id=C.ID_CONTENIDO_INGRESO_PASO
                            LEFT JOIN DDJJ D ON A.id=D.ID_CONTENIDO_INGRESO_PASO
                        WHERE A.id=@id";
                    command.Parameters.AddWithValue("@id", ID);
                    command.Connection.Open();
                    List<contenido_ingreso_paso> contenidoIngresoPasoList = contenido_ingreso_paso.mapeo(command.ExecuteReader());
                    if (contenidoIngresoPasoList.Count != 0)
                        byPk = contenidoIngresoPasoList[0];
                }
                return byPk;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int maxOrden(int id_ingreso_paso)
        {
            try
            {
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = @"
                            SELECT ISNULL(MAX(orden), 0) 
                            FROM contenido_ingreso_paso 
                            WHERE id_ingreso_paso=@id_ingreso_paso";
                    command.Parameters.AddWithValue("@id_ingreso_paso", id_ingreso_paso);
                    command.Connection.Open();
                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int maxRow(int id_ingreso_paso)
        {
            try
            {
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = @"
                        SELECT ISNULL(MAX(row), 0)
                        FROM contenido_ingreso_paso
                        WHERE id_ingreso_paso=@id_ingreso_paso";
                    command.Parameters.AddWithValue("@id_ingreso_paso", id_ingreso_paso);
                    command.Connection.Open();
                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void _insert(contenido_ingreso_paso_model obj)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("INSERT INTO contenido_ingreso_paso(");
                stringBuilder.AppendLine("id_ingreso_paso");
                stringBuilder.AppendLine(", orden");
                stringBuilder.AppendLine(", row");
                stringBuilder.AppendLine(", col");
                stringBuilder.AppendLine(", activo");
                stringBuilder.AppendLine(")");
                stringBuilder.AppendLine("VALUES");
                stringBuilder.AppendLine("(");
                stringBuilder.AppendLine("@id_ingreso_paso");
                stringBuilder.AppendLine(", @orden");
                stringBuilder.AppendLine(", @row");
                stringBuilder.AppendLine(", @col");
                stringBuilder.AppendLine(", @activo");
                stringBuilder.AppendLine(")");
                stringBuilder.AppendLine("SELECT SCOPE_IDENTITY()");
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@id_ingreso_paso", obj.id_ingreso_paso);
                    command.Parameters.AddWithValue("@orden", obj.orden);
                    command.Parameters.AddWithValue("@row", obj.row);
                    command.Parameters.AddWithValue("@col", obj.col);
                    command.Parameters.AddWithValue("@activo", obj.activo);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int insert(contenido_ingreso_paso_model obj)
        {
            try
            {
                int num1 = contenido_ingreso_paso.maxOrden(obj.id_ingreso_paso);
                int num2 = contenido_ingreso_paso.maxRow(obj.id_ingreso_paso);
                switch (obj.col)
                {
                    case 3:
                        obj.orden = num1 + 1;
                        obj.row = num2 + 1;
                        contenido_ingreso_paso._insert(obj);
                        obj.orden = num1 + 2;
                        contenido_ingreso_paso._insert(obj);
                        obj.orden = num1 + 3;
                        contenido_ingreso_paso._insert(obj);
                        obj.orden = num1 + 4;
                        contenido_ingreso_paso._insert(obj);
                        break;
                    case 4:
                        obj.orden = num1 + 1;
                        obj.row = num2 + 1;
                        contenido_ingreso_paso._insert(obj);
                        obj.orden = num1 + 2;
                        contenido_ingreso_paso._insert(obj);
                        obj.orden = num1 + 3;
                        contenido_ingreso_paso._insert(obj);
                        break;
                    case 6:
                        obj.orden = num1 + 1;
                        obj.row = num2 + 1;
                        contenido_ingreso_paso._insert(obj);
                        obj.orden = num1 + 2;
                        contenido_ingreso_paso._insert(obj);
                        break;
                    case 12:
                        obj.orden = num1 + 1;
                        obj.row = num2 + 1;
                        contenido_ingreso_paso._insert(obj);
                        break;
                }
                return 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void update(contenido_ingreso_paso obj)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("UPDATE  contenido_ingreso_paso SET");
                stringBuilder.AppendLine("id_ingreso_paso=@id_ingreso_paso");
                stringBuilder.AppendLine(", id_formulario=@id_formulario");
                stringBuilder.AppendLine(", id_adjunto=@id_adjunto");
                stringBuilder.AppendLine(", id_ddjj=@id_ddjj");
                stringBuilder.AppendLine(", orden=@orden");
                stringBuilder.AppendLine(", row=@row");
                stringBuilder.AppendLine(", col=@col");
                stringBuilder.AppendLine(", activo=@activo");
                stringBuilder.AppendLine("WHERE");
                stringBuilder.AppendLine("id=@id");
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@id_ingreso_paso", obj.id_ingreso_paso);
                    command.Parameters.AddWithValue("@id_formulario", obj.id_formulario);
                    command.Parameters.AddWithValue("@id_adjunto", obj.id_adjunto);
                    command.Parameters.AddWithValue("@id_ddjj", obj.id_ddjj);
                    command.Parameters.AddWithValue("@orden", obj.orden);
                    command.Parameters.AddWithValue("@row", obj.row);
                    command.Parameters.AddWithValue("@col", obj.col);
                    command.Parameters.AddWithValue("@activo", obj.activo);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void delete(int id, int row)
        {
            try
            {
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "Sp_contenido_ingreso_x_paso_delete";
                    command.Parameters.AddWithValue("@id_ingreso_x_paso", id);
                    command.Parameters.AddWithValue("@row", row);
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
