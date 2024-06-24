namespace MOTOR_WORKFLOW.Models
{
    public class ContenidoAdjunto
    {
        public int idAdjuntos { get; set; }

        public string nombreAdjunto { get; set; }

        public ContenidoAdjunto(int id, string nombre)
        {
            this.idAdjuntos = id;
            this.nombreAdjunto = nombre;
        }
    }
}