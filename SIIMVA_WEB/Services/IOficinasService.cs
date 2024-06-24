// Decompiled with JetBrains decompiler
// Type: MOTOR_WORKFLOW.Services.IOficinasService
// Assembly: MOTOR_WORKFLOW, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 007B8F5F-49BB-4EE7-8464-22FD2F567A18
// Assembly location: C:\Muni\DEV\WebApiMWF\MOTOR_WORKFLOW.dll

using MOTOR_WORKFLOW.Entities;
using System.Collections.Generic;

#nullable enable
namespace MOTOR_WORKFLOW.Services
{
    public interface IOficinasService
    {
        List<Oficinas> read();

        Oficinas getByPk(int codigo_oficina);

        int insert(Oficinas obj);

        void update(Oficinas obj);

        void delete(Oficinas obj);
    }
}