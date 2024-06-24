// Decompiled with JetBrains decompiler
// Type: MOTOR_WORKFLOW.Entities.ingreso_paso_model
// Assembly: MOTOR_WORKFLOW, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 007B8F5F-49BB-4EE7-8464-22FD2F567A18
// Assembly location: C:\Muni\DEV\WebApiMWF\MOTOR_WORKFLOW.dll

#nullable enable
namespace MOTOR_WORKFLOW.Entities
{
    public class ingreso_paso_model
    {
        public int id { get; set; }

        public int id_paso { get; set; }

        public string titulo { get; set; }

        public int orden { get; set; }

        public bool activo { get; set; }

        public ingreso_paso_model()
        {
            this.id = 0;
            this.id_paso = 0;
            this.titulo = string.Empty;
            this.orden = 0;
            this.activo = false;
        }
    }
}
