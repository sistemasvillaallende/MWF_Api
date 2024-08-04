// Decompiled with JetBrains decompiler
// Type: MOTOR_WORKFLOW.Entities.Paso
// Assembly: MOTOR_WORKFLOW, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 007B8F5F-49BB-4EE7-8464-22FD2F567A18
// Assembly location: C:\Muni\DEV\WebApiMWF\MOTOR_WORKFLOW.dll

using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

#nullable enable
namespace MOTOR_WORKFLOW.Entities
{
    public class Paso : DALBase
    {
        public int id { get; set; }

        public int id_tramite { get; set; }

        public int id_oficina { get; set; }

        public int id_direccion { get; set; }

        public int id_secretaria { get; set; }

        public bool en_usuario { get; set; }

        public string nombre { get; set; }

        public string descripcion { get; set; }

        public int orden { get; set; }

        public bool activo { get; set; }

        public bool es_final { get; set; }

        public int proxima_oficina { get; set; }

        public int proxima_oficina_rechazo { get; set; }

        public List<ingresos_x_paso> lstIngresos { get; set; }

        public string nombre_unidad_organizativa { get; set; }

        public string logo_unidad_administrativa { get; set; }

        public string nombre_tramite { get; set; }

        public string nombre_proxima_oficina { get; set; }

        public Paso()
        {
            this.id = 0;
            this.id_tramite = 0;
            this.id_oficina = 0;
            this.id_direccion = 0;
            this.id_secretaria = 0;
            this.en_usuario = false;
            this.nombre = string.Empty;
            this.descripcion = string.Empty;
            this.orden = 0;
            this.activo = false;
            this.nombre_unidad_organizativa = string.Empty;
            this.logo_unidad_administrativa = string.Empty;
            this.nombre_tramite = string.Empty;
            this.es_final = false;
            this.proxima_oficina = 0;
            this.proxima_oficina_rechazo = 0;
        }

        private static List<Paso> mapeoSimple(SqlDataReader dr)
        {
            List<Paso> pasoList = new List<Paso>();
            if (dr.HasRows)
            {
                int ordinal1 = dr.GetOrdinal("id");
                int ordinal2 = dr.GetOrdinal("id_tramite");
                int ordinal3 = dr.GetOrdinal("id_oficina");
                int ordinal4 = dr.GetOrdinal("id_direccion");
                int ordinal5 = dr.GetOrdinal("id_secretaria");
                int ordinal6 = dr.GetOrdinal("en_usuario");
                int ordinal7 = dr.GetOrdinal("nombre");
                int ordinal8 = dr.GetOrdinal("descripcion");
                int ordinal9 = dr.GetOrdinal("orden");
                int ordinal10 = dr.GetOrdinal("activo");
                int ordinal11 = dr.GetOrdinal("es_final");
                int ordinal12 = dr.GetOrdinal("proxima_oficina");
                int ordinal13 = dr.GetOrdinal("proxima_oficina_rechazo");
                int ordinal14 = dr.GetOrdinal("nombre_proxima_oficina");
                int ordinal15 = dr.GetOrdinal("nombre_unidad_organizativa");
                while (dr.Read())
                {
                    Paso paso = new Paso();
                    if (!dr.IsDBNull(ordinal1))
                        paso.id = dr.GetInt32(ordinal1);
                    if (!dr.IsDBNull(ordinal2))
                        paso.id_tramite = dr.GetInt32(ordinal2);
                    if (!dr.IsDBNull(ordinal3))
                        paso.id_oficina = dr.GetInt32(ordinal3);
                    if (!dr.IsDBNull(ordinal4))
                        paso.id_direccion = dr.GetInt32(ordinal4);
                    if (!dr.IsDBNull(ordinal5))
                        paso.id_secretaria = dr.GetInt32(ordinal5);
                    if (!dr.IsDBNull(ordinal6))
                        paso.en_usuario = dr.GetBoolean(ordinal6);
                    if (!dr.IsDBNull(ordinal7))
                        paso.nombre = dr.GetString(ordinal7);
                    if (!dr.IsDBNull(ordinal8))
                        paso.descripcion = dr.GetString(ordinal8);
                    if (!dr.IsDBNull(ordinal9))
                        paso.orden = dr.GetInt32(ordinal9);
                    if (!dr.IsDBNull(ordinal10))
                        paso.activo = dr.GetBoolean(ordinal10);
                    if (!dr.IsDBNull(ordinal11))
                        paso.es_final = dr.GetBoolean(ordinal11);
                    if (!dr.IsDBNull(ordinal12))
                        paso.proxima_oficina = dr.GetInt32(ordinal12);
                    if (!dr.IsDBNull(ordinal13))
                        paso.proxima_oficina_rechazo = dr.GetInt32(ordinal13);
                    if (!dr.IsDBNull(ordinal14))
                        paso.nombre_proxima_oficina = dr.GetString(ordinal14);
                    if (!dr.IsDBNull(ordinal15))
                        paso.nombre_unidad_organizativa = dr.GetString(ordinal15);
                    pasoList.Add(paso);
                }
            }
            return pasoList;
        }

