namespace MOTOR_WORKFLOW.Entities
{
    public class CampoTextoModel
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

        public string formato_resultado { get; set; }

        public int row { get; set; }

        public int col { get; set; }
        public string cod_enlaza { get; set; }
        public CampoTextoModel()
        {
            this.id = 0;
            this.id_formulario = 0;
            this.id_tipo_campo = 0;
            this.nombre = string.Empty;
            this.etiqueta = string.Empty;
            this.place_holder = string.Empty;
            this.orden = 0;
            this.activo = true;
            this.requerido = false;
            this.id_ws = 0;
            this.value = string.Empty;
            this.text = string.Empty;
            this.formato_resultado = string.Empty;
            this.row = 0;
            this.col = 0;
            cod_enlaza = string.Empty;
        }
    }
}
