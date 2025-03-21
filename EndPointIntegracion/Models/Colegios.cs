namespace EndPointIntegracion.Models
{
    public class Colegios
    {
        public int cod { get; set; }
        public string valor { get; set; }

        public Colegios(int _cod, string _valor)
        {
            cod = _cod;
            valor = _valor;
        }
        public Colegios()
        {
            cod = 0;
            valor = string.Empty;
        }
    }
}
