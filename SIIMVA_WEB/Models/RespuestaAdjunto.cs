namespace MOTOR_WORKFLOW.Models
{

    public class RespuestaAdjunto
    {
        public string nombre_campo { get; set; }

        public IFormFileCollection Archivos { get; set; }

        public int id_tipo_campo { get; set; }

        public string etiqueta_campo { get; set; }

        public RespuestaAdjunto()
        {
            this.nombre_campo = string.Empty;
            this.Archivos = (IFormFileCollection)new FormFileCollection();
            this.id_tipo_campo = 0;
            this.etiqueta_campo = string.Empty;
        }
    }

}
