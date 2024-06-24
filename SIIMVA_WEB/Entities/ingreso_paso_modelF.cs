namespace MOTOR_WORKFLOW.Entities
{
    public class ingreso_paso_modelF
    {
        public int id_ingreso_paso { get; set; }
        public string nombre_paso { get; set; }
        public string nombre_ingreso_paso { get; set; }
        public int orden { get; set; }
        public int row { get; set; }
        public int col { get; set; }
        public ingreso_paso_modelF()
        {
            this.id_ingreso_paso = 0;
            this.nombre_paso = string.Empty;
            this.nombre_ingreso_paso = string.Empty;
            this.orden = 0;
            this.row = 0;
            this.col = 0;
        }
    }
}
