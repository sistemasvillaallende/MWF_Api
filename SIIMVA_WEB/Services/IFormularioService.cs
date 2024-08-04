using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOTOR_WORKFLOW.Entities;
using MOTOR_WORKFLOW.Models;
namespace MOTOR_WORKFLOW.Services
{
    public interface IFormularioService
    {
        public List<Formulario> read();
        public Formulario getByPk(int ID);
        public int insert(FormularioModel obj);
        public void update(FormularioModel obj);
        public void delete(string id);
    }
}

