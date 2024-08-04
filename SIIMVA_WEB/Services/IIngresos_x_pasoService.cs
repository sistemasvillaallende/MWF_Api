// Decompiled with JetBrains decompiler
// Type: MOTOR_WORKFLOW.Services.IIngresos_x_pasoService
// Assembly: MOTOR_WORKFLOW, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 007B8F5F-49BB-4EE7-8464-22FD2F567A18
// Assembly location: C:\Muni\DEV\WebApiMWF\MOTOR_WORKFLOW.dll

using MOTOR_WORKFLOW.Entities;
using System.Collections.Generic;

#nullable enable
namespace MOTOR_WORKFLOW.Services
{
    public interface IIngresos_x_pasoService
    {
        List<ingresos_x_paso> read(int idPaso);

        ingresos_x_paso getByPk(int ID);

        int insert(ingreso_paso_model obj);

        void update(ingreso_paso_model obj);
        int insertValidaForm(ingreso_paso_model obj);

        void delete(string id);
    }
}

