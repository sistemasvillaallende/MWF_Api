// Decompiled with JetBrains decompiler
// Type: MOTOR_WORKFLOW.Services.CallesService
// Assembly: MOTOR_WORKFLOW, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 007B8F5F-49BB-4EE7-8464-22FD2F567A18
// Assembly location: C:\Muni\DEV\WebApiMWF\MOTOR_WORKFLOW.dll

using MOTOR_WORKFLOW.Entities;
using System;
using System.Collections.Generic;

#nullable enable
namespace MOTOR_WORKFLOW.Services
{
    public class CallesService : ICallesService
    {
        public Calles getByPk(int COD_CALLE)
        {
            try
            {
                return Calles.getByPk(COD_CALLE);
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
                return Calles.read();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Calles> read(int COD_BARRIO)
        {
            try
            {
                return Calles.read(COD_BARRIO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
