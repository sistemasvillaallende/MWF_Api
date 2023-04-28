using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOTOR_WORKFLOW.Entities;
namespace MOTOR_WORKFLOW.Services
{
    public interface IPasoService
    {
        public List<Paso> read();
        public Paso getByPk(int ID);
        public int insert(Paso obj);
        public void update(Paso obj);
        public void delete(Paso obj);
    }
}

