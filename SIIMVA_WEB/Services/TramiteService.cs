// Decompiled with JetBrains decompiler
// Type: MOTOR_WORKFLOW.Services.TramiteService
// Assembly: MOTOR_WORKFLOW, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 007B8F5F-49BB-4EE7-8464-22FD2F567A18
// Assembly location: C:\Muni\DEV\WebApiMWF\MOTOR_WORKFLOW.dll

using MOTOR_WORKFLOW.Entities;
using System;
using System.Collections.Generic;

#nullable enable
namespace MOTOR_WORKFLOW.Services
{
    public class TramiteService : ITramiteService
    {
        public Tramite getByPk(int ID)
        {
            try
            {
                return Tramite.getByPk(ID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Tramite> read()
        {
            try
            {
                return Tramite.read();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Tramite> readBack()
        {
            try
            {
                return Tramite.readBack();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int insert(Tramite obj)
        {
            try
            {
                return Tramite.insert(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void update(Tramite obj)
        {
            try
            {
                Tramite.update(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void activaDesactiva(Tramite obj)
        {
            try
            {
                Tramite.activaDesactiva(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void delete(Tramite obj)
        {
            try
            {
                Tramite.delete(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
