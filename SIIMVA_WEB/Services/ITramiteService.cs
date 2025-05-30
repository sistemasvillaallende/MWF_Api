// Decompiled with JetBrains decompiler
// Type: MOTOR_WORKFLOW.Services.ITramiteService
// Assembly: MOTOR_WORKFLOW, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 007B8F5F-49BB-4EE7-8464-22FD2F567A18
// Assembly location: C:\Muni\DEV\WebApiMWF\MOTOR_WORKFLOW.dll

using MOTOR_WORKFLOW.Entities;
using System.Collections.Generic;

#nullable enable
namespace MOTOR_WORKFLOW.Services
{
    public interface ITramiteService
    {
        void activaDesactiva(Models.TramiteActivar obj);

        List<Tramite> read();

        List<Tramite> readBack();

        Tramite getByPk(int ID);

        int insert(Models.TramiteInsert obj);
        void duplicar(Models.TramiteDuplicar obj);
        void update(Models.TramiteInsert obj);
        string getImgOficina(int ID);
        void delete(int id_tramite);

        string VerificaConsistencia(int idTramite);
    }
}
