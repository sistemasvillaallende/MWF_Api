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
        public bool rechazado { get; set; }
        public string observaciones { get; set; }
        public int id_adjunto { get; set; } 


        public Adjuntos()
        {
            this.id = 0;
            this.nombre = string.Empty;
            this.id_pasos = 0;
            this.orden = 0;
            this.archivo = string.Empty;
            this.extenciones_aceptadas = string.Empty;
            this.multiple = false;
            rechazado = false;
            observaciones = string.Empty;
            id_adjunto = 0;
        }

        private static List<Adjuntos> mapeo(SqlDataReader dr)
        {
            List<Adjuntos> adjuntosList = new List<Adjuntos>();
            if (dr.HasRows)
            {
                int id = dr.GetOrdinal("id");
                int nombre = dr.GetOrdinal("nombre");
                int id_pasos = dr.GetOrdinal("id_pasos");
                int orden = dr.GetOrdinal("orden");
                int archivo = dr.GetOrdinal("archivo");
                int extenciones_aceptadas = dr.GetOrdinal("extenciones_aceptadas");
                int multiple = dr.GetOrdinal("multiple");

                int rechazado = dr.GetOrdinal("rechazado");
                int observaciones = dr.GetOrdinal("observaciones");
                int id_adjunto = dr.GetOrdinal("id_adjunto");

                while (dr.Read())
                {
                    Adjuntos adjuntos = new Adjuntos();
                    if (!dr.IsDBNull(id))
                        adjuntos.id = dr.GetInt32(id);
                    if (!dr.IsDBNull(nombre))
                        adjuntos.nombre = dr.GetString(nombre);
                    if (!dr.IsDBNull(id_pasos))
                        adjuntos.id_pasos = dr.GetInt32(id_pasos);
                    if (!dr.IsDBNull(orden))
                        adjuntos.orden = dr.GetInt32(orden);
                    if (!dr.IsDBNull(archivo))
                        adjuntos.archivo = dr.GetString(archivo);
                    if (!dr.IsDBNull(extenciones_aceptadas))
                        adjuntos.extenciones_aceptadas = dr.GetString(extenciones_aceptadas);
                    if (!dr.IsDBNull(multiple))
                        adjuntos.multiple = dr.GetBoolean(multiple);
                    if (!dr.IsDBNull(rechazado))
                        adjuntos.rechazado = dr.GetBoolean(rechazado);
                    if (!dr.IsDBNull(observaciones))
                        adjuntos.observaciones = dr.GetString(observaciones);
                    if (!dr.IsDBNull(id_adjunto))
                        adjuntos.id_adjunto = dr.GetInt32(id_adjunto);
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
                    command.Parameters.AddWithValue("@id", id);
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
                    command.Parameters.AddWithValue("@id_pasos", id_pasos);
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
                stringBuilder.AppendLine(", rechazado");
                stringBuilder.AppendLine(", observaciones");
                stringBuilder.AppendLine(", id_adjunto");
                stringBuilder.AppendLine(")");
                stringBuilder.AppendLine("VALUES");
                stringBuilder.AppendLine("(");
                stringBuilder.AppendLine("@nombre");
                stringBuilder.AppendLine(", @id_pasos");
                stringBuilder.AppendLine(", @orden");
                stringBuilder.AppendLine(", @archivo");
                stringBuilder.AppendLine(", @extenciones_aceptadas");
                stringBuilder.AppendLine(", @multiple");
                stringBuilder.AppendLine(", @rechazado");
                stringBuilder.AppendLine(", @observaciones");
                stringBuilder.AppendLine(", @id_adjunto");
                stringBuilder.AppendLine(")");
                stringBuilder.AppendLine("SELECT SCOPE_IDENTITY()");
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@nombre", obj.nombre);
                    command.Parameters.AddWithValue("@id_pasos", obj.id_pasos);
                    command.Parameters.AddWithValue("@orden", obj.orden);
                    command.Parameters.AddWithValue("@archivo", obj.archivo);
                    command.Parameters.AddWithValue("@extenciones_aceptadas", obj.extenciones_aceptadas);
                    command.Parameters.AddWithValue("@multiple", obj.multiple);
                    command.Parameters.AddWithValue("@rechazado", false);
                    command.Parameters.AddWithValue("@observaciones", "");
                    command.Parameters.AddWithValue("@id_adjunto", obj.id_adjunto);
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
                    command.Parameters.AddWithValue("@nombre", obj.nombre);
                    command.Parameters.AddWithValue("@id_pasos", obj.id_pasos);
                    command.Parameters.AddWithValue("@orden", obj.orden);
                    command.Parameters.AddWithValue("@archivo", obj.archivo);
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
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@archivo", archivo);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void RechazaArchivo(int id, string obs)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("UPDATE  Adjuntos SET");
                stringBuilder.AppendLine("rechazado=@rechazado");
                stringBuilder.AppendLine("observaciones=@observaciones");
                stringBuilder.AppendLine("WHERE");
                stringBuilder.AppendLine("id=@id");
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@rechazado", 1);
                    command.Parameters.AddWithValue("@observaciones", obs);
                    command.Parameters.AddWithValue("@id", id);
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
