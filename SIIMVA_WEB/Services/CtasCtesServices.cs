using MOTOR_WORKFLOW.Entities;
using MOTOR_WORKFLOW.Models;
using Newtonsoft.Json;
using System.Data.SqlClient;

namespace MOTOR_WORKFLOW.Services
{
    public class CtasCtesServices : ICtasCtesInmServices
    {
        public void NuevaDeuda(CtasCtes_Con_Auditoria obj, string estado)
        {
			try
			{
				using(SqlConnection con = DALBase.GetConnectionSIIMVA())
				{
					con.Open();
					using (SqlTransaction trx = con.BeginTransaction()) {
                        var CtaCte = obj.lstCtastes[0];
                        obj.auditoria.identificacion = Helpers.Utils.armoDenominacion3(CtaCte.circunscripcion, CtaCte.seccion, CtaCte.manzana, CtaCte.parcela, CtaCte.p_h);
                        obj.auditoria.proceso = "NUEVA DEUDA INMUEBLE VISADO MW";
                        obj.auditoria.detalle = JsonConvert.SerializeObject(obj);
                        obj.auditoria.observaciones = string.Format(" Fecha nueva deuda: {0} ", DateTime.Now);

                        var ultimoRegistro = Ctasctes_inmuebles.ObtenerUltimoNroTransaccion(con, trx);
                        CtaCte.periodo = Helpers.Utils.GeneroPeriodoCatastro(estado, ultimoRegistro);
                         
                        Ctasctes_inmuebles.InsertNvaDeuda(CtaCte, con, trx, ultimoRegistro + 1);

                    }



                }
				
			}
			catch (Exception ex)
			{
				throw ex;
			}
        }
    }
}
