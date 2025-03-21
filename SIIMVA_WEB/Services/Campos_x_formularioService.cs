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
    public class Campos_x_formularioService : ICampos_x_formularioService
    {
        public campos_x_formulario getByPk(int ID)
        {
            try
            {
                return campos_x_formulario.getByPk(ID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<campos_x_formulario> read(int idFormulario)
        {
            try
            {
                return campos_x_formulario.read(idFormulario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int insert(CampoTextoModel obj)
        {
            try
            {
                return Entities.campos_x_formulario.insert(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void update(CampoTextoModel obj)
        {
            try
            {
                Entities.campos_x_formulario.update(obj);
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
                campos_x_formulario.delete(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void insertEnlazados(List<CampoTextoModel> lst)
        {
            try
            {
                Entities.campos_x_formulario.insertenlazados(lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void updateEnlazados(List<CampoTextoModel> lst)
        {
            try
            {
                Entities.campos_x_formulario.updateenlazados(lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

