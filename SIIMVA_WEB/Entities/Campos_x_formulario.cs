using RestSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

#nullable enable
namespace MOTOR_WORKFLOW.Entities
{
    public class campos_x_formulario : DALBase
    {
        public int id { get; set; }

        public int id_formulario { get; set; }

        public int id_tipo_campo { get; set; }

        public string nombre { get; set; }

        public string etiqueta { get; set; }

        public string place_holder { get; set; }

        public int orden { get; set; }

        public bool activo { get; set; }

        public bool requerido { get; set; }

        public int id_ws { get; set; }

        public string value { get; set; }

        public string text { get; set; }

        public bool carga_manual { get; set; }

        public string contenido_campo { get; set; }

        public string ingreso_usuario { get; set; }

        public int min_value { get; set; }

        public int max_value { get; set; }

        public int min_length { get; set; }

        public int max_length { get; set; }

        public string mensaje_error { get; set; }

        public DateTime? min_fecha { get; set; }

        public DateTime? max_fecha { get; set; }

        public string formato_resultado { get; set; }

        public int row { get; set; }

        public int col { get; set; }

        public campos_x_formulario()
        {
            this.id = 0;
            this.id_formulario = 0;
            this.id_tipo_campo = 0;
            this.nombre = string.Empty;
            this.etiqueta = string.Empty;
            this.place_holder = string.Empty;
            this.orden = 0;
            this.activo = false;
            this.requerido = false;
            this.id_ws = 0;
            this.value = string.Empty;
            this.text = string.Empty;
            this.carga_manual = false;
            this.contenido_campo = string.Empty;
            this.ingreso_usuario = string.Empty;
            this.min_value = 0;
            this.max_value = 0;
            this.min_length = 0;
            this.max_length = 0;
            this.min_fecha = new DateTime?();
            this.max_fecha = new DateTime?();
            this.mensaje_error = string.Empty;
            this.formato_resultado = string.Empty;
            this.row = 0;
            this.col = 0;
        }

        private static List<campos_x_formulario> mapeo(SqlDataReader dr)
        {
            List<campos_x_formulario> camposXFormularioList = new List<campos_x_formulario>();
            if (dr.HasRows)
            {
                int ordinal1 = dr.GetOrdinal("id");
                int ordinal2 = dr.GetOrdinal("id_formulario");
                int ordinal3 = dr.GetOrdinal("id_tipo_campo");
                int ordinal4 = dr.GetOrdinal("nombre");
                int ordinal5 = dr.GetOrdinal("etiqueta");
                int ordinal6 = dr.GetOrdinal("place_holder");
                int ordinal7 = dr.GetOrdinal("orden");
                int ordinal8 = dr.GetOrdinal("activo");
                int ordinal9 = dr.GetOrdinal("requerido");
                int ordinal10 = dr.GetOrdinal("id_ws");
                int ordinal11 = dr.GetOrdinal("value");
                int ordinal12 = dr.GetOrdinal("text");
                int ordinal13 = dr.GetOrdinal("carga_manual");
                int ordinal14 = dr.GetOrdinal("contenido_campo");
                int ordinal15 = dr.GetOrdinal("min_value");
                int ordinal16 = dr.GetOrdinal("max_value");
                int ordinal17 = dr.GetOrdinal("min_length");
                int ordinal18 = dr.GetOrdinal("max_length");
                int ordinal19 = dr.GetOrdinal("min_fecha");
                int ordinal20 = dr.GetOrdinal("max_fecha");
                int ordinal21 = dr.GetOrdinal("MENSAJE_ERROR");
                int ordinal22 = dr.GetOrdinal("formato_resultado");
                int ordinal23 = dr.GetOrdinal("row");
                int ordinal24 = dr.GetOrdinal("col");
                while (dr.Read())
                {
                    campos_x_formulario camposXFormulario = new campos_x_formulario();
                    if (!dr.IsDBNull(ordinal1))
                        camposXFormulario.id = dr.GetInt32(ordinal1);
                    if (!dr.IsDBNull(ordinal2))
                        camposXFormulario.id_formulario = dr.GetInt32(ordinal2);
                    if (!dr.IsDBNull(ordinal3))
                        camposXFormulario.id_tipo_campo = dr.GetInt32(ordinal3);
                    if (!dr.IsDBNull(ordinal4))
                        camposXFormulario.nombre = dr.GetString(ordinal4);
                    if (!dr.IsDBNull(ordinal5))
                        camposXFormulario.etiqueta = dr.GetString(ordinal5);
                    if (!dr.IsDBNull(ordinal6))
                        camposXFormulario.place_holder = dr.GetString(ordinal6);
                    if (!dr.IsDBNull(ordinal7))
                        camposXFormulario.orden = dr.GetInt32(ordinal7);
                    if (!dr.IsDBNull(ordinal8))
                        camposXFormulario.activo = dr.GetBoolean(ordinal8);
                    if (!dr.IsDBNull(ordinal9))
                        camposXFormulario.requerido = dr.GetBoolean(ordinal9);
                    if (!dr.IsDBNull(ordinal10))
                        camposXFormulario.id_ws = dr.GetInt32(ordinal10);
                    if (!dr.IsDBNull(ordinal11))
                        camposXFormulario.value = dr.GetString(ordinal11);
                    if (!dr.IsDBNull(ordinal12))
                        camposXFormulario.text = dr.GetString(ordinal12);
                    if (!dr.IsDBNull(ordinal13))
                        camposXFormulario.carga_manual = dr.GetBoolean(ordinal13);
                    if (!dr.IsDBNull(ordinal14))
                        camposXFormulario.contenido_campo = dr.GetString(ordinal14);
                    if (!dr.IsDBNull(ordinal15))
                        camposXFormulario.min_value = dr.GetInt32(ordinal15);
                    if (!dr.IsDBNull(ordinal16))
                        camposXFormulario.max_value = dr.GetInt32(ordinal16);
                    if (!dr.IsDBNull(ordinal17))
                        camposXFormulario.min_length = dr.GetInt32(ordinal17);
                    if (!dr.IsDBNull(ordinal18))
                        camposXFormulario.max_length = dr.GetInt32(ordinal18);
                    if (!dr.IsDBNull(ordinal19))
                        camposXFormulario.min_fecha = new DateTime?(dr.GetDateTime(ordinal19));
                    if (!dr.IsDBNull(ordinal20))
                        camposXFormulario.max_fecha = new DateTime?(dr.GetDateTime(ordinal20));
                    if (!dr.IsDBNull(ordinal21))
                        camposXFormulario.mensaje_error = dr.GetString(ordinal21);
                    if (!dr.IsDBNull(ordinal22))
                        camposXFormulario.formato_resultado = dr.GetString(ordinal22);
                    if (!dr.IsDBNull(ordinal23))
                        camposXFormulario.row = dr.GetInt32(ordinal23);
                    if (!dr.IsDBNull(ordinal24))
                        camposXFormulario.col = dr.GetInt32(ordinal24);
                    if (camposXFormulario.id_ws != 0)
                    {
                        RestResponse restResponse = new RestClient(Ws_web_service.getByPk(camposXFormulario.id_ws).URL).Execute(new RestRequest()
                        {
                            Method = Method.Get
                        });
                        camposXFormulario.contenido_campo = restResponse.Content;
                    }
                    camposXFormularioList.Add(camposXFormulario);
                }
            }
            return camposXFormularioList;
        }

