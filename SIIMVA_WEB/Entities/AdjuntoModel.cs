namespace MOTOR_WORKFLOW.Entities
{
    public class AdjuntoModel
    {
        public int id { get; set; }

        public string nombre { get; set; }

        public string descripcion { get; set; }

        public string etiqueta { get; set; }

        public bool requerido { get; set; }

        public bool activo { get; set; }

        public int id_contenido_ingreso_paso { get; set; }

        public string extenciones_aceptadas { get; set; }

        public bool multiple { get; set; }

        public AdjuntoModel()
        {
            this.id = 0;
            this.nombre = string.Empty;
            this.descripcion = string.Empty;
            this.etiqueta = string.Empty;
            this.requerido = false;
            this.activo = false;
            this.id_contenido_ingreso_paso = 0;
            this.extenciones_aceptadas = string.Empty;
            this.multiple = false;
        }
    }
}

