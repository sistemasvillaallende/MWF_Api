namespace MOTOR_WORKFLOW.Controllers
{
    public class link_pago
    {
        public string url { get; set; }
        public string titulo { get; set; }
        public string subtitulo { get; set; }
        public string texto { get; set; }
        public int nro_tran { get; set; }
        public int subsistema { get; set; }

        public link_pago()
        {
            url = string.Empty;
            titulo = string.Empty;
            subtitulo = string.Empty;
            texto = string.Empty;   
            nro_tran = 0;
            subsistema = 0;
        }
    }
}
