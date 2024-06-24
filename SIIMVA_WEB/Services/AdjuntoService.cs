// Decompiled with JetBrains decompiler
// Type: MOTOR_WORKFLOW.Services.AdjuntoService
// Assembly: MOTOR_WORKFLOW, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 007B8F5F-49BB-4EE7-8464-22FD2F567A18
// Assembly location: C:\Muni\DEV\WebApiMWF\MOTOR_WORKFLOW.dll

using MOTOR_WORKFLOW.Entities;
using System;
using System.Collections.Generic;

#nullable enable
namespace MOTOR_WORKFLOW.Services
{
    public class AdjuntoService : IAdjuntoService
    {
        public Adjunto getByPk(int ID)
        {
            try
            {
                return Adjunto.getByPk(ID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Adjunto> read()
        {
            try
            {
                return Adjunto.read();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int insert(AdjuntoModel obj)
        {
            try
            {
                return Adjunto.insert(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void update(AdjuntoModel obj)
        {
            try
            {
                Adjunto.update(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void delete(Adjunto obj)
        {
            try
            {
                Adjunto.delete(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
