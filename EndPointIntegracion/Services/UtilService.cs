namespace EndPointIntegracion.Services
{
    public class UtilService:IUtilService
    {
        public List<Models.Combo> getComboSiNo()
        {
            Models.Combo siNo = new Models.Combo();
            List<Models.Combo> lst = new List<Models.Combo>();
            siNo.text = "Si";
            siNo.value = "01";
            lst.Add(siNo);
            siNo = new Models.Combo();
            siNo.text = "No";
            siNo.value = "0";
            lst.Add(siNo);
            return lst;
        }
    }
}