        public static List<campos_x_formulario> read(int idFormulario)
        {
            try
            {
                List<campos_x_formulario> camposXFormularioList = new List<campos_x_formulario>();
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT *FROM campos_x_formulario WHERE id_formulario = @id_formulario";
                    command.Parameters.AddWithValue("@id_formulario", (object)idFormulario);
                    command.Connection.Open();
                    return campos_x_formulario.mapeo(command.ExecuteReader());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int getMaxOrden(int idFormulario)
        {
            try
            {
                List<campos_x_formulario> camposXFormularioList = new List<campos_x_formulario>();
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT ISNULL(MAX(orden), 0)                                 FROM campos_x_formulario                                 WHERE id_formulario = @id_formulario";
                    command.Parameters.AddWithValue("@id_formulario", (object)idFormulario);
                    command.Connection.Open();
                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int getMaxRow(int idFormulario)
        {
            try
            {
                List<campos_x_formulario> camposXFormularioList = new List<campos_x_formulario>();
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT ISNULL(MAX(row), 0)                                 FROM campos_x_formulario                                 WHERE id_formulario = @id_formulario";
                    command.Parameters.AddWithValue("@id_formulario", (object)idFormulario);
                    command.Connection.Open();
                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static campos_x_formulario getByPk(int ID)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("SELECT *FROM campos_x_formulario WHERE");
                stringBuilder.AppendLine("id = @id");
                campos_x_formulario byPk = (campos_x_formulario)null;
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@id", (object)ID);
                    command.Connection.Open();
                    List<campos_x_formulario> camposXFormularioList = campos_x_formulario.mapeo(command.ExecuteReader());
                    if (camposXFormularioList.Count != 0)
                        byPk = camposXFormularioList[0];
                }
                return byPk;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int insert(CampoTextoModel obj)
        {
            try
            {
                int num1 = campos_x_formulario.getMaxOrden(obj.id) + 1;
                int num2 = campos_x_formulario.getMaxRow(obj.id) + 1;
                obj.orden = num1;
                obj.row = num2;
                DateTime now = DateTime.Now;
                obj.nombre = string.Format("Campo_{0}{1}{2}{3}{4}{5}", (object)now.Year, (object)now.Month, (object)now.Day, (object)now.Hour, (object)now.Minute, (object)now.Second);
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("INSERT INTO campos_x_formulario(");
                stringBuilder.AppendLine("id_formulario");
                stringBuilder.AppendLine(", id_tipo_campo");
                stringBuilder.AppendLine(", nombre");
                stringBuilder.AppendLine(", etiqueta");
                stringBuilder.AppendLine(", place_holder");
                stringBuilder.AppendLine(", orden");
                stringBuilder.AppendLine(", activo");
                stringBuilder.AppendLine(", requerido");
                if (obj.id_ws != 0)
                    stringBuilder.AppendLine(", id_ws");
                if (obj.value != string.Empty)
                    stringBuilder.AppendLine(", value");
                if (obj.text != string.Empty)
                    stringBuilder.AppendLine(", text");
                if (obj.formato_resultado != string.Empty)
                    stringBuilder.AppendLine(", formato_resultado");
                stringBuilder.AppendLine(", row");
                stringBuilder.AppendLine(", col");
                stringBuilder.AppendLine(")");
                stringBuilder.AppendLine("VALUES");
                stringBuilder.AppendLine("(");
                stringBuilder.AppendLine("@id_formulario");
                stringBuilder.AppendLine(", @id_tipo_campo");
                stringBuilder.AppendLine(", @nombre");
                stringBuilder.AppendLine(", @etiqueta");
                stringBuilder.AppendLine(", @place_holder");
                stringBuilder.AppendLine(", @orden");
                stringBuilder.AppendLine(", @activo");
                stringBuilder.AppendLine(", @requerido");
                if (obj.id_ws != 0)
                    stringBuilder.AppendLine(", @id_ws");
                if (obj.value != string.Empty)
                    stringBuilder.AppendLine(", @value");
                if (obj.text != string.Empty)
                    stringBuilder.AppendLine(", @text");
                if (obj.formato_resultado != string.Empty)
                    stringBuilder.AppendLine(", @formato_resultado");
                stringBuilder.AppendLine(", @row");
                stringBuilder.AppendLine(", @col");
                stringBuilder.AppendLine(")");
                stringBuilder.AppendLine("SELECT SCOPE_IDENTITY()");
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@id_formulario", (object)obj.id_formulario);
                    command.Parameters.AddWithValue("@id_tipo_campo", (object)obj.id_tipo_campo);
                    command.Parameters.AddWithValue("@nombre", (object)obj.nombre);
                    command.Parameters.AddWithValue("@etiqueta", (object)obj.etiqueta);
                    command.Parameters.AddWithValue("@place_holder", (object)obj.place_holder);
                    command.Parameters.AddWithValue("@orden", (object)obj.orden);
                    command.Parameters.AddWithValue("@activo", (object)obj.activo);
                    command.Parameters.AddWithValue("@requerido", (object)obj.requerido);
                    if (obj.id_ws != 0)
                        command.Parameters.AddWithValue("@id_ws", (object)obj.id_ws);
                    if (obj.value != string.Empty)
                        command.Parameters.AddWithValue("@value", (object)obj.value);
                    if (obj.text != string.Empty)
                        command.Parameters.AddWithValue("@text", (object)obj.text);
                    if (obj.formato_resultado != string.Empty)
                        command.Parameters.AddWithValue("@formato_resultado", (object)obj.formato_resultado);
                    command.Parameters.AddWithValue("@row", (object)obj.row);
                    command.Parameters.AddWithValue("@col", (object)obj.col);
                    command.Connection.Open();
                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void update(CampoTextoModel obj)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("UPDATE  campos_x_formulario SET");
                stringBuilder.AppendLine("etiqueta=@etiqueta");
                stringBuilder.AppendLine(", place_holder=@place_holder");
                stringBuilder.AppendLine(", requerido=@requerido");
                if (obj.id_ws != 0)
                    stringBuilder.AppendLine(", id_ws=@id_ws");
                stringBuilder.AppendLine(", value=@value");
                stringBuilder.AppendLine(", text=@text");
                stringBuilder.AppendLine(", formato_resultado=@formato_resultado");
                stringBuilder.AppendLine("WHERE");
                stringBuilder.AppendLine("id=@id");
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@etiqueta", (object)obj.etiqueta);
                    command.Parameters.AddWithValue("@place_holder", (object)obj.place_holder);
                    command.Parameters.AddWithValue("@requerido", (object)obj.requerido);
                    if (obj.id_ws != 0)
                        command.Parameters.AddWithValue("@id_ws", (object)obj.id_ws);
                    command.Parameters.AddWithValue("@value", (object)obj.value);
                    command.Parameters.AddWithValue("@text", (object)obj.text);
                    command.Parameters.AddWithValue("@formato_resultado", (object)obj.formato_resultado);
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

        public static void delete(int id)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("DELETE  campos_x_formulario ");
                stringBuilder.AppendLine("WHERE");
                stringBuilder.AppendLine("id=@id");
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
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
    }
}
