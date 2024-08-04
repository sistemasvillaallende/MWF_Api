// Decompiled with JetBrains decompiler
// Type: MOTOR_WORKFLOW.Entities.Formularios
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
    public class Formularios : DALBase
    {
        public int id { get; set; }

        public int id_pasos { get; set; }

        public int id_formulario { get; set; }

        public string nombre { get; set; }

        public string descripcion { get; set; }

        public List<Respuesta_formulario> lstRespuesta { get; set; }

        public Formularios()
        {
            this.id = 0;
            this.id_pasos = 0;
            this.id_formulario = 0;
            this.nombre = string.Empty;
            this.descripcion = string.Empty;
            this.lstRespuesta = new List<Respuesta_formulario>();
        }

        private static List<Formularios> mapeo(SqlDataReader dr)
        {
            List<Formularios> formulariosList = new List<Formularios>();
            if (dr.HasRows)
            {
                int ordinal1 = dr.GetOrdinal("id");
                int ordinal2 = dr.GetOrdinal("id_pasos");
                int ordinal3 = dr.GetOrdinal("id_formulario");
                int ordinal4 = dr.GetOrdinal("nombre");
                int ordinal5 = dr.GetOrdinal("descripcion");
                while (dr.Read())
                {
                    Formularios formularios = new Formularios();
                    if (!dr.IsDBNull(ordinal1))
                        formularios.id = dr.GetInt32(ordinal1);
                    if (!dr.IsDBNull(ordinal2))
                        formularios.id_pasos = dr.GetInt32(ordinal2);
                    if (!dr.IsDBNull(ordinal3))
                        formularios.id_formulario = dr.GetInt32(ordinal3);
                    if (!dr.IsDBNull(ordinal4))
                        formularios.nombre = dr.GetString(ordinal4);
                    if (!dr.IsDBNull(ordinal5))
                        formularios.descripcion = dr.GetString(ordinal5);
                    formularios.lstRespuesta = Respuesta_formulario.read(formularios.id);
                    formulariosList.Add(formularios);
                }
            }
            return formulariosList;
        }

        public static List<Formularios> read()
        {
            try
            {
                List<Formularios> formulariosList = new List<Formularios>();
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT *FROM Formularios";
                    command.Connection.Open();
                    return Formularios.mapeo(command.ExecuteReader());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Formularios getByPk(int id)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("SELECT *FROM Formularios WHERE");
                stringBuilder.AppendLine("id = @id");
                Formularios byPk = (Formularios)null;
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@id", id);
                    command.Connection.Open();
                    List<Formularios> formulariosList = Formularios.mapeo(command.ExecuteReader());
                    if (formulariosList.Count != 0)
                        byPk = formulariosList[0];
                }
                return byPk;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Formularios getByIdPasos(int id_pasos)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("SELECT *FROM Formularios WHERE");
                stringBuilder.AppendLine("id_pasos = @id_pasos");
                Formularios byIdPasos = (Formularios)null;
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@id_pasos", id_pasos);
                    command.Connection.Open();
                    List<Formularios> formulariosList = Formularios.mapeo(command.ExecuteReader());
                    if (formulariosList.Count != 0)
                        byIdPasos = formulariosList[0];
                }
                return byIdPasos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int insert(Formularios obj)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("INSERT INTO Formularios(");
                stringBuilder.AppendLine("id_pasos");
                stringBuilder.AppendLine(", id_formulario");
                stringBuilder.AppendLine(", nombre");
                stringBuilder.AppendLine(", descripcion");
                stringBuilder.AppendLine(")");
                stringBuilder.AppendLine("VALUES");
                stringBuilder.AppendLine("(");
                stringBuilder.AppendLine("@id_pasos");
                stringBuilder.AppendLine(", @id_formulario");
                stringBuilder.AppendLine(", @nombre");
                stringBuilder.AppendLine(", @descripcion");
                stringBuilder.AppendLine(")");
                stringBuilder.AppendLine("SELECT SCOPE_IDENTITY()");
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@id_pasos", obj.id_pasos);
                    command.Parameters.AddWithValue("@id_formulario", obj.id_formulario);
                    command.Parameters.AddWithValue("@nombre", obj.nombre);
                    command.Parameters.AddWithValue("@descripcion", obj.descripcion);
                    command.Connection.Open();
                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void update(Formularios obj)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("UPDATE  Formularios SET");
                stringBuilder.AppendLine("id_pasos=@id_pasos");
                stringBuilder.AppendLine(", id_formulario=@id_formulario");
                stringBuilder.AppendLine(", nombre=@nombre");
                stringBuilder.AppendLine(", descripcion=@descripcion");
                stringBuilder.AppendLine("WHERE");
                stringBuilder.AppendLine("id=@id");
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@id_pasos", obj.id_pasos);
                    command.Parameters.AddWithValue("@id_formulario", obj.id_formulario);
                    command.Parameters.AddWithValue("@nombre", obj.nombre);
                    command.Parameters.AddWithValue("@descripcion", obj.descripcion);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void delete(Formularios obj)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("DELETE  Formularios ");
                stringBuilder.AppendLine("WHERE");
                stringBuilder.AppendLine("id=@id");
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
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
    }
}
