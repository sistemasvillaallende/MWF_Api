namespace MOTOR_WORKFLOW.Entities
{
    public class Ws_Url_Model
    {
        public CampoTextoModel CampoTextModel { get; set; }
        List<Ws_parametros_x_campo_formulario> _formularioList { get; set; }
        public Ws_Url_Model()
        {
            CampoTextModel = new CampoTextoModel();
            _formularioList = new List<Ws_parametros_x_campo_formulario>();
        }
    }
}
