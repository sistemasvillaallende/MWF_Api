// Decompiled with JetBrains decompiler
// Type: MOTOR_WORKFLOW.Services.IContenido_ingreso_pasoService
// Assembly: MOTOR_WORKFLOW, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 007B8F5F-49BB-4EE7-8464-22FD2F567A18
// Assembly location: C:\Muni\DEV\WebApiMWF\MOTOR_WORKFLOW.dll

using MOTOR_WORKFLOW.Entities;
using System.Collections.Generic;

#nullable enable
namespace MOTOR_WORKFLOW.Services
{
    public interface IContenido_ingreso_pasoService
    {
        List<contenido_ingreso_paso> read(int idIngresoPaso);

        int maxRow(int id_ingreso_paso);

        contenido_ingreso_paso getByPk(int ID);

        int insert(contenido_ingreso_paso_model obj);

        void update(contenido_ingreso_paso obj);

        void delete(int id);
    }
}

