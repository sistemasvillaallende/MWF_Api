// Decompiled with JetBrains decompiler
// Type: MOTOR_WORKFLOW.Services.OficinasService
// Assembly: MOTOR_WORKFLOW, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 007B8F5F-49BB-4EE7-8464-22FD2F567A18
// Assembly location: C:\Muni\DEV\WebApiMWF\MOTOR_WORKFLOW.dll

using MOTOR_WORKFLOW.Entities;
using System;
using System.Collections.Generic;

#nullable enable
namespace MOTOR_WORKFLOW.Services
{
    public class OficinasService : IOficinasService
    {
        public Oficinas getByPk(int codigo_oficina)
        {
            try
            {
                return Oficinas.getByPk(codigo_oficina);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Oficinas> read()
        {
            try
            {
                return Oficinas.read();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int insert(Oficinas obj)
        {
            try
            {
                return Oficinas.insert(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void update(Oficinas obj)
        {
            try
            {
                Oficinas.update(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void delete(Oficinas obj)
        {
            try
            {
                Oficinas.delete(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
