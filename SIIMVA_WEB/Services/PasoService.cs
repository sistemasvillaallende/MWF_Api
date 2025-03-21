// Decompiled with JetBrains decompiler
// Type: MOTOR_WORKFLOW.Services.PasoService
// Assembly: MOTOR_WORKFLOW, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 007B8F5F-49BB-4EE7-8464-22FD2F567A18
// Assembly location: C:\Muni\DEV\WebApiMWF\MOTOR_WORKFLOW.dll

using MOTOR_WORKFLOW.Entities;
using System;
using System.Collections.Generic;

#nullable enable
namespace MOTOR_WORKFLOW.Services
{
    public class PasoService : IPasoService
    {
        public Paso getByPk(int ID)
        {
            try
            {
                return Paso.getByPk(ID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int getProximoVecino(int id_tramite, int id_tramites)
        {
            try
            {
                return Paso.getProximoVecino(id_tramite, id_tramites);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Models.PasoModel getByTramite(int idTramite)
        {
            try
            {
                return Paso.getByTramite(idTramite);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public MOTOR_WORKFLOW.Entities.Paso getProximo(int id_tramite, int paso_actual)
        {
            try
            {
                return Paso.getProximo(id_tramite, paso_actual);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Paso> readBackEnd(int idTramite)
        {
            try
            {
                return Paso.readBackEnd(idTramite);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Paso> read(int idTramite)
        {
            try
            {
                return Paso.read(idTramite);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int insert(PasoModel obj)
        {
            try
            {
                return Paso.insert(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void update(PasoModel obj)
        {
            try
            {
                Paso.update(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void delete(int idPaso)
        {
            try
            {
                Paso.delete(idPaso);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
