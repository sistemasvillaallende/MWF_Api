// Decompiled with JetBrains decompiler
// Type: MOTOR_WORKFLOW.Services.IPasoService
// Assembly: MOTOR_WORKFLOW, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 007B8F5F-49BB-4EE7-8464-22FD2F567A18
// Assembly location: C:\Muni\DEV\WebApiMWF\MOTOR_WORKFLOW.dll

using MOTOR_WORKFLOW.Entities;
using System.Collections.Generic;

#nullable enable
namespace MOTOR_WORKFLOW.Services
{
    public interface IPasoService
    {
        List<Paso> read(int idTramite);
        public int getProximoVecino(int id_tramite, int id_tramites);
        public MOTOR_WORKFLOW.Entities.Paso getProximo(int id_tramite, int paso_actual);
        List<Paso> readBackEnd(int idTramite);

        Paso getByPk(int ID);

        int insert(PasoModel obj);

        void update(PasoModel obj);

        void delete(int idPaso);
        public Models.PasoModel getByTramite(int idTramite);
    }
}