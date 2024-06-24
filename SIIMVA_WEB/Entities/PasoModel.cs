// Decompiled with JetBrains decompiler
// Type: MOTOR_WORKFLOW.Entities.PasoModel
// Assembly: MOTOR_WORKFLOW, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 007B8F5F-49BB-4EE7-8464-22FD2F567A18
// Assembly location: C:\Muni\DEV\WebApiMWF\MOTOR_WORKFLOW.dll

#nullable enable
namespace MOTOR_WORKFLOW.Entities
{
    public class PasoModel
    {
        public bool activo { get; set; }

        public bool en_usuario { get; set; }

        public bool es_final { get; set; }

        public int id { get; set; }

        public int id_oficina { get; set; }

        public int id_tramite { get; set; }

        public string nombre { get; set; }

        public int orden { get; set; }

        public int proxima_oficina { get; set; }

        public PasoModel()
        {
            this.activo = false;
            this.en_usuario = false;
            this.es_final = false;
            this.id = 0;
            this.id_oficina = 0;
            this.id_tramite = 0;
            this.nombre = string.Empty;
            this.orden = 0;
            this.proxima_oficina = 0;
        }
    }
}
