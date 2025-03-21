// Decompiled with JetBrains decompiler
// Type: MOTOR_WORKFLOW.Services.ITramitesService
// Assembly: MOTOR_WORKFLOW, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 007B8F5F-49BB-4EE7-8464-22FD2F567A18
// Assembly location: C:\Muni\DEV\WebApiMWF\MOTOR_WORKFLOW.dll

using MOTOR_WORKFLOW.Entities;
using System.Collections.Generic;

#nullable enable
namespace MOTOR_WORKFLOW.Services
{
    public interface ITramitesService
    {
        void finalizar_rechazar(int id_tramites, int estado);

        int recibir(int id_tramite, int paso_actual, int id_tramites, int cod_usuario);
        int valida(int id_tramite);

        List<Tramites> read(string cuit);

        List<Tramites> read();

        List<Tramites> readOficina(int id_oficina);

        Tramites getByPk(int id);

        Tramites getByPkSimple(int id);

        List<ResultadoTramites> getResultados(int id);

        int insert(Tramites obj);

        void update(Tramites obj);

        void delete(Tramites obj);
        public void asignar_legajo(int id_tramites, int legajo);
    }
}
