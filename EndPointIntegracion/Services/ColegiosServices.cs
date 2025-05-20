using EndPointIntegracion.Models;

namespace EndPointIntegracion.Services
{
    public class ColegiosServices : IColegiosServices
    {
        public List<Combo> read()
        {
            List<Combo> lst = new List<Combo>();
            Combo obj = new Combo();
            obj.value = 1.ToString();
            obj.text = "Colegio de Arquitectos";
            lst.Add(obj);
            obj.value = 1.ToString();
            obj.text = "Colegio de Ingenieros";
            lst.Add(obj);
            return lst;
        }
    }
}
