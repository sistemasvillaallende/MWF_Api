using EndPointIntegracion.Entities;
using EndPointIntegracion.Models;

namespace EndPointIntegracion.Services
{
    public interface IRubrosService
    {
        public List<Combo> read();
        public List<Combo> readBajoRiesgo();
        public Rubros getByPk(int cod_rubro, int anio);
        public int insert(Rubros obj);
        public void update(Rubros obj);
        public void delete(Rubros obj);
        public List<Combo> getByComercio(int leg);
    }
}
