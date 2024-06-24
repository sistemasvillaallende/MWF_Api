namespace MOTOR_WORKFLOW.Models
{

    public class RespuestaIngresoPaso
    {
        public int id_paso { get; set; }

        public int orden_paso { get; set; }

        public int id_ingreso_paso { get; set; }

        public int id_ddjj { get; set; }

        public int id_adjunto { get; set; }

        public int id_formulario { get; set; }

        public ObjFormulario[] objFormulario { get; set; }

        public ObjFormulario objDDJJs { get; set; }

        public ObjFormulario objAdjuntos { get; set; }

        public RespuestaIngresoPaso(int lenghtForm)
        {
            this.id_paso = 0;
            this.orden_paso = 0;
            this.id_ingreso_paso = 0;
            this.id_ddjj = 0;
            this.id_adjunto = 0;
            this.id_formulario = 0;
            this.objFormulario = new ObjFormulario[lenghtForm];
            this.objDDJJs = new ObjFormulario();
            this.objAdjuntos = new ObjFormulario();
        }
    }


}