        private static List<Paso> mapeo(SqlDataReader dr)
        {
            List<Paso> pasoList = new List<Paso>();
            if (dr.HasRows)
            {
                int ordinal1 = dr.GetOrdinal("id");
                int ordinal2 = dr.GetOrdinal("id_tramite");
                int ordinal3 = dr.GetOrdinal("id_oficina");
                int ordinal4 = dr.GetOrdinal("id_direccion");
                int ordinal5 = dr.GetOrdinal("id_secretaria");
                int ordinal6 = dr.GetOrdinal("en_usuario");
                int ordinal7 = dr.GetOrdinal("nombre");
                int ordinal8 = dr.GetOrdinal("descripcion");
                int ordinal9 = dr.GetOrdinal("orden");
                int ordinal10 = dr.GetOrdinal("activo");
                int ordinal11 = dr.GetOrdinal("es_final");
                int ordinal12 = dr.GetOrdinal("nombre_unidad_organizativa");
                int ordinal13 = dr.GetOrdinal("logo_unidad_administrativa");
                int ordinal14 = dr.GetOrdinal("nombre_tramite");
                int ordinal15 = dr.GetOrdinal("proxima_oficina");
                int ordinal16 = dr.GetOrdinal("proxima_oficina_rechazo");
                while (dr.Read())
                {
                    Paso paso = new Paso();
                    if (!dr.IsDBNull(ordinal1))
                        paso.id = dr.GetInt32(ordinal1);
                    if (!dr.IsDBNull(ordinal2))
                        paso.id_tramite = dr.GetInt32(ordinal2);
                    if (!dr.IsDBNull(ordinal3))
                        paso.id_oficina = dr.GetInt32(ordinal3);
                    if (!dr.IsDBNull(ordinal4))
                        paso.id_direccion = dr.GetInt32(ordinal4);
                    if (!dr.IsDBNull(ordinal5))
                        paso.id_secretaria = dr.GetInt32(ordinal5);
                    if (!dr.IsDBNull(ordinal6))
                        paso.en_usuario = dr.GetBoolean(ordinal6);
                    if (!dr.IsDBNull(ordinal7))
                        paso.nombre = dr.GetString(ordinal7);
                    if (!dr.IsDBNull(ordinal8))
                        paso.descripcion = dr.GetString(ordinal8);
                    if (!dr.IsDBNull(ordinal9))
                        paso.orden = dr.GetInt32(ordinal9);
                    if (!dr.IsDBNull(ordinal10))
                        paso.activo = dr.GetBoolean(ordinal10);
                    if (!dr.IsDBNull(ordinal11))
                        paso.es_final = dr.GetBoolean(ordinal11);
                    if (!dr.IsDBNull(ordinal15))
                        paso.proxima_oficina = dr.GetInt32(ordinal15);
                    if (!dr.IsDBNull(ordinal16))
                        paso.proxima_oficina_rechazo = dr.GetInt32(ordinal16);
                    if (!dr.IsDBNull(ordinal12))
                        paso.nombre_unidad_organizativa = dr.GetString(ordinal12);
                    if (!dr.IsDBNull(ordinal13))
                        paso.logo_unidad_administrativa = dr.GetString(ordinal13);
                    if (!dr.IsDBNull(ordinal14))
                        paso.nombre_tramite = dr.GetString(ordinal14);
                    paso.lstIngresos = ingresos_x_paso.read(paso.id);
                    pasoList.Add(paso);
                }
            }
            return pasoList;
        }

