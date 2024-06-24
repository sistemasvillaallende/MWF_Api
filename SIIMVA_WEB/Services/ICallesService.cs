// Decompiled with JetBrains decompiler
// Type: MOTOR_WORKFLOW.Services.ICallesService
// Assembly: MOTOR_WORKFLOW, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 007B8F5F-49BB-4EE7-8464-22FD2F567A18
// Assembly location: C:\Muni\DEV\WebApiMWF\MOTOR_WORKFLOW.dll

using MOTOR_WORKFLOW.Entities;
using System.Collections.Generic;

#nullable enable
namespace MOTOR_WORKFLOW.Services
{
    public interface ICallesService
    {
        List<Combo> read();

        List<Calles> read(int COD_BARRIO);

        Calles getByPk(int COD_CALLE);
    }
}
