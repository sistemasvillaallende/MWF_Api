// Decompiled with JetBrains decompiler
// Type: MOTOR_WORKFLOW.Entities.Tramite
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
    public class Tramite : DALBase
    {
        public int id { get; set; }

        public string nombre { get; set; }

        public string descripcion { get; set; }

        public DateTime fecha_crea { get; set; }

        public string usu_crea { get; set; }

        public DateTime fecha_modifica { get; set; }

        public string usu_modifica { get; set; }

        public bool activo { get; set; }

        public DateTime fecha_baja { get; set; }

        public string usu_baja { get; set; }

        public int id_unidad_organizativa { get; set; }

        public string nombre_unidad_organizativa { get; set; }

        public string logo_unidad_administrativa { get; set; }

        public int primer_paso { get; set; }
        public bool es_multinota { get; set; }
        public List<Paso> lstPasos { get; set; }


        public Tramite()
        {
            this.id = 0;
            this.nombre = string.Empty;
            this.descripcion = string.Empty;
            this.fecha_crea = DateTime.Now;
            this.usu_crea = string.Empty;
            this.fecha_modifica = DateTime.Now;
            this.usu_modifica = string.Empty;
            this.activo = false;
            this.fecha_baja = DateTime.Now;
            this.usu_baja = string.Empty;
            this.id_unidad_organizativa = 0;
            this.nombre_unidad_organizativa = string.Empty;
            this.logo_unidad_administrativa = string.Empty;
            this.primer_paso = 0;
            es_multinota = false;
            this.lstPasos = new List<Paso>();
        }

        private static List<Tramite> mapeo(SqlDataReader dr)
        {
            List<Tramite> tramiteList = new List<Tramite>();
            if (dr.HasRows)
            {
                int ordinal1 = dr.GetOrdinal("id");
                int ordinal2 = dr.GetOrdinal("nombre");
                int ordinal3 = dr.GetOrdinal("descripcion");
                int ordinal4 = dr.GetOrdinal("fecha_crea");
                int ordinal5 = dr.GetOrdinal("usu_crea");
                int ordinal6 = dr.GetOrdinal("fecha_modifica");
                int ordinal7 = dr.GetOrdinal("usu_modifica");
                int ordinal8 = dr.GetOrdinal("activo");
                int ordinal9 = dr.GetOrdinal("fecha_baja");
                int ordinal10 = dr.GetOrdinal("usu_baja");
                int ordinal11 = dr.GetOrdinal("ID_UNIDAD_ORGANIZATIVA");
                int ordinal12 = dr.GetOrdinal("nombre_unidad_organizativa");
                int ordinal13 = dr.GetOrdinal("logo_unidad_administrativa");

                int es_multinota = dr.GetOrdinal("es_multinota");

                while (dr.Read())
                {
                    Tramite tramite = new Tramite();
                    if (!dr.IsDBNull(ordinal1))
                        tramite.id = dr.GetInt32(ordinal1);
                    if (!dr.IsDBNull(ordinal2))
                        tramite.nombre = dr.GetString(ordinal2);
                    if (!dr.IsDBNull(ordinal3))
                        tramite.descripcion = dr.GetString(ordinal3);
                    if (!dr.IsDBNull(ordinal4))
                        tramite.fecha_crea = dr.GetDateTime(ordinal4);
                    if (!dr.IsDBNull(ordinal5))
                        tramite.usu_crea = dr.GetString(ordinal5);
                    if (!dr.IsDBNull(ordinal6))
                        tramite.fecha_modifica = dr.GetDateTime(ordinal6);
                    if (!dr.IsDBNull(ordinal7))
                        tramite.usu_modifica = dr.GetString(ordinal7);
                    if (!dr.IsDBNull(ordinal8))
                        tramite.activo = dr.GetBoolean(ordinal8);
                    if (!dr.IsDBNull(ordinal9))
                        tramite.fecha_baja = dr.GetDateTime(ordinal9);
                    if (!dr.IsDBNull(ordinal10))
                        tramite.usu_baja = dr.GetString(ordinal10);
                    if (!dr.IsDBNull(ordinal11))
                        tramite.id_unidad_organizativa = dr.GetInt32(ordinal11);
                    if (!dr.IsDBNull(ordinal12))
                        tramite.nombre_unidad_organizativa = dr.GetString(ordinal12);
                    if (!dr.IsDBNull(ordinal13))
                        tramite.logo_unidad_administrativa = dr.GetString(ordinal13);

                    if (!dr.IsDBNull(es_multinota))
                        tramite.es_multinota = dr.GetBoolean(es_multinota);

                    tramiteList.Add(tramite);
                }
            }
            return tramiteList;
        }

        private static List<Tramite> mapeoCompleto(SqlDataReader dr)
        {
            List<Tramite> tramiteList = new List<Tramite>();
            if (dr.HasRows)
            {
                int ordinal1 = dr.GetOrdinal("id");
                int ordinal2 = dr.GetOrdinal("nombre");
                int ordinal3 = dr.GetOrdinal("descripcion");
                int ordinal4 = dr.GetOrdinal("fecha_crea");
                int ordinal5 = dr.GetOrdinal("usu_crea");
                int ordinal6 = dr.GetOrdinal("fecha_modifica");
                int ordinal7 = dr.GetOrdinal("usu_modifica");
                int ordinal8 = dr.GetOrdinal("activo");
                int ordinal9 = dr.GetOrdinal("fecha_baja");
                int ordinal10 = dr.GetOrdinal("usu_baja");
                int ordinal11 = dr.GetOrdinal("ID_UNIDAD_ORGANIZATIVA");
                int ordinal12 = dr.GetOrdinal("nombre_unidad_organizativa");
                int ordinal13 = dr.GetOrdinal("logo_unidad_administrativa");

                int es_multinota = dr.GetOrdinal("es_multinota");

                while (dr.Read())
                {
                    Tramite tramite = new Tramite();
                    if (!dr.IsDBNull(ordinal1))
                        tramite.id = dr.GetInt32(ordinal1);
                    if (!dr.IsDBNull(ordinal2))
                        tramite.nombre = dr.GetString(ordinal2);
                    if (!dr.IsDBNull(ordinal3))
                        tramite.descripcion = dr.GetString(ordinal3);
                    if (!dr.IsDBNull(ordinal4))
                        tramite.fecha_crea = dr.GetDateTime(ordinal4);
                    if (!dr.IsDBNull(ordinal5))
                        tramite.usu_crea = dr.GetString(ordinal5);
                    if (!dr.IsDBNull(ordinal6))
                        tramite.fecha_modifica = dr.GetDateTime(ordinal6);
                    if (!dr.IsDBNull(ordinal7))
                        tramite.usu_modifica = dr.GetString(ordinal7);
                    if (!dr.IsDBNull(ordinal8))
                        tramite.activo = dr.GetBoolean(ordinal8);
                    if (!dr.IsDBNull(ordinal9))
                        tramite.fecha_baja = dr.GetDateTime(ordinal9);
                    if (!dr.IsDBNull(ordinal10))
                        tramite.usu_baja = dr.GetString(ordinal10);
                    if (!dr.IsDBNull(ordinal11))
                        tramite.id_unidad_organizativa = dr.GetInt32(ordinal11);
                    if (!dr.IsDBNull(ordinal12))
                        tramite.nombre_unidad_organizativa = dr.GetString(ordinal12);
                    if (!dr.IsDBNull(ordinal13))
                        tramite.logo_unidad_administrativa = dr.GetString(ordinal13);

                    if (!dr.IsDBNull(es_multinota))
                        tramite.es_multinota = dr.GetBoolean(es_multinota);

                    tramite.lstPasos = Paso.read(tramite.id);
                    tramiteList.Add(tramite);
                }
            }
            return tramiteList;
        }
        public static string getImgOficina(int id)
        {

            try
            {
                string img = string.Empty;
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = @"
                                SELECT 
                                    img 
                                FROM SIIMVA.dbo.OFICINAS
                                WHERE 
                                    codigo_oficina = @codigo_oficina";
                    command.Parameters.AddWithValue("@codigo_oficina", id);
                    command.Connection.Open();
                    SqlDataReader dr = command.ExecuteReader();
                    if (dr.HasRows)
                    {
                        int _img = dr.GetOrdinal("img");
                        while (dr.Read())
                        {
                            img = dr.GetString(_img);
                        }
                    }
                    return img;
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<Tramite> read()
        {
            try
            {
                List<Tramite> tramiteList = new List<Tramite>();
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                            @"SELECT 
                                A.*, 
                                (SELECT TOP 1 ID FROM PASO B WHERE ID_TRAMITE = A.ID ORDER BY B.ORDEN ASC) AS primer_paso
                            FROM TRAMITE A                                
                            WHERE ACTIVO = 1";
                    command.Connection.Open();
                    SqlDataReader sqlDataReader = command.ExecuteReader();
                    if (sqlDataReader.HasRows)
                    {
                        int ordinal1 = sqlDataReader.GetOrdinal("id");
                        int ordinal2 = sqlDataReader.GetOrdinal("nombre");
                        int ordinal3 = sqlDataReader.GetOrdinal("descripcion");
                        int ordinal4 = sqlDataReader.GetOrdinal("fecha_crea");
                        int ordinal5 = sqlDataReader.GetOrdinal("usu_crea");
                        int ordinal6 = sqlDataReader.GetOrdinal("fecha_modifica");
                        int ordinal7 = sqlDataReader.GetOrdinal("usu_modifica");
                        int ordinal8 = sqlDataReader.GetOrdinal("activo");
                        int ordinal9 = sqlDataReader.GetOrdinal("fecha_baja");
                        int ordinal10 = sqlDataReader.GetOrdinal("usu_baja");
                        int ordinal11 = sqlDataReader.GetOrdinal("id_unidad_organizativa");
                        int ordinal12 = sqlDataReader.GetOrdinal("nombre_unidad_organizativa");
                        int ordinal13 = sqlDataReader.GetOrdinal("logo_unidad_administrativa");
                        int ordinal14 = sqlDataReader.GetOrdinal("primer_paso");

                        while (sqlDataReader.Read())
                        {
                            Tramite tramite = new Tramite();
                            if (!sqlDataReader.IsDBNull(ordinal1))
                                tramite.id = sqlDataReader.GetInt32(ordinal1);
                            if (!sqlDataReader.IsDBNull(ordinal2))
                                tramite.nombre = sqlDataReader.GetString(ordinal2);
                            if (!sqlDataReader.IsDBNull(ordinal3))
                                tramite.descripcion = sqlDataReader.GetString(ordinal3);
                            if (!sqlDataReader.IsDBNull(ordinal4))
                                tramite.fecha_crea = sqlDataReader.GetDateTime(ordinal4);
                            if (!sqlDataReader.IsDBNull(ordinal5))
                                tramite.usu_crea = sqlDataReader.GetString(ordinal5);
                            if (!sqlDataReader.IsDBNull(ordinal6))
                                tramite.fecha_modifica = sqlDataReader.GetDateTime(ordinal6);
                            if (!sqlDataReader.IsDBNull(ordinal7))
                                tramite.usu_modifica = sqlDataReader.GetString(ordinal7);
                            if (!sqlDataReader.IsDBNull(ordinal8))
                                tramite.activo = sqlDataReader.GetBoolean(ordinal8);
                            if (!sqlDataReader.IsDBNull(ordinal9))
                                tramite.fecha_baja = sqlDataReader.GetDateTime(ordinal9);
                            if (!sqlDataReader.IsDBNull(ordinal10))
                                tramite.usu_baja = sqlDataReader.GetString(ordinal10);
                            if (!sqlDataReader.IsDBNull(ordinal11))
                                tramite.id_unidad_organizativa = sqlDataReader.GetInt32(ordinal11);
                            if (!sqlDataReader.IsDBNull(ordinal12))
                                tramite.nombre_unidad_organizativa = sqlDataReader.GetString(ordinal12);
                            if (!sqlDataReader.IsDBNull(ordinal13))
                                tramite.logo_unidad_administrativa = sqlDataReader.GetString(ordinal13);
                            if (!sqlDataReader.IsDBNull(ordinal14))
                                tramite.primer_paso = sqlDataReader.GetInt32(ordinal14);

                            tramiteList.Add(tramite);
                        }
                    }
                    return tramiteList;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<Tramite> readBack()
        {
            try
            {
                List<Tramite> tramiteList = new List<Tramite>();
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                        "SELECT A.*, (SELECT TOP 1 ID FROM PASO B WHERE ID_TRAMITE = A.ID  ORDER BY B.ORDEN ASC) AS primer_paso FROM TRAMITE A";
                    command.Connection.Open();
                    SqlDataReader sqlDataReader = command.ExecuteReader();
                    if (sqlDataReader.HasRows)
                    {
                        int ordinal1 = sqlDataReader.GetOrdinal("id");
                        int ordinal2 = sqlDataReader.GetOrdinal("nombre");
                        int ordinal3 = sqlDataReader.GetOrdinal("descripcion");
                        int ordinal4 = sqlDataReader.GetOrdinal("fecha_crea");
                        int ordinal5 = sqlDataReader.GetOrdinal("usu_crea");
                        int ordinal6 = sqlDataReader.GetOrdinal("fecha_modifica");
                        int ordinal7 = sqlDataReader.GetOrdinal("usu_modifica");
                        int ordinal8 = sqlDataReader.GetOrdinal("activo");
                        int ordinal9 = sqlDataReader.GetOrdinal("fecha_baja");
                        int ordinal10 = sqlDataReader.GetOrdinal("usu_baja");
                        int ordinal11 = sqlDataReader.GetOrdinal("id_unidad_organizativa");
                        int ordinal12 = sqlDataReader.GetOrdinal("nombre_unidad_organizativa");
                        int ordinal13 = sqlDataReader.GetOrdinal("logo_unidad_administrativa");
                        int ordinal14 = sqlDataReader.GetOrdinal("primer_paso");

                        int es_multinota = sqlDataReader.GetOrdinal("es_multinota");

                        while (sqlDataReader.Read())
                        {
                            Tramite tramite = new Tramite();
                            if (!sqlDataReader.IsDBNull(ordinal1))
                                tramite.id = sqlDataReader.GetInt32(ordinal1);
                            if (!sqlDataReader.IsDBNull(ordinal2))
                                tramite.nombre = sqlDataReader.GetString(ordinal2);
                            if (!sqlDataReader.IsDBNull(ordinal3))
                                tramite.descripcion = sqlDataReader.GetString(ordinal3);
                            if (!sqlDataReader.IsDBNull(ordinal4))
                                tramite.fecha_crea = sqlDataReader.GetDateTime(ordinal4);
                            if (!sqlDataReader.IsDBNull(ordinal5))
                                tramite.usu_crea = sqlDataReader.GetString(ordinal5);
                            if (!sqlDataReader.IsDBNull(ordinal6))
                                tramite.fecha_modifica = sqlDataReader.GetDateTime(ordinal6);
                            if (!sqlDataReader.IsDBNull(ordinal7))
                                tramite.usu_modifica = sqlDataReader.GetString(ordinal7);
                            if (!sqlDataReader.IsDBNull(ordinal8))
                                tramite.activo = sqlDataReader.GetBoolean(ordinal8);
                            if (!sqlDataReader.IsDBNull(ordinal9))
                                tramite.fecha_baja = sqlDataReader.GetDateTime(ordinal9);
                            if (!sqlDataReader.IsDBNull(ordinal10))
                                tramite.usu_baja = sqlDataReader.GetString(ordinal10);
                            if (!sqlDataReader.IsDBNull(ordinal11))
                                tramite.id_unidad_organizativa = sqlDataReader.GetInt32(ordinal11);
                            if (!sqlDataReader.IsDBNull(ordinal12))
                                tramite.nombre_unidad_organizativa = sqlDataReader.GetString(ordinal12);
                            if (!sqlDataReader.IsDBNull(ordinal13))
                                tramite.logo_unidad_administrativa = sqlDataReader.GetString(ordinal13);
                            if (!sqlDataReader.IsDBNull(ordinal14))
                                tramite.primer_paso = sqlDataReader.GetInt32(ordinal14);

                            if (!sqlDataReader.IsDBNull(es_multinota))
                                tramite.es_multinota = sqlDataReader.GetBoolean(es_multinota);
                           
                            tramiteList.Add(tramite);
                        }
                    }
                    return tramiteList;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Tramite getByPk(int ID)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("SELECT *FROM Tramite WHERE");
                stringBuilder.AppendLine("id = @id");
                Tramite byPk = (Tramite)null;
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@id", ID);
                    command.Connection.Open();
                    List<Tramite> tramiteList = Tramite.mapeoCompleto(command.ExecuteReader());
                    if (tramiteList.Count != 0)
                        byPk = tramiteList[0];
                }
                return byPk;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int insert(Models.TramiteInsert obj)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("INSERT INTO Tramite(");
                stringBuilder.AppendLine("nombre");
                stringBuilder.AppendLine(", fecha_crea");
                stringBuilder.AppendLine(", usu_crea");
                stringBuilder.AppendLine(", activo");
                stringBuilder.AppendLine(", id_unidad_organizativa");
                stringBuilder.AppendLine(", logo_unidad_administrativa");
                stringBuilder.AppendLine(", nombre_unidad_organizativa");


                stringBuilder.AppendLine(")");
                stringBuilder.AppendLine("VALUES");
                stringBuilder.AppendLine("(");
                stringBuilder.AppendLine("@nombre");
                stringBuilder.AppendLine(", GETDATE()");
                stringBuilder.AppendLine(", @usu_crea");
                stringBuilder.AppendLine(", 0");
                stringBuilder.AppendLine(", @id_unidad_organizativa");
                stringBuilder.AppendLine(", @logo_unidad_administrativa");
                stringBuilder.AppendLine(", @nombre_unidad_organizativa");

                stringBuilder.AppendLine(")");
                stringBuilder.AppendLine("SELECT SCOPE_IDENTITY()");
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@nombre", obj.nombre.Trim());
                    command.Parameters.AddWithValue("@usu_crea", obj.usu_crea.Trim());
                    command.Parameters.AddWithValue("@id_unidad_organizativa", obj.id_unidad_organizativa);
                    command.Parameters.AddWithValue("@logo_unidad_administrativa", obj.logo_unidad_administrativa.Trim());
                    command.Parameters.AddWithValue("@nombre_unidad_organizativa", obj.nombre_unidad_organizativa.Trim());

                    command.Connection.Open();
                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static int duplicar(Models.TramiteDuplicar obj)
        {
            try
            {
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "DUPLICA_TRAMITE";
                    command.Parameters.AddWithValue("@ID_TRAMITE", obj.ID_TRAMITE);
                    command.Parameters.AddWithValue("@NOMBRE", obj.NOMBRE);


                    command.Connection.Open();
                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void update(Models.TramiteInsert obj)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("UPDATE  Tramite SET");
                stringBuilder.AppendLine("nombre=@nombre");
                stringBuilder.AppendLine(", fecha_modifica=GETDATE()");
                stringBuilder.AppendLine(", usu_modifica=@usu_modifica");
                stringBuilder.AppendLine(", id_unidad_organizativa=@id_unidad_organizativa");
                stringBuilder.AppendLine(", logo_unidad_administrativa=@logo_unidad_administrativa");
                stringBuilder.AppendLine(", nombre_unidad_organizativa=@nombre_unidad_organizativa");

                stringBuilder.AppendLine("WHERE");
                stringBuilder.AppendLine("id=@id");
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@nombre", obj.nombre.Trim());
                    command.Parameters.AddWithValue("@usu_modifica", obj.usu_crea.Trim());
                    command.Parameters.AddWithValue("@id", obj.id);
                    command.Parameters.AddWithValue("@id_unidad_organizativa", obj.id_unidad_organizativa);
                    command.Parameters.AddWithValue("@logo_unidad_administrativa", obj.logo_unidad_administrativa.Trim());
                    command.Parameters.AddWithValue("@nombre_unidad_organizativa", obj.nombre_unidad_organizativa.Trim());

                    command.Connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void set_es_multinota(int id_tramite, bool es_multinota)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("UPDATE  Tramite SET");
                stringBuilder.AppendLine("es_multinota=@es_multinota");
                stringBuilder.AppendLine("WHERE");
                stringBuilder.AppendLine("id=@id");
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@es_multinota", es_multinota);
                    command.Parameters.AddWithValue("@id", id_tramite);

                    command.Connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static void activaDesactiva(Models.TramiteActivar obj)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("UPDATE  Tramite SET");
                stringBuilder.AppendLine("activo=@activo");
                stringBuilder.AppendLine("WHERE");
                stringBuilder.AppendLine("id=@id");
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@activo", obj.activaDesactiva);
                    command.Parameters.AddWithValue("@id", obj.ID_TRAMITE);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static string VerificaConsistencia(int idTramite)
        {
            try
            {
                string error = string.Empty;    
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "VALIDA_INTEGRIDAD_TRAMITE";
                    command.Parameters.AddWithValue("@ID_TRAMITE", idTramite);
                    // Parámetro de salida
                    SqlParameter errorParam = new SqlParameter("@ERROR", SqlDbType.VarChar, 500);
                    errorParam.Direction = ParameterDirection.Output;
                    command.Parameters.Add(errorParam);
                    connection.Open();
                    // Ejecutar
                    command.ExecuteNonQuery();

                    // Recuperar valor del parámetro de salida
                    error = errorParam.Value?.ToString();
                }
                return error;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void delete(int id_tramite)
        {
            try
            {
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "Sp_tramite_delete";
                    command.Parameters.AddWithValue("@id_tramite", id_tramite);
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
