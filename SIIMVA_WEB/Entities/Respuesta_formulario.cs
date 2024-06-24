// Decompiled with JetBrains decompiler
// Type: MOTOR_WORKFLOW.Entities.Respuesta_formulario
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
    public class Respuesta_formulario : DALBase
    {
        public int id { get; set; }

        public int id_formularios { get; set; }

        public string nombre_campo { get; set; }

        public string respuesta_usuario { get; set; }

        public int id_tipo_campo { get; set; }

        public int orden { get; set; }

        public string etiqueta_campo { get; set; }

        public Respuesta_formulario()
        {
            this.id = 0;
            this.id_formularios = 0;
            this.nombre_campo = string.Empty;
            this.respuesta_usuario = string.Empty;
            this.id_tipo_campo = 0;
            this.orden = 0;
            this.etiqueta_campo = string.Empty;
        }

        private static List<Respuesta_formulario> mapeo(SqlDataReader dr)
        {
            List<Respuesta_formulario> respuestaFormularioList = new List<Respuesta_formulario>();
            if (dr.HasRows)
            {
                int ordinal1 = dr.GetOrdinal("id");
                int ordinal2 = dr.GetOrdinal("id_formularios");
                int ordinal3 = dr.GetOrdinal("nombre_campo");
                int ordinal4 = dr.GetOrdinal("respuesta_usuario");
                int ordinal5 = dr.GetOrdinal("id_tipo_campo");
                int ordinal6 = dr.GetOrdinal("orden");
                int ordinal7 = dr.GetOrdinal("etiqueta_campo");
                while (dr.Read())
                {
                    Respuesta_formulario respuestaFormulario = new Respuesta_formulario();
                    if (!dr.IsDBNull(ordinal1))
                        respuestaFormulario.id = dr.GetInt32(ordinal1);
                    if (!dr.IsDBNull(ordinal2))
                        respuestaFormulario.id_formularios = dr.GetInt32(ordinal2);
                    if (!dr.IsDBNull(ordinal3))
                        respuestaFormulario.nombre_campo = dr.GetString(ordinal3);
                    if (!dr.IsDBNull(ordinal4))
                        respuestaFormulario.respuesta_usuario = dr.GetString(ordinal4);
                    if (!dr.IsDBNull(ordinal5))
                        respuestaFormulario.id_tipo_campo = dr.GetInt32(ordinal5);
                    if (!dr.IsDBNull(ordinal6))
                        respuestaFormulario.orden = dr.GetInt32(ordinal6);
                    if (!dr.IsDBNull(ordinal7))
                        respuestaFormulario.etiqueta_campo = dr.GetString(ordinal7);
                    respuestaFormularioList.Add(respuestaFormulario);
                }
            }
            return respuestaFormularioList;
        }

        public static List<Respuesta_formulario> read(int id_formularios)
        {
            try
            {
                List<Respuesta_formulario> respuestaFormularioList = new List<Respuesta_formulario>();
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT *FROM Respuesta_formulario WHERE id_formularios=@id_formularios";
                    command.Parameters.AddWithValue("@id_formularios", (object)id_formularios);
                    command.Connection.Open();
                    return Respuesta_formulario.mapeo(command.ExecuteReader());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Respuesta_formulario getByPk()
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("SELECT *FROM Respuesta_formulario WHERE");
                Respuesta_formulario byPk = (Respuesta_formulario)null;
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Connection.Open();
                    List<Respuesta_formulario> respuestaFormularioList = Respuesta_formulario.mapeo(command.ExecuteReader());
                    if (respuestaFormularioList.Count != 0)
                        byPk = respuestaFormularioList[0];
                }
                return byPk;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int insert(Respuesta_formulario obj)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("INSERT INTO Respuesta_formulario(");
                stringBuilder.AppendLine("id_formularios");
                stringBuilder.AppendLine(", nombre_campo");
                stringBuilder.AppendLine(", respuesta_usuario");
                stringBuilder.AppendLine(", id_tipo_campo");
                stringBuilder.AppendLine(", orden");
                stringBuilder.AppendLine(", etiqueta_campo");
                stringBuilder.AppendLine(")");
                stringBuilder.AppendLine("VALUES");
                stringBuilder.AppendLine("(");
                stringBuilder.AppendLine("@id_formularios");
                stringBuilder.AppendLine(", @nombre_campo");
                stringBuilder.AppendLine(", @respuesta_usuario");
                stringBuilder.AppendLine(", @id_tipo_campo");
                stringBuilder.AppendLine(", @orden");
                stringBuilder.AppendLine(", @etiqueta_campo");
                stringBuilder.AppendLine(")");
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@id_formularios", (object)obj.id_formularios);
                    command.Parameters.AddWithValue("@nombre_campo", (object)obj.nombre_campo);
                    command.Parameters.AddWithValue("@respuesta_usuario", (object)obj.respuesta_usuario);
                    command.Parameters.AddWithValue("@id_tipo_campo", (object)obj.id_tipo_campo);
                    command.Parameters.AddWithValue("@orden", (object)obj.orden);
                    command.Parameters.AddWithValue("@etiqueta_campo", (object)obj.etiqueta_campo);
                    command.Connection.Open();
                    return command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void update(Respuesta_formulario obj)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("UPDATE  Respuesta_formulario SET");
                stringBuilder.AppendLine("id_formularios=@id_formularios");
                stringBuilder.AppendLine(", nombre_campo=@nombre_campo");
                stringBuilder.AppendLine(", respuesta_usuario=@respuesta_usuario");
                stringBuilder.AppendLine(", id_tipo_campo=@id_tipo_campo");
                stringBuilder.AppendLine(", orden=@orden");
                stringBuilder.AppendLine(", etiqueta_campo=@etiqueta_campo");
                stringBuilder.AppendLine("WHERE");
                stringBuilder.AppendLine("id=@id");
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@id", (object)obj.id);
                    command.Parameters.AddWithValue("@id_formularios", (object)obj.id_formularios);
                    command.Parameters.AddWithValue("@nombre_campo", (object)obj.nombre_campo);
                    command.Parameters.AddWithValue("@respuesta_usuario", (object)obj.respuesta_usuario);
                    command.Parameters.AddWithValue("@id_tipo_campo", (object)obj.id_tipo_campo);
                    command.Parameters.AddWithValue("@orden", (object)obj.orden);
                    command.Parameters.AddWithValue("@etiqueta_campo", (object)obj.etiqueta_campo);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void delete(Respuesta_formulario obj)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("DELETE  Respuesta_formulario ");
                stringBuilder.AppendLine("WHERE");
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
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
