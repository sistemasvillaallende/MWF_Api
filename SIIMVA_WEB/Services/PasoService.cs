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
        public List<Paso> read()
        {
            try
            {
                return Paso.read();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int insert(Paso obj)
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
        public void update(Paso obj)
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
        public void delete(Paso obj)
        {
            try
            {
                Paso.delete(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

