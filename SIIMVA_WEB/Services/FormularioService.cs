using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Options;
using MOTOR_WORKFLOW.Entities;
using MOTOR_WORKFLOW.Models;

namespace MOTOR_WORKFLOW.Services
{
    public class FormularioService : IFormularioService
    {
        public Formulario getByPk(int ID)
        {
            try
            {
                return Formulario.getByPk(ID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Formulario> read()
        {
            try
            {
                return Formulario.read();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int insert(FormularioModel obj)
        {
            try
            {
                return Formulario.insert(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void update(FormularioModel obj)
        {
            try
            {
                Formulario.update(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void delete(string id)
        {
            try
            {
                Formulario.delete(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

