namespace MOTOR_WORKFLOW.Models
{
    public class PasoModel
    {
        public int ID_PASO { get; set; }
        public string NOMBRE { get; set; }
        public int ID_INGRESOS_PASO { get; set; }
        public string NOMBRE_PASO { get; set; }
        public int ID_CONTENIDO_INGRESO_PASO { get; set; }
        public bool ACTIVO { get; set; }
        public int ID_FORMULARIO { get; set; }
        public int ID_TIPO_CAMPO { get; set; }
        public string URL_LINK_PAGO { get; set; }
        public string TITULO { get; set; }
        public string SUBTITULO { get; set; }
        public string TEXTO { get; set; }
        public int ID { get; set; }
        public int COL { get; set; }
        public int ROW { get; set; }
        public string NOMBRE_INGRESO_PASO { get; set; }
        public PasoModel()
        {
            ID_PASO = 0;
            NOMBRE = string.Empty;
            ID_INGRESOS_PASO = 0;
            NOMBRE_PASO = string.Empty;
            ID_CONTENIDO_INGRESO_PASO = 0;
            ACTIVO = false;
            ID_FORMULARIO = 0;
            ID_TIPO_CAMPO = 0;
            URL_LINK_PAGO = string.Empty;
            TITULO = string.Empty;
            SUBTITULO = string.Empty;
            TEXTO = string.Empty;
            ID = 0;
            COL = 0;
            ROW = 0;
            NOMBRE_INGRESO_PASO = string.Empty;
        }
    }
}
