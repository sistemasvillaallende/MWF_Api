using EndPointIntegracion.Models;

namespace EndPointIntegracion.Services
{
    public class ColegiosServices : IColegiosServices
    {
        public List<Colegios> read()
        {
            List<Colegios> lst = new List<Colegios>();
            lst.Add(new(1, "Colegio de Arquitectos"));
            lst.Add(new(2, "Colegio de Ingenieros"));
            return lst;
        }
    }
}
