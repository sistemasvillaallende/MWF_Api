// Decompiled with JetBrains decompiler
// Type: MOTOR_WORKFLOW.Entities.contenido_ingreso_paso_model
// Assembly: MOTOR_WORKFLOW, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 007B8F5F-49BB-4EE7-8464-22FD2F567A18
// Assembly location: C:\Muni\DEV\WebApiMWF\MOTOR_WORKFLOW.dll

#nullable disable
namespace MOTOR_WORKFLOW.Entities
{
    public class contenido_ingreso_paso_model
    {
        public int id { get; set; }

        public int id_ingreso_paso { get; set; }

        public int orden { get; set; }

        public int row { get; set; }

        public int col { get; set; }

        public bool activo { get; set; }
    }
}