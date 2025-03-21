// Decompiled with JetBrains decompiler
// Type: MOTOR_WORKFLOW.Entities.DALBase
// Assembly: MOTOR_WORKFLOW, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 007B8F5F-49BB-4EE7-8464-22FD2F567A18
// Assembly location: C:\Muni\DEV\WebApiMWF\MOTOR_WORKFLOW.dll

using System;
using System.Data;
using System.Data.SqlClient;

#nullable enable
namespace MOTOR_WORKFLOW.Entities
{
    public class DALBase
    {
        public static SqlConnection GetConnection()
        {
            try
            {
                return new SqlConnection("Data Source=10.0.0.23;Initial Catalog=MOTOR_WORKFLOW;User ID=general;");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static SqlConnection GetConnectionSIIMVA()
        {
            try
            {
                return new SqlConnection("Data Source=10.0.0.8;Initial Catalog=SIIMVA;User ID=general;");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static int GetNroTransaccion(int subsistema)
        {
            try
            {
                int nro_transaccion = 0;
                string strSQL = string.Empty;
                switch (subsistema)
                {
                    case 1:
                        strSQL = @"SELECT ISNULL(MAX(nro_tran_inmueble),0) as nro_transaccion
                                   FROM Numeros_Claves";
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        strSQL = @"SELECT ISNULL(MAX(nro_tran_automotor),0) as nro_transaccion
                                   FROM Numeros_Claves";
                        break;
                    default:
                        break;
                }
                using (SqlConnection cn = GetConnectionSIIMVA())
                {
                    SqlCommand cmd = cn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = strSQL;
                    cmd.Connection.Open();
                    nro_transaccion = Convert.ToInt32(cmd.ExecuteScalar());
                }
                return nro_transaccion;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static void UpdateNroTransaccion(int subsistema, int nro_transaccion)
        {
            try
            {
                string strSQL = string.Empty;
                switch (subsistema)
                {
                    case 1:
                        strSQL = @"UPDATE Numeros_claves
                                   Set nro_tran_inmueble = @nro_transaccion
                                   FROM Numeros_Claves";
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        strSQL = @"UPDATE Numeros_claves
                                   Set nro_tran_automotor = @nro_transaccion
                                   FROM Numeros_Claves";
                        break;
                    default:
                        break;
                }
                using (SqlConnection cn = GetConnectionSIIMVA())
                {
                    SqlCommand cmd = cn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = strSQL;
                    cmd.Connection.Open();
                    cmd.Parameters.AddWithValue("@nro_transaccion", nro_transaccion);
                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
