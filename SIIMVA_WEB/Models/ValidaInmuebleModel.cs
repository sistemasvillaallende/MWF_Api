namespace MOTOR_WORKFLOW.Models
{
    public class ValidaInmuebleModel
    {
        public int CIR { get; set; }
        public int SEC { get; set; }
        public int MAN { get; set; }
        public int PAR { get; set; }
        public int P_H { get; set; }
        public string CALLE { get; set; }
        public int NRO { get; set; }
        public string BARRIO { get; set; }
        public string ZONA { get; set; }

        public ValidaInmuebleModel()
        {
            CIR = 0;
            SEC = 0;
            MAN = 0;
            PAR = 0;
            P_H = 0;
            CALLE = string.Empty;
            NRO = 0;
            BARRIO = string.Empty;
            ZONA = string.Empty;
        }
    }
}
