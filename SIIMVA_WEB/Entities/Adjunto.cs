// Decompiled with JetBrains decompiler
// Type: MOTOR_WORKFLOW.Entities.Adjunto
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
    public class Adjunto : DALBase
    {
        public int id { get; set; }

        public string nombre { get; set; }

        public string descripcion { get; set; }

        public string etiqueta { get; set; }

        public string link { get; set; }

        public int orden { get; set; }

        public bool requerido { get; set; }

        public bool activo { get; set; }

        public int id_contenido_ingreso_paso { get; set; }

        public string ingreso_usuario { get; set; }

        public string extenciones_aceptadas { get; set; }

        public bool multiple { get; set; }

        public Adjunto()
        {
            this.id = 0;
            this.nombre = string.Empty;
            this.descripcion = string.Empty;
            this.etiqueta = string.Empty;
            this.link = string.Empty;
            this.orden = 0;
            this.requerido = false;
            this.activo = false;
            this.id_contenido_ingreso_paso = 0;
            this.ingreso_usuario = string.Empty;
            this.extenciones_aceptadas = string.Empty;
            this.multiple = false;
        }

        private static List<Adjunto> mapeo(SqlDataReader dr)
        {
            List<Adjunto> adjuntoList = new List<Adjunto>();
            if (dr.HasRows)
            {
                int ordinal1 = dr.GetOrdinal("id");
                int ordinal2 = dr.GetOrdinal("nombre");
                int ordinal3 = dr.GetOrdinal("descripcion");
                int ordinal4 = dr.GetOrdinal("etiqueta");
                int ordinal5 = dr.GetOrdinal("link");
                int ordinal6 = dr.GetOrdinal("orden");
                int ordinal7 = dr.GetOrdinal("requerido");
                int ordinal8 = dr.GetOrdinal("activo");
                int ordinal9 = dr.GetOrdinal("id_contenido_ingreso_paso");
                int ordinal10 = dr.GetOrdinal("extenciones_aceptadas");
                int ordinal11 = dr.GetOrdinal("multiple");
                while (dr.Read())
                {
                    Adjunto adjunto = new Adjunto();
                    if (!dr.IsDBNull(ordinal1))
                        adjunto.id = dr.GetInt32(ordinal1);
                    if (!dr.IsDBNull(ordinal2))
                        adjunto.nombre = dr.GetString(ordinal2);
                    if (!dr.IsDBNull(ordinal3))
                        adjunto.descripcion = dr.GetString(ordinal3);
                    if (!dr.IsDBNull(ordinal4))
                        adjunto.etiqueta = dr.GetString(ordinal4);
                    if (!dr.IsDBNull(ordinal5))
                        adjunto.link = dr.GetString(ordinal5);
                    if (!dr.IsDBNull(ordinal6))
                        adjunto.orden = dr.GetInt32(ordinal6);
                    if (!dr.IsDBNull(ordinal7))
                        adjunto.requerido = dr.GetBoolean(ordinal7);
                    if (!dr.IsDBNull(ordinal8))
                        adjunto.activo = dr.GetBoolean(ordinal8);
                    if (!dr.IsDBNull(ordinal9))
                        adjunto.id_contenido_ingreso_paso = dr.GetInt32(ordinal9);
                    if (!dr.IsDBNull(ordinal10))
                        adjunto.extenciones_aceptadas = dr.GetString(ordinal10);
                    if (!dr.IsDBNull(ordinal11))
                        adjunto.multiple = dr.GetBoolean(ordinal11);
                    adjuntoList.Add(adjunto);
                }
            }
            return adjuntoList;
        }

        public static List<Adjunto> read()
        {
            try
            {
                List<Adjunto> adjuntoList = new List<Adjunto>();
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT *FROM Adjunto";
                    command.Connection.Open();
                    return Adjunto.mapeo(command.ExecuteReader());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Adjunto getByPk(int ID)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("SELECT *FROM Adjunto WHERE");
                stringBuilder.AppendLine("id = @id");
                Adjunto byPk = (Adjunto)null;
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@id", (object)ID);
                    command.Connection.Open();
                    List<Adjunto> adjuntoList = Adjunto.mapeo(command.ExecuteReader());
                    if (adjuntoList.Count != 0)
                        byPk = adjuntoList[0];
                }
                return byPk;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int insert(AdjuntoModel obj)
        {
            try
            {
                DateTime now = DateTime.Now;
                obj.nombre = string.Format("Campo_{0}{1}{2}{3}{4}{5}", (object)now.Year, (object)now.Month, (object)now.Day, (object)now.Hour, (object)now.Minute, (object)now.Second);
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("INSERT INTO Adjunto(");
                stringBuilder.AppendLine("descripcion");
                stringBuilder.AppendLine(", nombre");
                stringBuilder.AppendLine(", etiqueta");
                stringBuilder.AppendLine(", requerido");
                stringBuilder.AppendLine(", activo");
                stringBuilder.AppendLine(", id_contenido_ingreso_paso");
                stringBuilder.AppendLine(", extenciones_aceptadas");
                stringBuilder.AppendLine(", multiple");
                stringBuilder.AppendLine(")");
                stringBuilder.AppendLine("VALUES");
                stringBuilder.AppendLine("(");
                stringBuilder.AppendLine("@descripcion");
                stringBuilder.AppendLine(", @nombre");
                stringBuilder.AppendLine(", @etiqueta");
                stringBuilder.AppendLine(", @requerido");
                stringBuilder.AppendLine(", @activo");
                stringBuilder.AppendLine(", @id_contenido_ingreso_paso");
                stringBuilder.AppendLine(", @extenciones_aceptadas");
                stringBuilder.AppendLine(", @multiple");
                stringBuilder.AppendLine(")");
                stringBuilder.AppendLine("SELECT SCOPE_IDENTITY()");
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@descripcion", (object)obj.descripcion);
                    command.Parameters.AddWithValue("@nombre", (object)obj.nombre);
                    command.Parameters.AddWithValue("@etiqueta", (object)obj.etiqueta);
                    command.Parameters.AddWithValue("@requerido", (object)obj.requerido);
                    command.Parameters.AddWithValue("@activo", (object)obj.activo);
                    command.Parameters.AddWithValue("@id_contenido_ingreso_paso", (object)obj.id_contenido_ingreso_paso);
                    command.Parameters.AddWithValue("@extenciones_aceptadas", (object)obj.extenciones_aceptadas);
                    command.Parameters.AddWithValue("@multiple", (object)obj.multiple);
                    command.Connection.Open();
                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void setNombre(int id)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("UPDATE  Adjunto SET");
                stringBuilder.AppendLine("nombre=@id");
                stringBuilder.AppendLine("WHERE");
                stringBuilder.AppendLine("id=@id");
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@nombre", (object)string.Format("{campo_{0}", (object)id));
                    command.Parameters.AddWithValue("@id", (object)id);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void update(AdjuntoModel obj)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("UPDATE  Adjunto SET");
                stringBuilder.AppendLine("descripcion=@descripcion");
                stringBuilder.AppendLine(", etiqueta=@etiqueta");
                stringBuilder.AppendLine(", requerido=@requerido");
                stringBuilder.AppendLine(", extenciones_aceptadas=@extenciones_aceptadas");
                stringBuilder.AppendLine(", multiple=@multiple");
                stringBuilder.AppendLine("WHERE");
                stringBuilder.AppendLine("id=@id");
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@descripcion", (object)obj.descripcion);
                    command.Parameters.AddWithValue("@etiqueta", (object)obj.etiqueta);
                    command.Parameters.AddWithValue("@requerido", (object)obj.requerido);
                    command.Parameters.AddWithValue("@extenciones_aceptadas", (object)obj.extenciones_aceptadas);
                    command.Parameters.AddWithValue("@multiple", (object)obj.multiple);
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

        public static void delete(Adjunto obj)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("DELETE  Adjunto ");
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
                stringBuilder.AppendLine("DELETE  Adjunto ");
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
