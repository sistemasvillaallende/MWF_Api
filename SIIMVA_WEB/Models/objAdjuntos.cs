namespace MOTOR_WORKFLOW.Models
{

    public class objAdjuntos
    {
        public string nombre_campo { get; set; }

        public string respuesta_usuario { get; set; }

        public int id_tipo_campo { get; set; }

        public string etiqueta_campo { get; set; }
        public string extenciones_aceptadas { get; set; }
        public objAdjuntos()
        {
            this.nombre_campo = string.Empty;
            this.respuesta_usuario = string.Empty;
            this.id_tipo_campo = 0;
            this.etiqueta_campo = string.Empty;
            extenciones_aceptadas = string.Empty;
        }
    }

}
