namespace MOTOR_WORKFLOW.Models
{
    public class MesaApiModel
    {
        public string nombre { get; set; }
        public string domicilio { get; set; }
        public string email { get; set; }
        public string Observaciones { get; set; }
        public string celular { get; set; }
        public string cuit { get; set; }

        public MesaApiModel()
        {
            nombre = string.Empty;
            domicilio = string.Empty;
            email = string.Empty;
            celular = string.Empty;
            cuit = string.Empty;
            Observaciones = string.Empty;   
        }
    }
}
