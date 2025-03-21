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

        public string cod_enlaza { get; set; }

        public int SUBSISTEMA { get; set; }

        public int NRO_TRAN { get; set; }

        public string URL_LINK_PAGO { get; set; }


        public string TITULO { get; set; }

        public string SUBTITULO { get; set; }

        public string TEXTO { get; set; }

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
            cod_enlaza = string.Empty;
            SUBSISTEMA = 0;
            NRO_TRAN = 0;
            URL_LINK_PAGO = string.Empty;
            TITULO = string.Empty;
            SUBTITULO = string.Empty;
            TEXTO = string.Empty;
        }

        private static List<campos_x_formulario> mapeo(SqlDataReader dr)
        {
            List<campos_x_formulario> camposXFormularioList = new List<campos_x_formulario>();
            if (dr.HasRows)
            {
                int id = dr.GetOrdinal("id");
                int id_formulario = dr.GetOrdinal("id_formulario");
                int id_tipo_campo = dr.GetOrdinal("id_tipo_campo");
                int nombre = dr.GetOrdinal("nombre");
                int etiqueta = dr.GetOrdinal("etiqueta");
                int place_holder = dr.GetOrdinal("place_holder");
                int orden = dr.GetOrdinal("orden");
                int activo = dr.GetOrdinal("activo");
                int requerido = dr.GetOrdinal("requerido");
                int id_ws = dr.GetOrdinal("id_ws");
                int value = dr.GetOrdinal("value");
                int text = dr.GetOrdinal("text");
                int carga_manual = dr.GetOrdinal("carga_manual");
                int contenido_campo = dr.GetOrdinal("contenido_campo");
                int min_value = dr.GetOrdinal("min_value");
                int max_value = dr.GetOrdinal("max_value");
                int min_length = dr.GetOrdinal("min_length");
                int max_length = dr.GetOrdinal("max_length");
                int min_fecha = dr.GetOrdinal("min_fecha");
                int max_fecha = dr.GetOrdinal("max_fecha");
                int MENSAJE_ERROR = dr.GetOrdinal("MENSAJE_ERROR");
                int formato_resultado = dr.GetOrdinal("formato_resultado");
                int row = dr.GetOrdinal("row");
                int col = dr.GetOrdinal("col");
                int cod_enlaza = dr.GetOrdinal("cod_enlaza");
                int SUBSISTEMA = dr.GetOrdinal("SUBSISTEMA");
                int NRO_TRAN = dr.GetOrdinal("NRO_TRAN");
                int URL_LINK_PAGO = dr.GetOrdinal("URL_LINK_PAGO");
                int TITULO = dr.GetOrdinal("TITULO");
                int SUBTITULO = dr.GetOrdinal("SUBTITULO");
                int TEXTO = dr.GetOrdinal("TEXTO");

                while (dr.Read())
                {
                    campos_x_formulario camposXFormulario = new campos_x_formulario();
                    if (!dr.IsDBNull(id))
                        camposXFormulario.id = dr.GetInt32(id);
                    if (!dr.IsDBNull(id_formulario))
                        camposXFormulario.id_formulario = dr.GetInt32(id_formulario);
                    if (!dr.IsDBNull(id_tipo_campo))
                        camposXFormulario.id_tipo_campo = dr.GetInt32(id_tipo_campo);
                    if (!dr.IsDBNull(nombre))
                        camposXFormulario.nombre = dr.GetString(nombre);
                    if (!dr.IsDBNull(etiqueta))
                        camposXFormulario.etiqueta = dr.GetString(etiqueta);
                    if (!dr.IsDBNull(place_holder))
                        camposXFormulario.place_holder = dr.GetString(place_holder);
                    if (!dr.IsDBNull(orden))
                        camposXFormulario.orden = dr.GetInt32(orden);
                    if (!dr.IsDBNull(activo))
                        camposXFormulario.activo = dr.GetBoolean(activo);
                    if (!dr.IsDBNull(requerido))
                        camposXFormulario.requerido = dr.GetBoolean(requerido);
                    if (!dr.IsDBNull(id_ws))
                        camposXFormulario.id_ws = dr.GetInt32(id_ws);
                    if (!dr.IsDBNull(value))
                        camposXFormulario.value = dr.GetString(value);
                    if (!dr.IsDBNull(text))
                        camposXFormulario.text = dr.GetString(text);
                    if (!dr.IsDBNull(carga_manual))
                        camposXFormulario.carga_manual = dr.GetBoolean(carga_manual);
                    if (!dr.IsDBNull(contenido_campo))
                        camposXFormulario.contenido_campo = dr.GetString(contenido_campo);
                    if (!dr.IsDBNull(min_value))
                        camposXFormulario.min_value = dr.GetInt32(min_value);
                    if (!dr.IsDBNull(max_value))
                        camposXFormulario.max_value = dr.GetInt32(max_value);
                    if (!dr.IsDBNull(min_length))
                        camposXFormulario.min_length = dr.GetInt32(min_length);
                    if (!dr.IsDBNull(max_length))
                        camposXFormulario.max_length = dr.GetInt32(max_length);
                    if (!dr.IsDBNull(min_fecha))
                        camposXFormulario.min_fecha = new DateTime?(dr.GetDateTime(min_fecha));
                    if (!dr.IsDBNull(max_fecha))
                        camposXFormulario.max_fecha = new DateTime?(dr.GetDateTime(max_fecha));
                    if (!dr.IsDBNull(MENSAJE_ERROR))
                        camposXFormulario.mensaje_error = dr.GetString(MENSAJE_ERROR);
                    if (!dr.IsDBNull(formato_resultado))
                        camposXFormulario.formato_resultado = dr.GetString(formato_resultado);
                    if (!dr.IsDBNull(row))
                        camposXFormulario.row = dr.GetInt32(row);
                    if (!dr.IsDBNull(col))
                        camposXFormulario.col = dr.GetInt32(col);
                    if (!dr.IsDBNull(cod_enlaza))
                        camposXFormulario.cod_enlaza = dr.GetString(cod_enlaza);
                    if (!dr.IsDBNull(SUBSISTEMA))
                        camposXFormulario.SUBSISTEMA = dr.GetInt32(SUBSISTEMA);
                    if (!dr.IsDBNull(NRO_TRAN))
                        camposXFormulario.NRO_TRAN = dr.GetInt32(NRO_TRAN);
                    if (!dr.IsDBNull(URL_LINK_PAGO))
                        camposXFormulario.URL_LINK_PAGO = dr.GetString(URL_LINK_PAGO); 
                        
                    if (!dr.IsDBNull(TITULO))
                        camposXFormulario.TITULO = dr.GetString(TITULO);
                    if (!dr.IsDBNull(SUBTITULO))
                        camposXFormulario.SUBTITULO = dr.GetString(SUBTITULO);
                    if (!dr.IsDBNull(TEXTO))
                        camposXFormulario.TEXTO = dr.GetString(TEXTO);
                    if (camposXFormulario.id_ws != 0)
                    {
  
                            Ws_web_service ws = Ws_web_service.getByPk(camposXFormulario.id_ws);
                            string url = ws.URL;
                            RestResponse restResponse = new RestClient(url).Execute(new RestRequest()
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
                    command.Parameters.AddWithValue("@id_formulario", idFormulario);
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
                    command.CommandText = @"
                        SELECT ISNULL(MAX(orden), 0)      
                        FROM campos_x_formulario   
                        WHERE id_formulario = @id_formulario";

                    command.Parameters.AddWithValue("@id_formulario", idFormulario);
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
                    command.CommandText = @"
                        SELECT ISNULL(MAX(row), 0) 
                        FROM campos_x_formulario 
                        WHERE id_formulario = @id_formulario";
                    command.Parameters.AddWithValue("@id_formulario", idFormulario);
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
                    command.Parameters.AddWithValue("@id", ID);
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
                if (obj.nombre == string.Empty)
                    obj.nombre = string.Format("Campo_{0}{1}{2}{3}{4}{5}", now.Year, now.Month, now.Day, now.Hour, now.Minute, now.Second);
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
                if (obj.cod_enlaza != string.Empty)
                    stringBuilder.AppendLine(",cod_enlaza");

                if (obj.SUBSISTEMA != 0)
                    stringBuilder.AppendLine(",SUBSISTEMA");
                if (obj.NRO_TRAN != 0)
                    stringBuilder.AppendLine(",NRO_TRAN");
                if (obj.URL_LINK_PAGO != string.Empty)
                    stringBuilder.AppendLine(",URL_LINK_PAGO");

                if (obj.TITULO != string.Empty)
                    stringBuilder.AppendLine(",TITULO");
                if (obj.SUBTITULO != string.Empty)
                    stringBuilder.AppendLine(",SUBTITULO");
                if (obj.TEXTO != string.Empty)
                    stringBuilder.AppendLine(",TEXTO");

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
                if (obj.cod_enlaza != string.Empty)
                    stringBuilder.AppendLine(", @cod_enlaza");

                if (obj.SUBSISTEMA != 0)
                    stringBuilder.AppendLine(", @SUBSISTEMA");
                if (obj.NRO_TRAN != 0)
                    stringBuilder.AppendLine(", @NRO_TRAN");
                if (obj.URL_LINK_PAGO != string.Empty)
                    stringBuilder.AppendLine(", @URL_LINK_PAGO");

                if (obj.TITULO != string.Empty)
                    stringBuilder.AppendLine(",@TITULO");
                if (obj.SUBTITULO != string.Empty)
                    stringBuilder.AppendLine(",@SUBTITULO");
                if (obj.TEXTO != string.Empty)
                    stringBuilder.AppendLine(",@TEXTO");

                stringBuilder.AppendLine(")");
                stringBuilder.AppendLine("SELECT SCOPE_IDENTITY()");
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@id_formulario", obj.id_formulario);
                    command.Parameters.AddWithValue("@id_tipo_campo", obj.id_tipo_campo);
                    command.Parameters.AddWithValue("@nombre", obj.nombre);
                    command.Parameters.AddWithValue("@etiqueta", obj.etiqueta);
                    command.Parameters.AddWithValue("@place_holder", obj.place_holder);
                    command.Parameters.AddWithValue("@orden", obj.orden);
                    command.Parameters.AddWithValue("@activo", obj.activo);
                    command.Parameters.AddWithValue("@requerido", obj.requerido);
                    if (obj.id_ws != 0)
                        command.Parameters.AddWithValue("@id_ws", obj.id_ws);
                    if (obj.value != string.Empty)
                        command.Parameters.AddWithValue("@value", obj.value);
                    if (obj.text != string.Empty)
                        command.Parameters.AddWithValue("@text", obj.text);
                    if (obj.formato_resultado != string.Empty)
                        command.Parameters.AddWithValue("@formato_resultado", obj.formato_resultado);
                    command.Parameters.AddWithValue("@row", obj.row);
                    command.Parameters.AddWithValue("@col", obj.col);
                    if (obj.cod_enlaza != string.Empty)
                        command.Parameters.AddWithValue("@cod_enlaza", obj.cod_enlaza);

                    if (obj.SUBSISTEMA != 0)
                        command.Parameters.AddWithValue("@SUBSISTEMA", obj.SUBSISTEMA);
                    if (obj.NRO_TRAN != 0)
                        command.Parameters.AddWithValue("@NRO_TRAN", obj.NRO_TRAN);
                    if (obj.URL_LINK_PAGO != string.Empty)
                        command.Parameters.AddWithValue("@URL_LINK_PAGO", obj.URL_LINK_PAGO);

                    if (obj.SUBTITULO != string.Empty)
                        command.Parameters.AddWithValue("@TITULO", obj.TITULO);
                    if (obj.SUBTITULO != string.Empty)
                        command.Parameters.AddWithValue("@SUBTITULO", obj.SUBTITULO);
                    if (obj.TEXTO != string.Empty)
                        command.Parameters.AddWithValue("@TEXTO", obj.TEXTO);

                    command.Connection.Open();
                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void insertenlazados(List<CampoTextoModel> lst)
        {
            try
            {
                foreach (var obj in lst)
                {
                    insert(obj);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void updateenlazados(List<CampoTextoModel> lst)
        {
            try
            {
                foreach (var obj in lst)
                {
                    update(obj);
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

                if (obj.SUBSISTEMA != 0)
                    stringBuilder.AppendLine(", SUBSISTEMA=@SUBSISTEMA");
                if (obj.NRO_TRAN != 0)
                    stringBuilder.AppendLine(", NRO_TRAN=@NRO_TRAN");
                if (obj.URL_LINK_PAGO != string.Empty)
                    stringBuilder.AppendLine(", URL_LINK_PAGO=@URL_LINK_PAGO");

                if (obj.TITULO != string.Empty)
                    stringBuilder.AppendLine(", TITULO=@TITULO");
                if (obj.SUBTITULO != string.Empty)
                    stringBuilder.AppendLine(", SUBTITULO=@SUBTITULO");
                if (obj.TEXTO != string.Empty)
                    stringBuilder.AppendLine(", TEXTO=@TEXTO");

                stringBuilder.AppendLine("WHERE");
                stringBuilder.AppendLine("id=@id");
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@etiqueta", obj.etiqueta);
                    command.Parameters.AddWithValue("@place_holder", obj.place_holder);
                    command.Parameters.AddWithValue("@requerido", obj.requerido);
                    if (obj.id_ws != 0)
                        command.Parameters.AddWithValue("@id_ws", obj.id_ws);
                    command.Parameters.AddWithValue("@value", obj.value);
                    command.Parameters.AddWithValue("@text", obj.text);
                    command.Parameters.AddWithValue("@formato_resultado", obj.formato_resultado);
                    command.Parameters.AddWithValue("@id", obj.id);

                    if (obj.SUBSISTEMA != 0)
                        command.Parameters.AddWithValue("@SUBSISTEMA", obj.SUBSISTEMA);
                    if (obj.NRO_TRAN != 0)
                        command.Parameters.AddWithValue("@NRO_TRAN", obj.NRO_TRAN);
                    if (obj.URL_LINK_PAGO != string.Empty)
                        command.Parameters.AddWithValue("@URL_LINK_PAGO", obj.URL_LINK_PAGO);

                    if (obj.SUBTITULO != string.Empty)
                        command.Parameters.AddWithValue("@TITULO", obj.TITULO);
                    if (obj.SUBTITULO != string.Empty)
                        command.Parameters.AddWithValue("@SUBTITULO", obj.SUBTITULO);
                    if (obj.TEXTO != string.Empty)
                        command.Parameters.AddWithValue("@TEXTO", obj.TEXTO);

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
    }
}
