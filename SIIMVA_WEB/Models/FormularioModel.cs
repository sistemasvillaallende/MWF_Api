namespace MOTOR_WORKFLOW.Models
{
    public class FormularioModel
    {
        public int Id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public bool activo { get; set; }
        public int id_contenido_ingreso_paso { get; set; }

        public FormularioModel() 
        {
            Id = 0;
            nombre = string.Empty;  
            descripcion = string.Empty;
            activo = false;
            id_contenido_ingreso_paso = 0;  
        }
    }
}
