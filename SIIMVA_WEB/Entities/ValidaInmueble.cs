using System.Data.SqlClient;
using System.Data;
using System.Text;
using MOTOR_WORKFLOW.Models;
using static System.Collections.Specialized.BitVector32;

namespace MOTOR_WORKFLOW.Entities
{
    public class ValidaInmueble
    {
        private static ValidaInmuebleModel mapeo(SqlDataReader dr)
        {
            ValidaInmuebleModel obj = null;
            if (dr.HasRows)
            {
                int CIR = dr.GetOrdinal("CIR");
                int SEC = dr.GetOrdinal("SEC");
                int MAN = dr.GetOrdinal("MAN");
                int PAR = dr.GetOrdinal("PAR");         
                int P_H = dr.GetOrdinal("P_H");
                int CALLE = dr.GetOrdinal("CALLE");
                int NRO = dr.GetOrdinal("NRO");
                int BARRIO = dr.GetOrdinal("BARRIO");
                int ZONA = dr.GetOrdinal("ZONA");
                while (dr.Read())
                {
                    obj = new ValidaInmuebleModel();
                    if (!dr.IsDBNull(CIR))
                        obj.CIR = dr.GetInt32(CIR);
                    if (!dr.IsDBNull(SEC))
                        obj.SEC = dr.GetInt32(SEC);
                    if (!dr.IsDBNull(MAN))
                        obj.MAN = dr.GetInt32(MAN);
                    if (!dr.IsDBNull(PAR))
                        obj.PAR = dr.GetInt32(PAR);
                    if (!dr.IsDBNull(P_H))
                        obj.P_H = dr.GetInt32(P_H);
                    if (!dr.IsDBNull(CALLE))
                        obj.CALLE = dr.GetString(CALLE);
                    if (!dr.IsDBNull(NRO))
                        obj.NRO = dr.GetInt32(NRO);
                    if (!dr.IsDBNull(BARRIO))
                        obj.BARRIO = dr.GetString(BARRIO);
                    if (!dr.IsDBNull(ZONA))
                        obj.ZONA = dr.GetString(ZONA);
                }
            }
            return obj;
        }


        public static ValidaInmuebleModel getByPk(int circunscripcion, int seccion,
            int manzana, int parcela, int p_h)
        {
            try
            {
                ValidaInmuebleModel byPk = null;
                using (SqlConnection connection = DALBase.GetConnectionSIIMVA())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = @"
                        SELECT 
                            A.circunscripcion AS CIR,
                            A.seccion AS SEC,
                            A.manzana AS MAN,
                            A.parcela AS PAR,
                            A.p_h AS P_H,
                            B.NOM_BARRIO AS BARRIO,
                            C.NOM_CALLE AS CALLE,
	                        A.nro_dom_esp AS NRO,
                            A.cod_categoria_zona_liq AS ZONA
                        FROM INMUEBLES A
                            INNER JOIN BARRIOS B ON A.COD_BARRIO=B.COD_BARRIO
                            INNER JOIN CALLES C ON A.cod_calle_dom_esp=C.COD_CALLE
                        WHERE   
                            circunscripcion=@circunscripcion AND
                            seccion=@seccion AND
                            manzana=@manzana AND
                            parcela=@parcela AND
                            p_h=@p_h";

                    command.Parameters.AddWithValue("@circunscripcion", circunscripcion);
                    command.Parameters.AddWithValue("@seccion", seccion);
                    command.Parameters.AddWithValue("@manzana", manzana);
                    command.Parameters.AddWithValue("@parcela", parcela);
                    command.Parameters.AddWithValue("@p_h", p_h);

                    command.Connection.Open();
                    return mapeo(command.ExecuteReader());
                }
                return byPk;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
