// Decompiled with JetBrains decompiler
// Type: MOTOR_WORKFLOW.Entities.RespuestaIngresoPaso
// Assembly: MOTOR_WORKFLOW, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 007B8F5F-49BB-4EE7-8464-22FD2F567A18
// Assembly location: C:\Muni\DEV\WebApiMWF\MOTOR_WORKFLOW.dll

#nullable enable
namespace MOTOR_WORKFLOW.Entities
{
    public class RespuestaIngresoPaso
    {
        public int id_tramites { get; set; }

        public int id_paso { get; set; }

        public int orden_paso { get; set; }

        public int id_ingreso_paso { get; set; }

        public int orden_ingreso_paso { get; set; }

        public string nombre_ingreso_paso { get; set; }

        public int row { get; set; }

        public int col { get; set; }

        public int id_formulario { get; set; }

        public int id_adjunto { get; set; }

        public int id_ddjj { get; set; }

        public Formularios objFormulario { get; set; }

        public Adjuntos objAdjunto { get; set; }

        public Ddjjs objDDJJ { get; set; }

        public RespuestaIngresoPaso()
        {
            this.id_tramites = 0;
            this.id_paso = 0;
            this.orden_paso = 0;
            this.id_ingreso_paso = 0;
            this.orden_ingreso_paso = 0;
            this.nombre_ingreso_paso = string.Empty;
            this.row = 0;
            this.col = 0;
            this.id_formulario = 0;
            this.id_adjunto = 0;
            this.id_ddjj = 0;
            this.objAdjunto = new Adjuntos();
            this.objDDJJ = new Ddjjs();
            this.objFormulario = new Formularios();
        }
    }
}
