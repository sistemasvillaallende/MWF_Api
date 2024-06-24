// Decompiled with JetBrains decompiler
// Type: MOTOR_WORKFLOW.Entities.Formulario
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
    public class Formulario : DALBase
    {
        public int id { get; set; }

        public string nombre { get; set; }

        public string descripcion { get; set; }

        public bool activo { get; set; }

        public int id_contenido_ingreso_paso { get; set; }

        public List<campos_x_formulario> lstCampos { get; set; }

        public Formulario()
        {
            this.id = 0;
            this.nombre = string.Empty;
            this.descripcion = string.Empty;
            this.activo = false;
            this.id_contenido_ingreso_paso = 0;
            this.lstCampos = new List<campos_x_formulario>();
        }

        private static List<Formulario> mapeo(SqlDataReader dr)
        {
            List<Formulario> formularioList = new List<Formulario>();
            if (dr.HasRows)
            {
                int ordinal1 = dr.GetOrdinal("id");
                int ordinal2 = dr.GetOrdinal("nombre");
                int ordinal3 = dr.GetOrdinal("descripcion");
                int ordinal4 = dr.GetOrdinal("activo");
                int ordinal5 = dr.GetOrdinal("id_contenido_ingreso_paso");
                while (dr.Read())
                {
                    Formulario formulario = new Formulario();
                    if (!dr.IsDBNull(ordinal1))
                        formulario.id = dr.GetInt32(ordinal1);
                    if (!dr.IsDBNull(ordinal2))
                        formulario.nombre = dr.GetString(ordinal2);
                    if (!dr.IsDBNull(ordinal3))
                        formulario.descripcion = dr.GetString(ordinal3);
                    if (!dr.IsDBNull(ordinal4))
                        formulario.activo = dr.GetBoolean(ordinal4);
                    if (!dr.IsDBNull(ordinal5))
                        formulario.id_contenido_ingreso_paso = dr.GetInt32(ordinal5);
                    formulario.lstCampos = campos_x_formulario.read(formulario.id);
                    formularioList.Add(formulario);
                }
            }
            return formularioList;
        }

        public static List<Formulario> read()
        {
            try
            {
                List<Formulario> formularioList = new List<Formulario>();
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT *FROM Formulario";
                    command.Connection.Open();
                    return Formulario.mapeo(command.ExecuteReader());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Formulario getByPk(int ID)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("SELECT *FROM Formulario WHERE");
                stringBuilder.AppendLine("id = @id");
                Formulario byPk = (Formulario)null;
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@id", (object)ID);
                    command.Connection.Open();
                    List<Formulario> formularioList = Formulario.mapeo(command.ExecuteReader());
                    if (formularioList.Count != 0)
                        byPk = formularioList[0];
                }
                return byPk;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int insert(Formulario obj)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("INSERT INTO Formulario(");
                stringBuilder.AppendLine("nombre");
                stringBuilder.AppendLine(", descripcion");
                stringBuilder.AppendLine(", activo");
                stringBuilder.AppendLine(", id_contenido_ingreso_paso");
                stringBuilder.AppendLine(")");
                stringBuilder.AppendLine("VALUES");
                stringBuilder.AppendLine("(");
                stringBuilder.AppendLine("@nombre");
                stringBuilder.AppendLine(", @descripcion");
                stringBuilder.AppendLine(", 1");
                stringBuilder.AppendLine(", @id_contenido_ingreso_paso");
                stringBuilder.AppendLine(")");
                stringBuilder.AppendLine("SELECT SCOPE_IDENTITY()");
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@nombre", (object)obj.nombre);
                    command.Parameters.AddWithValue("@descripcion", (object)obj.nombre);
                    command.Parameters.AddWithValue("@id_contenido_ingreso_paso", (object)obj.id_contenido_ingreso_paso);
                    command.Connection.Open();
                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void update(Formulario obj)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("UPDATE  Formulario SET");
                stringBuilder.AppendLine("nombre=@nombre");
                stringBuilder.AppendLine("WHERE");
                stringBuilder.AppendLine("id=@id");
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@nombre", (object)obj.nombre);
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

        public static void delete(Formulario obj)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("DELETE  Formulario ");
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

        public static void delete(int ID_CONTENIDO_INGRESO_PASO)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("DELETE  Formulario ");
                stringBuilder.AppendLine("WHERE");
                stringBuilder.AppendLine("ID_CONTENIDO_INGRESO_PASO=@ID_CONTENIDO_INGRESO_PASO");
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@ID_CONTENIDO_INGRESO_PASO", (object)ID_CONTENIDO_INGRESO_PASO);
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
