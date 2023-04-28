using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOTOR_WORKFLOW.Entities;
namespace MOTOR_WORKFLOW.Services
{
    public interface ITramitesService
    {
        public int recibir(int id_tramite, int paso_actual,
            int id_tramites);
        public List<Tramites> read(string cuit);
        public List<Tramites> read();
        public List<Tramites> readOficina(int id_oficina, int estado);
        public Tramites getByPk(int id);
        public int insert(Tramites obj);
        public void update(Tramites obj);
        public void delete(Tramites obj);
    }
}

