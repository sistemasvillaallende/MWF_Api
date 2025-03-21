using EndPointIntegracion.Entities;
using EndPointIntegracion.Models;

namespace EndPointIntegracion.Services
{
    public class RubrosService : IRubrosService
    {
        public List<Combo> getByComercio(int leg)
        {
            try
            {
                return Rubros.getByComercio(leg);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Rubros getByPk(int cod_rubro, int anio)
        {
            try
            {
                return Rubros.getByPk(cod_rubro, anio);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Combo> read()
        {
            try
            {
                return Entities.Rubros.read();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int insert(Rubros obj)
        {
            try
            {
                return Rubros.insert(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void update(Rubros obj)
        {
            try
            {
                Rubros.update(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void delete(Rubros obj)
        {
            try
            {
                Rubros.delete(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Combo> readBajoRiesgo()
        {
            try
            {
                return Rubros.readBajoRiesgo();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}


