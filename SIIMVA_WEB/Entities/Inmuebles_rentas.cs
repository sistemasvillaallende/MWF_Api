using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace MOTOR_WORKFLOW.Entities
{
    public class Inmuebles_rentas
    {
        public double nro_cta_rentas { get; set; }
        public int circunscripcion { get; set; }
        public int seccion { get; set; }
        public int manzana { get; set; }
        public int parcela { get; set; }
        public int p_h { get; set; }
        public string calle { get; set; }
        public int nro { get; set; }
        public string barrio { get; set; }
        public string zona { get; set; }
        public string dc { get; set; }

        public Inmuebles_rentas()
        {
            nro_cta_rentas = 0;
            circunscripcion = 0;
            seccion = 0;
            manzana = 0;
            parcela = 0;
            p_h = 0;
            calle = string.Empty;
            nro = 0;
            barrio = string.Empty;
            zona = string.Empty;
            dc = string.Empty;
        }
        private static List<Inmuebles_rentas> mapeo(SqlDataReader dr)
        {
            List<Inmuebles_rentas> inmuebleList = new List<Inmuebles_rentas>();
            if (dr.HasRows)
            {
                int nro_cta_rentas = dr.GetOrdinal("nro_cta_rentas");
                int circunscripcion = dr.GetOrdinal("circunscripcion");
                int seccion = dr.GetOrdinal("seccion");
                int manzana = dr.GetOrdinal("manzana");
                int parcela = dr.GetOrdinal("parcela");
                int p_h = dr.GetOrdinal("p_h");
                int calle = dr.GetOrdinal("calle");
                int nro = dr.GetOrdinal("nro");
                int barrio = dr.GetOrdinal("barrio");
                int zona = dr.GetOrdinal("zona");


                while (dr.Read())
                {
                    Inmuebles_rentas inmueble = new Inmuebles_rentas();
                    if (!dr.IsDBNull(nro_cta_rentas))
                        inmueble.nro_cta_rentas = dr.GetDouble(nro_cta_rentas);
                    if (!dr.IsDBNull(circunscripcion))
                        inmueble.circunscripcion = dr.GetInt32(circunscripcion);
                    if (!dr.IsDBNull(seccion))
                        inmueble.seccion = dr.GetInt32(seccion);
                    if (!dr.IsDBNull(manzana))
                        inmueble.manzana = dr.GetInt32(manzana);
                    if (!dr.IsDBNull(parcela))
                        inmueble.parcela = dr.GetInt32(parcela);
                    if (!dr.IsDBNull(p_h))
                        inmueble.p_h = dr.GetInt32(p_h);
                    if (!dr.IsDBNull(calle))
                        inmueble.calle = dr.GetString(calle);
                    if (!dr.IsDBNull(nro))
                        inmueble.nro = dr.GetInt32(nro);
                    if (!dr.IsDBNull(barrio))
                        inmueble.barrio = dr.GetString(barrio);
                    if (!dr.IsDBNull(zona))
                        inmueble.zona = dr.GetString(zona);

                    inmueble.dc = armoDenominacion(inmueble.circunscripcion, inmueble.seccion,
                        inmueble.manzana, inmueble.parcela, inmueble.p_h);
                    inmuebleList.Add(inmueble);
                }
            }
            return inmuebleList;
        }
        public static string armoDenominacion(int cir, int sec, int man, int par, int p_h)
        {
            try
            {
                StringBuilder denominacion = new StringBuilder();

                if (cir < 10)
                    denominacion.AppendFormat("CIR: 0{0} - ", cir);
                if (cir > 9 && cir < 100)
                    denominacion.AppendFormat("CIR: {0} - ", cir);

                if (sec < 10)
                    denominacion.AppendFormat("SEC: 0{0} - ", sec);
                if (sec > 9 && sec < 100)
                    denominacion.AppendFormat("SEC: {0} - ", sec);

                if (man < 10)
                    denominacion.AppendFormat("MAN: 00{0} - ", man);
                if (man > 9 && man < 100)
                    denominacion.AppendFormat("MAN: 0{0} - ", man);
                if (man > 99)
                    denominacion.AppendFormat("MAN: {0} - ", man);

                if (par < 10)
                    denominacion.AppendFormat("PAR: 00{0} - ", par);
                if (par > 9 && par < 100)
                    denominacion.AppendFormat("PAR: 0{0} - ", par);
                if (par > 99)
                    denominacion.AppendFormat("PAR: {0} - ", par);

                if (p_h < 10)
                    denominacion.AppendFormat("P_H: 00{0}", p_h);
                if (p_h > 9 && p_h < 100)
                    denominacion.AppendFormat("P_H: 0{0}", p_h);
                if (p_h > 99)
                    denominacion.AppendFormat("P_H: {0}", p_h);

                return denominacion.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string armoDenominacion2(int cir, int sec, int man, int par, int p_h)
        {
            try
            {
                StringBuilder denominacion = new StringBuilder();

                if (cir < 10)
                    denominacion.AppendFormat("0{0}", cir);
                if (cir > 9 && cir < 100)
                    denominacion.AppendFormat("{0}", cir);

                if (sec < 10)
                    denominacion.AppendFormat("0{0}", sec);
                if (sec > 9 && sec < 100)
                    denominacion.AppendFormat("{0}", sec);

                if (man < 10)
                    denominacion.AppendFormat("00{0}", man);
                if (man > 9 && man < 100)
                    denominacion.AppendFormat("0{0}", man);
                if (man > 99)
                    denominacion.AppendFormat("{0}", man);

                if (par < 10)
                    denominacion.AppendFormat("00{0}", par);
                if (par > 9 && par < 100)
                    denominacion.AppendFormat("0{0}", par);
                if (par > 99)
                    denominacion.AppendFormat("{0}", par);

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

        public static string armoDenominacion3(int cir, int sec, int man, int par, int p_h)
        {
            try
            {
                StringBuilder denominacion = new StringBuilder();

                if (cir < 10)
                    denominacion.AppendFormat("0{0} - ", cir);
                if (cir > 9 && cir < 100)
                    denominacion.AppendFormat("{0} - ", cir);

                if (sec < 10)
                    denominacion.AppendFormat("0{0} - ", sec);
                if (sec > 9 && sec < 100)
                    denominacion.AppendFormat("{0} - ", sec);

                if (man < 10)
                    denominacion.AppendFormat("00{0} - ", man);
                if (man > 9 && man < 100)
                    denominacion.AppendFormat("0{0} - ", man);
                if (man > 99)
                    denominacion.AppendFormat("{0} - ", man);

                if (par < 10)
                    denominacion.AppendFormat("00{0} - ", par);
                if (par > 9 && par < 100)
                    denominacion.AppendFormat("0{0} - ", par);
                if (par > 99)
                    denominacion.AppendFormat("{0} - ", par);

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
        public static Inmuebles_rentas getByPk(double nro_cta)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                Inmuebles_rentas byPk = null;
                using (SqlConnection connectionSiimva = DALBase.GetConnectionSIIMVA())
                {
                    SqlCommand command = connectionSiimva.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = @"
                        SELECT
	                        A.NroCuentaRENTAS AS nro_cta_rentas,
	                        B.circunscripcion,
	                        B.seccion,
	                        B.manzana,
	                        B.parcela,
	                        B.p_h,
	                        D.NOM_CALLE AS calle,
	                        C.NOM_BARRIO AS barrio,
	                        B.nro_dom_pf AS nro,
	                        B.cod_categoria_zona_liq AS zona
                        FROM INMUEBLES_NROCTA_RENTAS A
                        INNER JOIN INMUEBLES B ON 
	                        A.C=B.circunscripcion AND 
	                        A.S=B.seccion AND 
	                        A.Mz=B.manzana AND 
	                        A.Parcela=B.parcela AND
	                        A.PH=CONVERT(VARCHAR(50),B.p_h)
                        INNER JOIN BARRIOS C ON 
	                        B.cod_barrio=C.COD_BARRIO
                        INNER JOIN CALLES D ON
	                        B.cod_calle_dom_esp=D.COD_CALLE
                        WHERE A.NroCuentaRENTAS=@nro_cta";

                    command.Parameters.AddWithValue("@nro_cta", nro_cta);
                    command.Connection.Open();
                    List<Inmuebles_rentas> callesList = Inmuebles_rentas.mapeo(command.ExecuteReader());
                    if (callesList.Count != 0)
                        byPk = callesList[0];
                }
                return byPk;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static Inmuebles_rentas getByCoordenadas(decimal lat, decimal lon)
        {
            Inmuebles_rentas obj = null;
            using (SqlConnection connectionSiimva = DALBase.GetConnectionSIIMVA())
            {
                SqlCommand command = connectionSiimva.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "GET_INMUEBLES_BY_POINT";

                command.Parameters.AddWithValue("@latitude", lat);
                command.Parameters.AddWithValue("@longitude", lon);
                command.Connection.Open();
                List<Inmuebles_rentas> callesList = Inmuebles_rentas.mapeo(command.ExecuteReader());
                if (callesList.Count != 0)
                    obj = callesList[0];
                return obj;
            }
        }
    }
}
