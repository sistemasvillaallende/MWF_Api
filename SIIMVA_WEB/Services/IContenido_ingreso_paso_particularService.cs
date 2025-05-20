using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOTOR_WORKFLOW.Entities;

namespace MOTOR_WORKFLOW.Services
{
    public interface IContenido_ingreso_paso_particularService
    {
        public List<Contenido_ingreso_paso_particular> read();
        public Contenido_ingreso_paso_particular getByPk(int ID);
        public Contenido_ingreso_paso_particular getByTramitesPaso(int ID_TRAMITES, int ID_INGRESO_PASO);
        public int insert(Contenido_ingreso_paso_particular obj);
        public void update(Contenido_ingreso_paso_particular obj);
        public void delete(Contenido_ingreso_paso_particular obj);
    }
}

