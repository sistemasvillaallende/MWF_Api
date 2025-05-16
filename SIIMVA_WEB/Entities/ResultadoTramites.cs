// Decompiled with JetBrains decompiler
// Type: MOTOR_WORKFLOW.Entities.ResultadoTramites
// Assembly: MOTOR_WORKFLOW, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 007B8F5F-49BB-4EE7-8464-22FD2F567A18
// Assembly location: C:\Muni\DEV\WebApiMWF\MOTOR_WORKFLOW.dll

#nullable enable
namespace MOTOR_WORKFLOW.Entities
{
    public class ResultadoTramites
    {
        public int id_paso { get; set; }

        public int id_ingreso_paso { get; set; }

        public int orden_ingreso_paso { get; set; }

        public int row { get; set; }

        public int col { get; set; }

        public string nombre_paso { get; set; }

        public string nombre_ingreso_paso { get; set; }

        public string contenido { get; set; }

        public string tipo { get; set; }

        public string extenciones { get; set; }

        public string cuit { get; set; }

        public string cuit_representado { get; set; }

        public string nombre_contribuyente { get; set; }

        public string nombre_representado { get; set; }

        public string nombre_tramite { get; set; }

        public string nombre_unidad_organizativa { get; set; }

        public int id_tramite { get; set; }

        public int estado { get; set; }

        public string nombre_estado { get; set; }

        public int paso_actual { get; set; }

        public int paso_anterior { get; set; }

        public bool en_vecino { get; set; }

        public bool es_final { get; set; }
        public int orden { get; set; }
        public int proxima_oficina { get; set; }
        public int proximo_paso_ne_vecino { get; set; }
        public string nombre_oficina { get; set; }
        public ResultadoTramites()
        {
            this.id_paso = 0;
            this.id_ingreso_paso = 0;
            this.orden_ingreso_paso = 0;
            this.row = 0;
            this.col = 0;
            this.nombre_paso = string.Empty;
            this.contenido = string.Empty;
            this.nombre_ingreso_paso = string.Empty;
            this.tipo = string.Empty;
            this.extenciones = string.Empty;
            this.cuit = string.Empty;
            this.cuit_representado = string.Empty;
            this.nombre_contribuyente = string.Empty;
            this.nombre_representado = string.Empty;
            this.nombre_tramite = string.Empty;
            this.nombre_unidad_organizativa = string.Empty;
            this.id_tramite = 0;
            this.estado = 0;
            this.nombre_estado = string.Empty;
            this.paso_actual = 0;
            this.paso_anterior = 0;
            this.en_vecino = false;
            this.es_final = false;
            orden = 0;
            proxima_oficina = 0;
            nombre_oficina = string.Empty;
        }
    }
}

