using System.Text;

namespace MOTOR_WORKFLOW.Helpers
{
    public class Utils
    {
        public static string armoDenominacion3(int cir, int sec, int man, int par, int p_h)
        {
            try
            {
                StringBuilder denominacion = new StringBuilder();

                if (cir < 10)
                    denominacion.AppendFormat("0{0}-", cir);
                if (cir > 9 && cir < 100)
                    denominacion.AppendFormat("{0}-", cir);

                if (sec < 10)
                    denominacion.AppendFormat("0{0}-", sec);
                if (sec > 9 && sec < 100)
                    denominacion.AppendFormat("{0}-", sec);

                if (man < 10)
                    denominacion.AppendFormat("00{0}-", man);
                if (man > 9 && man < 100)
                    denominacion.AppendFormat("0{0}-", man);
                if (man > 99)
                    denominacion.AppendFormat("{0}-", man);

                if (par < 10)
                    denominacion.AppendFormat("00{0}-", par);
                if (par > 9 && par < 100)
                    denominacion.AppendFormat("0{0}-", par);
                if (par > 99)
                    denominacion.AppendFormat("{0}-", par);
                if (p_h < 10)
                    denominacion.AppendFormat("00{0}", p_h);
                if (p_h > 9 && p_h < 100)
                    denominacion.AppendFormat("0{0}", p_h);
                if (p_h > 99)
                    denominacion.AppendFormat("{0}", p_h);
                return denominacion.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static string GeneroPeriodoCatastro(string estado, int auxNroTransaccion)
        {
            try
            {
                string periodo = string.Empty;

                string leftString = estado.Substring(0, 3);
                string floatToStr = (auxNroTransaccion / 3333).ToString();

                // Obtener los últimos 4 caracteres
                string rightString = floatToStr.Length > 4
                    ? floatToStr.Substring(floatToStr.Length - 4)
                    : floatToStr;

                // Concatenar las partes
                periodo = leftString + rightString;

                return periodo;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
