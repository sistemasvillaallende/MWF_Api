// Decompiled with JetBrains decompiler
// Type: MOTOR_WORKFLOW.Services.BarriosService
// Assembly: MOTOR_WORKFLOW, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 007B8F5F-49BB-4EE7-8464-22FD2F567A18
// Assembly location: C:\Muni\DEV\WebApiMWF\MOTOR_WORKFLOW.dll

using MOTOR_WORKFLOW.Entities;
using System;
using System.Collections.Generic;

#nullable enable
namespace MOTOR_WORKFLOW.Services
{
    public class BarriosService : IBarriosService
    {
        public Barrios getByPk(int COD_BARRIO)
        {
            try
            {
                return Barrios.getByPk(COD_BARRIO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Combo> read()
        {
            try
            {
                return Barrios.read();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int insert(Barrios obj)
        {
            try
            {
                return Barrios.insert(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void update(Barrios obj)
        {
            try
            {
                Barrios.update(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void delete(Barrios obj)
        {
            try
            {
                Barrios.delete(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
