using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

#nullable enable
namespace MOTOR_WORKFLOW.Entities
{
    public class Adjuntos : DALBase
    {
        public int id { get; set; }

        public string nombre { get; set; }

        public int id_pasos { get; set; }

        public int orden { get; set; }

        public string archivo { get; set; }

        public string extenciones_aceptadas { get; set; }

        public bool multiple { get; set; }

        public Adjuntos()
        {
            this.id = 0;
            this.nombre = string.Empty;
            this.id_pasos = 0;
            this.orden = 0;
            this.archivo = string.Empty;
            this.extenciones_aceptadas = string.Empty;
            this.multiple = false;
        }

        private static List<Adjuntos> mapeo(SqlDataReader dr)
        {
            List<Adjuntos> adjuntosList = new List<Adjuntos>();
            if (dr.HasRows)
            {
                int ordinal1 = dr.GetOrdinal("id");
                int ordinal2 = dr.GetOrdinal("nombre");
                int ordinal3 = dr.GetOrdinal("id_pasos");
                int ordinal4 = dr.GetOrdinal("orden");
                int ordinal5 = dr.GetOrdinal("archivo");
                int ordinal6 = dr.GetOrdinal("extenciones_aceptadas");
                int ordinal7 = dr.GetOrdinal("multiple");
                while (dr.Read())
                {
                    Adjuntos adjuntos = new Adjuntos();
                    if (!dr.IsDBNull(ordinal1))
                        adjuntos.id = dr.GetInt32(ordinal1);
                    if (!dr.IsDBNull(ordinal2))
                        adjuntos.nombre = dr.GetString(ordinal2);
                    if (!dr.IsDBNull(ordinal3))
                        adjuntos.id_pasos = dr.GetInt32(ordinal3);
                    if (!dr.IsDBNull(ordinal4))
                        adjuntos.orden = dr.GetInt32(ordinal4);
                    if (!dr.IsDBNull(ordinal5))
                        adjuntos.archivo = dr.GetString(ordinal5);
                    if (!dr.IsDBNull(ordinal6))
                        adjuntos.extenciones_aceptadas = dr.GetString(ordinal6);
                    if (!dr.IsDBNull(ordinal7))
                        adjuntos.multiple = dr.GetBoolean(ordinal7);
                    adjuntosList.Add(adjuntos);
                }
            }
            return adjuntosList;
        }

        public static List<Adjuntos> read()
        {
            try
            {
                List<Adjuntos> adjuntosList = new List<Adjuntos>();
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT *FROM Adjuntos";
                    command.Connection.Open();
                    return Adjuntos.mapeo(command.ExecuteReader());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Adjuntos getByPk(int id)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("SELECT *FROM Adjuntos WHERE");
                stringBuilder.AppendLine("id = @id");
                Adjuntos byPk = (Adjuntos)null;
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@id", (object)id);
                    command.Connection.Open();
                    List<Adjuntos> adjuntosList = Adjuntos.mapeo(command.ExecuteReader());
                    if (adjuntosList.Count != 0)
                        byPk = adjuntosList[0];
                }
                return byPk;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Adjuntos getByIdPasos(int id_pasos)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("SELECT *FROM Adjuntos WHERE");
                stringBuilder.AppendLine("id_pasos = @id_pasos");
                Adjuntos byIdPasos = (Adjuntos)null;
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@id_pasos", (object)id_pasos);
                    command.Connection.Open();
                    List<Adjuntos> adjuntosList = Adjuntos.mapeo(command.ExecuteReader());
                    if (adjuntosList.Count != 0)
                        byIdPasos = adjuntosList[0];
                }
                return byIdPasos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int insert(Adjuntos obj)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("INSERT INTO Adjuntos(");
                stringBuilder.AppendLine("nombre");
                stringBuilder.AppendLine(", id_pasos");
                stringBuilder.AppendLine(", orden");
                stringBuilder.AppendLine(", archivo");
                stringBuilder.AppendLine(", extenciones_aceptadas");
                stringBuilder.AppendLine(", multiple");
                stringBuilder.AppendLine(")");
                stringBuilder.AppendLine("VALUES");
                stringBuilder.AppendLine("(");
                stringBuilder.AppendLine("@nombre");
                stringBuilder.AppendLine(", @id_pasos");
                stringBuilder.AppendLine(", @orden");
                stringBuilder.AppendLine(", @archivo");
                stringBuilder.AppendLine(", @extenciones_aceptadas");
                stringBuilder.AppendLine(", @multiple");
                stringBuilder.AppendLine(")");
                stringBuilder.AppendLine("SELECT SCOPE_IDENTITY()");
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@nombre", (object)obj.nombre);
                    command.Parameters.AddWithValue("@id_pasos", (object)obj.id_pasos);
                    command.Parameters.AddWithValue("@orden", (object)obj.orden);
                    command.Parameters.AddWithValue("@archivo", (object)obj.archivo);
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

        public static void update(Adjuntos obj)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("UPDATE  Adjuntos SET");
                stringBuilder.AppendLine("nombre=@nombre");
                stringBuilder.AppendLine(", id_pasos=@id_pasos");
                stringBuilder.AppendLine(", orden=@orden");
                stringBuilder.AppendLine(", archivo=@archivo");
                stringBuilder.AppendLine("WHERE");
                stringBuilder.AppendLine("id=@id");
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@nombre", (object)obj.nombre);
                    command.Parameters.AddWithValue("@id_pasos", (object)obj.id_pasos);
                    command.Parameters.AddWithValue("@orden", (object)obj.orden);
                    command.Parameters.AddWithValue("@archivo", (object)obj.archivo);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void setArchivo(int id, string archivo)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("UPDATE  Adjuntos SET");
                stringBuilder.AppendLine("archivo=@archivo");
                stringBuilder.AppendLine("WHERE");
                stringBuilder.AppendLine("id=@id");
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@id", (object)id);
                    command.Parameters.AddWithValue("@archivo", (object)archivo);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void delete(Adjuntos obj)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("DELETE  Adjuntos ");
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
