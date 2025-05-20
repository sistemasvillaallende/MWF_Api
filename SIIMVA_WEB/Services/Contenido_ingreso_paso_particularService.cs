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
    public class Contenido_ingreso_paso_particularService : IContenido_ingreso_paso_particularService
    {
        public Contenido_ingreso_paso_particular getByPk(int ID)
        {
            try
            {
                return Contenido_ingreso_paso_particular.getByPk(ID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Contenido_ingreso_paso_particular getByTramitesPaso(int ID_TRAMITES, int ID_INGRESO_PASO)
        {
            try
            {
                return Contenido_ingreso_paso_particular.getByTramitesPaso(ID_TRAMITES, ID_INGRESO_PASO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Contenido_ingreso_paso_particular> read()
        {
            try
            {
                return Contenido_ingreso_paso_particular.read();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int insert(Contenido_ingreso_paso_particular obj)
        {
            try
            {
                return Contenido_ingreso_paso_particular.insert(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void update(Contenido_ingreso_paso_particular obj)
        {
            try
            {
                Contenido_ingreso_paso_particular.update(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void delete(Contenido_ingreso_paso_particular obj)
        {
            try
            {
                Contenido_ingreso_paso_particular.delete(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

