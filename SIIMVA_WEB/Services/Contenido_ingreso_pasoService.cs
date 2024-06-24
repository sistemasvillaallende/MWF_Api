// Decompiled with JetBrains decompiler
// Type: MOTOR_WORKFLOW.Services.Contenido_ingreso_pasoService
// Assembly: MOTOR_WORKFLOW, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 007B8F5F-49BB-4EE7-8464-22FD2F567A18
// Assembly location: C:\Muni\DEV\WebApiMWF\MOTOR_WORKFLOW.dll

using MOTOR_WORKFLOW.Entities;
using System;
using System.Collections.Generic;
using System.Transactions;

#nullable enable
namespace MOTOR_WORKFLOW.Services
{
    public class Contenido_ingreso_pasoService : IContenido_ingreso_pasoService
    {
        public contenido_ingreso_paso getByPk(int ID)
        {
            try
            {
                return contenido_ingreso_paso.getByPk(ID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int maxRow(int id_ingreso_paso)
        {
            try
            {
                return contenido_ingreso_paso.maxRow(id_ingreso_paso);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<contenido_ingreso_paso> read(int idIngresoPaso)
        {
            try
            {
                return contenido_ingreso_paso.read(idIngresoPaso);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int insert(contenido_ingreso_paso_model obj)
        {
            try
            {
                return contenido_ingreso_paso.insert(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void update(contenido_ingreso_paso obj)
        {
            try
            {
                contenido_ingreso_paso.update(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void delete(int id)
        {
            try
            {
                using (TransactionScope transactionScope = new TransactionScope())
                {
                    Formulario.delete(id);
                    ddjj.delete(id);
                    Adjunto.delete(id);
                    contenido_ingreso_paso.delete(id);
                    transactionScope.Complete();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
