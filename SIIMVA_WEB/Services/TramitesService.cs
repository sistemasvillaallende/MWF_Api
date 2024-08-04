// Decompiled with JetBrains decompiler
// Type: MOTOR_WORKFLOW.Services.TramitesService
// Assembly: MOTOR_WORKFLOW, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 007B8F5F-49BB-4EE7-8464-22FD2F567A18
// Assembly location: C:\Muni\DEV\WebApiMWF\MOTOR_WORKFLOW.dll

using MOTOR_WORKFLOW.Entities;
using System;
using System.Collections.Generic;

#nullable enable
namespace MOTOR_WORKFLOW.Services
{
    public class TramitesService : ITramitesService
    {
        public Tramites getByPk(int id)
        {
            try
            {
                return Tramites.getByPk(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int valida(int idTramite)
        {
            try
            {
                return Tramites.valida(idTramite);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Tramites getByPkSimple(int id)
        {
            try
            {
                return Tramites.getByPkSimple(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ResultadoTramites> getResultados(int id)
        {
            try
            {
                return Tramites.getResultados(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Tramites> read(string cuit)
        {
            try
            {
                return Tramites.read(cuit);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Tramites> read()
        {
            try
            {
                return Tramites.read();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Tramites> readOficina(int id_oficina)
        {
            try
            {
                return Tramites.readOficina(id_oficina);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int insert(Tramites obj)
        {
            try
            {
                return Tramites.insert(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void update(Tramites obj)
        {
            try
            {
                Tramites.update(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void delete(Tramites obj)
        {
            try
            {
                Tramites.delete(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int recibir(int id_tramite, int paso_actual, int id_tramites, int cod_usuario)
        {
            try
            {
                return Tramites.recibir(id_tramite, paso_actual, id_tramites, cod_usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void finalizar_rechazar(int id_tramites, int estado)
        {
            try
            {
                Tramites.finalizar_rechazar(id_tramites, estado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
