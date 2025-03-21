namespace MOTOR_WORKFLOW.Models
{
    public class TramiteInsert
    {
        public int id { get; set; }

        public string nombre { get; set; }

        public string descripcion { get; set; }

        public DateTime fecha_crea { get; set; }

        public string usu_crea { get; set; }

        public int id_unidad_organizativa { get; set; }

        public string logo_unidad_administrativa { get; set; }
        public string nombre_unidad_organizativa { get;set; }
        public bool activo { get; set; }
        public int nro_expediente { get; set; }
        public int anio { get; set; }

    }
}
