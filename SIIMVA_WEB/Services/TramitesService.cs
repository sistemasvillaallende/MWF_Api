using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Options;
using MOTOR_WORKFLOW.Entities;
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
        public List<Tramites> readOficina(int id_oficina, int estado)
        {
            try
            {
                return Tramites.readOficina(id_oficina, estado);
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

        public int recibir(int id_tramite, int paso_actual,
            int id_tramites)
        {
            try
            {
                return Entities.Tramites.recibir(id_tramite, paso_actual,
                    id_tramites);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

