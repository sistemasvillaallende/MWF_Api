// Decompiled with JetBrains decompiler
// Type: MOTOR_WORKFLOW.Entities.Combo
// Assembly: MOTOR_WORKFLOW, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 007B8F5F-49BB-4EE7-8464-22FD2F567A18
// Assembly location: C:\Muni\DEV\WebApiMWF\MOTOR_WORKFLOW.dll

#nullable enable
namespace MOTOR_WORKFLOW.Entities
{
    public class Combo
    {
        public string value { get; set; }

        public string text { get; set; }

        public string cod_enlaza { get; set; }

        public Combo()
        {
            this.value = string.Empty;
            this.text = string.Empty;
            this.cod_enlaza = string.Empty;
        }
    }
}