        public static List<Paso> read(int idTramite)
        {
            try
            {
                List<Paso> pasoList = new List<Paso>();
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = @"
                        SELECT A.*, D.nombre_oficina AS nombre_unidad_organizativa,
                            B.logo_unidad_administrativa,
                            B.NOMBRE AS nombre_tramite
                        FROM PASO A
                            INNER JOIN TRAMITE B ON A.ID_TRAMITE=B.ID
                            LEFT JOIN SIIMVA.dbo.OFICINAS D ON
                            A.id_oficina = D.codigo_oficina
                        WHERE id_tramite=@id_tramite";
                    command.Parameters.AddWithValue("@id_tramite", idTramite);
                    command.Connection.Open();
                    return Paso.mapeo(command.ExecuteReader());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<Paso> readEnUsuario(int idTramite)
        {
            try
            {
                List<Paso> pasoList = new List<Paso>();
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = @"
                        SELECT A.*, D.nombre_oficina AS nombre_unidad_organizativa,
                            B.logo_unidad_administrativa,
                            B.NOMBRE AS nombre_tramite
                        FROM PASO A
                            INNER JOIN TRAMITE B ON A.ID_TRAMITE=B.ID
                            LEFT JOIN SIIMVA.dbo.OFICINAS D ON
                            A.id_oficina = D.codigo_oficina
                        WHERE id_tramite=@id_tramite AND EN_USUARIO = 1";
                    command.Parameters.AddWithValue("@id_tramite", idTramite);
                    command.Connection.Open();
                    return Paso.mapeo(command.ExecuteReader());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<Paso> readBackEnd(int idTramite)
        {
            try
            {
                List<Paso> pasoList = new List<Paso>();
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = @"
                        SELECT A.*, ISNULL(B.nombre_oficina, 'VECINO') AS nombre_unidad_organizativa,
                            ISNULL(C.nombre_oficina, 'VECINO') AS nombre_proxima_oficina
                        FROM PASO A
                            LEFT JOIN SIIMVA.dbo.OFICINAS B ON A.ID_OFICINA=B.codigo_oficina
                            LEFT JOIN SIIMVA.dbo.OFICINAS C ON A.proxima_oficina=C.codigo_oficina
                        WHERE ID_TRAMITE=@id_tramite";
                    command.Parameters.AddWithValue("@id_tramite", idTramite);
                    command.Connection.Open();
                    return Paso.mapeoSimple(command.ExecuteReader());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Paso getByPk(int ID)
        {
            try
            {
                Paso byPk = (Paso)null;
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = @"
                            SELECT A.*, 
                                B.nombre_unidad_organizativa,
                                B.logo_unidad_administrativa,
                                B.NOMBRE AS nombre_tramite
                            FROM PASO A
                                INNER JOIN TRAMITE B ON A.ID_TRAMITE=B.ID
                            WHERE A.ID=@ID";
                    command.Parameters.AddWithValue("@ID", ID);
                    command.Connection.Open();
                    List<Paso> pasoList = Paso.mapeo(command.ExecuteReader());
                    if (pasoList.Count != 0)
                        byPk = pasoList[0];
                }
                return byPk;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Paso getProximo(int id_tramite, int paso_actual)
        {
            try
            {
                Paso proximo = (Paso)null;
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = @"
                        SELECT TOP 1 A.*, B.nombre_unidad_organizativa,
                            B.logo_unidad_administrativa,
                            B.NOMBRE AS nombre_tramite
                        FROM PASO A
                            INNER JOIN TRAMITE B ON A.ID_TRAMITE=B.ID
                        WHERE ID_TRAMITE = @ID_TRAMITE AND ORDEN >
                            (SELECT ORDEN FROM PASO
                            WHERE ID=@paso_actual)
                        ORDER BY ORDEN  ASC";
                    command.Parameters.AddWithValue("@ID_TRAMITE", id_tramite);
                    command.Parameters.AddWithValue("@paso_actual", paso_actual);
                    command.Connection.Open();
                    List<Paso> pasoList = Paso.mapeo(command.ExecuteReader());
                    if (pasoList.Count != 0)
                        proximo = pasoList[0];
                }
                return proximo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int maxOrden(int id_tramite)
        {
            try
            {
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = @"
                        SELECT ISNULL(MAX(ORDEN), 0) FROM Paso
                        WHERE ID_TRAMITE = @ID_TRAMITE";
                    command.Parameters.AddWithValue("@ID_TRAMITE", id_tramite);
                    command.Connection.Open();
                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int insert(PasoModel obj)
        {
            try
            {
                int num = Paso.maxOrden(obj.id_tramite);
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("INSERT INTO Paso(");
                stringBuilder.AppendLine("id_tramite");
                if (obj.id_oficina != 0)
                    stringBuilder.AppendLine(", id_oficina");
                else
                    stringBuilder.AppendLine(", en_usuario");
                stringBuilder.AppendLine(", nombre");
                stringBuilder.AppendLine(", orden");
                stringBuilder.AppendLine(", activo");
                if (obj.es_final)
                    stringBuilder.AppendLine(", es_final");
                else
                    stringBuilder.AppendLine(", proxima_oficina");
                stringBuilder.AppendLine(")");
                stringBuilder.AppendLine("VALUES");
                stringBuilder.AppendLine("(");
                stringBuilder.AppendLine("@id_tramite");
                if (obj.id_oficina != 0)
                    stringBuilder.AppendLine(", @id_oficina");
                else
                    stringBuilder.AppendLine(", @en_usuario");
                stringBuilder.AppendLine(", @nombre");
                stringBuilder.AppendLine(", @orden");
                stringBuilder.AppendLine(", @activo");
                if (obj.es_final)
                    stringBuilder.AppendLine(", @es_final");
                else
                    stringBuilder.AppendLine(", @proxima_oficina");
                stringBuilder.AppendLine(")");
                stringBuilder.AppendLine("SELECT SCOPE_IDENTITY()");
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@id_tramite", obj.id_tramite);
                    if (obj.id_oficina != 0)
                        command.Parameters.AddWithValue("@id_oficina", obj.id_oficina);
                    else
                        command.Parameters.AddWithValue("@en_usuario", obj.en_usuario);
                    command.Parameters.AddWithValue("@nombre", obj.nombre);
                    command.Parameters.AddWithValue("@orden", (num + 1));
                    command.Parameters.AddWithValue("@activo", 1);
                    if (obj.es_final)
                        command.Parameters.AddWithValue("@es_final", obj.es_final);
                    else
                        command.Parameters.AddWithValue("@proxima_oficina", obj.proxima_oficina);
                    command.Connection.Open();
                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void update(PasoModel obj)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("UPDATE  Paso SET");
                stringBuilder.AppendLine("id_oficina=@id_oficina");
                stringBuilder.AppendLine(", en_usuario=@en_usuario");
                stringBuilder.AppendLine(", nombre=@nombre");
                stringBuilder.AppendLine(", es_final=@es_final");
                stringBuilder.AppendLine(", proxima_oficina=@proxima_oficina");
                stringBuilder.AppendLine("WHERE");
                stringBuilder.AppendLine("id=@id");
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@id_oficina", obj.id_oficina);
                    command.Parameters.AddWithValue("@en_usuario", obj.en_usuario);
                    command.Parameters.AddWithValue("@nombre", obj.nombre);
                    command.Parameters.AddWithValue("@es_final", obj.es_final);
                    command.Parameters.AddWithValue("@proxima_oficina", obj.proxima_oficina);
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

        public static void delete(int idPaso)
        {
            try
            {
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "Sp_paso_delete";
                    command.Parameters.AddWithValue("@id_paso", idPaso);
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
