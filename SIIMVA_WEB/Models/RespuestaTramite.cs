// Decompiled with JetBrains decompiler
// Type: MOTOR_WORKFLOW.Models.RespuestaTramite
// Assembly: MOTOR_WORKFLOW, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 007B8F5F-49BB-4EE7-8464-22FD2F567A18
// Assembly location: C:\Muni\DEV\WebApiMWF\MOTOR_WORKFLOW.dll

using System.Collections.Generic;

#nullable enable
namespace MOTOR_WORKFLOW.Models
{
    public class RespuestaTramite
    {
        public int? idTramite { get; set; }

        public string cuit { get; set; }

        public string cuitRepresentado { get; set; }

        public int? idPaso { get; set; }

        public int? idOficina { get; set; }

        public List<Paso> pasos { get; set; }

        public RespuestaTramite()
        {
            this.idTramite = 0;
            this.idPaso = 0;
            this.idOficina = 0;
            this.cuit = string.Empty;
            this.cuitRepresentado = string.Empty;
            this.pasos = new List<Paso>();
        }
    }
}