namespace MOTOR_WORKFLOW.Models
{

    public class Paso
    {
        public int? id_paso { get; set; }

        public int orden_paso { get; set; }

        public int? orden_paso_IP { get; set; }

        public int? id_ingreso_paso { get; set; }

        public string nombre { get; set; }

        public string nombreObjeto { get; set; }

        public List<ObjFormulario> objFormulario { get; set; }

        public ObjDDJJs objDDJJs { get; set; }

        public List<objAdjuntos> objAdjuntos { get; set; }

        public int id_ddjj { get; set; }

        public int id_adjunto { get; set; }

        public int? id_formulario { get; set; }

        public int? row { get; set; }

        public int? col { get; set; }

        public Paso()
        {
            this.id_paso = 0;
            this.orden_paso = 0;
            this.id_ingreso_paso = 0;
            this.objFormulario = new List<ObjFormulario>();
            this.objDDJJs = new ObjDDJJs();
            this.objAdjuntos = new List<objAdjuntos>();
            this.id_ddjj = 0;
            this.id_adjunto = 0;
            this.id_formulario = 0;
            this.row = 0;
            this.col = 0;
            this.nombre = string.Empty;
            this.nombreObjeto = string.Empty;
            this.orden_paso_IP = 0;
        }
    }


}
