using EndPointIntegracion.Models;

namespace EndPointIntegracion.Services
{
    public class TipoEntidadServide: ITipoEntidadService
    {
        public List<Combo> Tipos_entidad()
        {
            try
            {
                return Entities.Tipos_entidad.read();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
