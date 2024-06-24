namespace MOTOR_WORKFLOW.Models
{
#nullable enable

    public class ObjDDJJs
    {
        public string nombre_campo { get; set; }

        public string respuesta_usuario { get; set; }

        public int id_tipo_campo { get; set; }

        public string etiqueta_campo { get; set; }

        public ObjDDJJs()
        {
            this.nombre_campo = string.Empty;
            this.respuesta_usuario = string.Empty;
            this.id_tipo_campo = 0;
            this.etiqueta_campo = string.Empty;
        }
    }

}
