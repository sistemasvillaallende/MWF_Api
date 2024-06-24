// Decompiled with JetBrains decompiler
// Type: MOTOR_WORKFLOW.Entities.Movimiento_tramites
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
    public class Movimiento_tramites : DALBase
    {
        public int id { get; set; }

        public DateTime fecha { get; set; }

        public int id_tramites { get; set; }

        public int id_oficina { get; set; }

        public int id_direccion { get; set; }

        public int id_secretaria { get; set; }

        public bool en_vecino { get; set; }

        public string cuit { get; set; }

        public int cod_usuario { get; set; }

        public string accion { get; set; }

        public int cod_oficina_destino { get; set; }

        public bool destino_vecino { get; set; }

        public Movimiento_tramites()
        {
            this.id = 0;
            this.fecha = DateTime.Now;
            this.id_tramites = 0;
            this.id_oficina = 0;
            this.id_direccion = 0;
            this.id_secretaria = 0;
            this.en_vecino = false;
            this.cuit = string.Empty;
            this.cod_usuario = 0;
            this.accion = string.Empty;
            this.cod_oficina_destino = 0;
            this.destino_vecino = false;
        }

        private static List<Movimiento_tramites> mapeo(SqlDataReader dr)
        {
            List<Movimiento_tramites> movimientoTramitesList = new List<Movimiento_tramites>();
            if (dr.HasRows)
            {
                int ordinal1 = dr.GetOrdinal("id");
                int ordinal2 = dr.GetOrdinal("fecha");
                int ordinal3 = dr.GetOrdinal("id_tramites");
                int ordinal4 = dr.GetOrdinal("id_oficina");
                int ordinal5 = dr.GetOrdinal("id_direccion");
                int ordinal6 = dr.GetOrdinal("id_secretaria");
                int ordinal7 = dr.GetOrdinal("en_vecino");
                int ordinal8 = dr.GetOrdinal("cuit");
                int ordinal9 = dr.GetOrdinal("cod_usuario");
                int ordinal10 = dr.GetOrdinal("accion");
                int ordinal11 = dr.GetOrdinal("cod_oficina_destino");
                int ordinal12 = dr.GetOrdinal("destino_vecino");
                while (dr.Read())
                {
                    Movimiento_tramites movimientoTramites = new Movimiento_tramites();
                    if (!dr.IsDBNull(ordinal1))
                        movimientoTramites.id = dr.GetInt32(ordinal1);
                    if (!dr.IsDBNull(ordinal2))
                        movimientoTramites.fecha = dr.GetDateTime(ordinal2);
                    if (!dr.IsDBNull(ordinal3))
                        movimientoTramites.id_tramites = dr.GetInt32(ordinal3);
                    if (!dr.IsDBNull(ordinal4))
                        movimientoTramites.id_oficina = dr.GetInt32(ordinal4);
                    if (!dr.IsDBNull(ordinal5))
                        movimientoTramites.id_direccion = dr.GetInt32(ordinal5);
                    if (!dr.IsDBNull(ordinal6))
                        movimientoTramites.id_secretaria = dr.GetInt32(ordinal6);
                    if (!dr.IsDBNull(ordinal7))
                        movimientoTramites.en_vecino = dr.GetBoolean(ordinal7);
                    if (!dr.IsDBNull(ordinal8))
                        movimientoTramites.cuit = dr.GetString(ordinal8);
                    if (!dr.IsDBNull(ordinal9))
                        movimientoTramites.cod_usuario = dr.GetInt32(ordinal9);
                    if (!dr.IsDBNull(ordinal10))
                        movimientoTramites.accion = dr.GetString(ordinal10);
                    if (!dr.IsDBNull(ordinal11))
                        movimientoTramites.cod_oficina_destino = dr.GetInt32(ordinal11);
                    if (!dr.IsDBNull(ordinal12))
                        movimientoTramites.destino_vecino = dr.GetBoolean(ordinal12);
                    movimientoTramitesList.Add(movimientoTramites);
                }
            }
            return movimientoTramitesList;
        }

        public static List<Movimiento_tramites> read()
        {
            try
            {
                List<Movimiento_tramites> movimientoTramitesList = new List<Movimiento_tramites>();
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT *FROM Movimiento_tramites";
                    command.Connection.Open();
                    return Movimiento_tramites.mapeo(command.ExecuteReader());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Movimiento_tramites getByPk(int id)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("SELECT *FROM Movimiento_tramites WHERE");
                stringBuilder.AppendLine("id = @id");
                Movimiento_tramites byPk = (Movimiento_tramites)null;
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@id", (object)id);
                    command.Connection.Open();
                    List<Movimiento_tramites> movimientoTramitesList = Movimiento_tramites.mapeo(command.ExecuteReader());
                    if (movimientoTramitesList.Count != 0)
                        byPk = movimientoTramitesList[0];
                }
                return byPk;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int insert(Movimiento_tramites obj)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("INSERT INTO Movimiento_tramites(");
                stringBuilder.AppendLine("fecha");
                stringBuilder.AppendLine(", id_tramites");
                stringBuilder.AppendLine(", id_oficina");
                stringBuilder.AppendLine(", id_direccion");
                stringBuilder.AppendLine(", id_secretaria");
                stringBuilder.AppendLine(", en_vecino");
                stringBuilder.AppendLine(", cuit");
                stringBuilder.AppendLine(", cod_usuario");
                stringBuilder.AppendLine(", accion");
                stringBuilder.AppendLine(", cod_oficina_destino");
                stringBuilder.AppendLine(", destino_vecino");
                stringBuilder.AppendLine(")");
                stringBuilder.AppendLine("VALUES");
                stringBuilder.AppendLine("(");
                stringBuilder.AppendLine("@fecha");
                stringBuilder.AppendLine(", @id_tramites");
                stringBuilder.AppendLine(", @id_oficina");
                stringBuilder.AppendLine(", @id_direccion");
                stringBuilder.AppendLine(", @id_secretaria");
                stringBuilder.AppendLine(", @en_vecino");
                stringBuilder.AppendLine(", @cuit");
                stringBuilder.AppendLine(", @cod_usuario");
                stringBuilder.AppendLine(", @accion");
                stringBuilder.AppendLine(", @cod_oficina_destino");
                stringBuilder.AppendLine(", @destino_vecino");
                stringBuilder.AppendLine(")");
                stringBuilder.AppendLine("SELECT SCOPE_IDENTITY()");
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@fecha", (object)obj.fecha);
                    command.Parameters.AddWithValue("@id_tramites", (object)obj.id_tramites);
                    command.Parameters.AddWithValue("@id_oficina", (object)obj.id_oficina);
                    command.Parameters.AddWithValue("@id_direccion", (object)obj.id_direccion);
                    command.Parameters.AddWithValue("@id_secretaria", (object)obj.id_secretaria);
                    command.Parameters.AddWithValue("@en_vecino", (object)obj.en_vecino);
                    command.Parameters.AddWithValue("@cuit", (object)obj.cuit);
                    command.Parameters.AddWithValue("@cod_usuario", (object)obj.cod_usuario);
                    command.Parameters.AddWithValue("@accion", (object)obj.accion);
                    command.Parameters.AddWithValue("@cod_oficina_destino", (object)obj.cod_oficina_destino);
                    command.Parameters.AddWithValue("@destino_vecino", (object)obj.destino_vecino);
                    command.Connection.Open();
                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void update(Movimiento_tramites obj)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("UPDATE  Movimiento_tramites SET");
                stringBuilder.AppendLine("fecha=@fecha");
                stringBuilder.AppendLine(", id_tramites=@id_tramites");
                stringBuilder.AppendLine(", id_oficina=@id_oficina");
                stringBuilder.AppendLine(", id_direccion=@id_direccion");
                stringBuilder.AppendLine(", id_secretaria=@id_secretaria");
                stringBuilder.AppendLine(", en_vecino=@en_vecino");
                stringBuilder.AppendLine(", cuit=@cuit");
                stringBuilder.AppendLine(", cod_usuario=@cod_usuario");
                stringBuilder.AppendLine(", accion=@accion");
                stringBuilder.AppendLine(", cod_oficina_destino=@cod_oficina_destino");
                stringBuilder.AppendLine(", destino_vecino=@destino_vecino");
                stringBuilder.AppendLine("WHERE");
                stringBuilder.AppendLine("id=@id");
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@fecha", (object)obj.fecha);
                    command.Parameters.AddWithValue("@id_tramites", (object)obj.id_tramites);
                    command.Parameters.AddWithValue("@id_oficina", (object)obj.id_oficina);
                    command.Parameters.AddWithValue("@id_direccion", (object)obj.id_direccion);
                    command.Parameters.AddWithValue("@id_secretaria", (object)obj.id_secretaria);
                    command.Parameters.AddWithValue("@en_vecino", (object)obj.en_vecino);
                    command.Parameters.AddWithValue("@cuit", (object)obj.cuit);
                    command.Parameters.AddWithValue("@cod_usuario", (object)obj.cod_usuario);
                    command.Parameters.AddWithValue("@accion", (object)obj.accion);
                    command.Parameters.AddWithValue("@cod_oficina_destino", (object)obj.cod_oficina_destino);
                    command.Parameters.AddWithValue("@destino_vecino", (object)obj.destino_vecino);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void delete(Movimiento_tramites obj)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("DELETE  Movimiento_tramites ");
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
