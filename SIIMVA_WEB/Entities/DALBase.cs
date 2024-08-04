// Decompiled with JetBrains decompiler
// Type: MOTOR_WORKFLOW.Entities.DALBase
// Assembly: MOTOR_WORKFLOW, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 007B8F5F-49BB-4EE7-8464-22FD2F567A18
// Assembly location: C:\Muni\DEV\WebApiMWF\MOTOR_WORKFLOW.dll

using System;
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
                return new SqlConnection("Data Source=10.0.0.23;Initial Catalog=MOTOR_WORKFLOW;User id=general");
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
                return new SqlConnection("Data Source=10.0.0.23;Initial Catalog=SIIMVA;User id=general");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
