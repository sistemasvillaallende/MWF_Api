// Decompiled with JetBrains decompiler
// Type: MOTOR_WORKFLOW.Entities.LOGIN.UsuarioConOficina
// Assembly: MOTOR_WORKFLOW, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 007B8F5F-49BB-4EE7-8464-22FD2F567A18
// Assembly location: C:\Muni\DEV\WebApiMWF\MOTOR_WORKFLOW.dll

using MOTOR_WORKFLOW.Helpers;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

#nullable enable
namespace MOTOR_WORKFLOW.Entities.LOGIN
{
    public class UsuarioConOficina : DALBase
    {
        public int cod_usuario { get; set; }

        public string nombre { get; set; }

        public int legajo { get; set; }

        public bool administrador { get; set; }

        public string nombre_completo { get; set; }

        public string passwd { get; set; }

        public string email { get; set; }

        public bool baja { get; set; }

        public int cod_oficina { get; set; }

        public string nombre_oficina { get; set; }

        public string cuit { get; set; }

        public static UsuarioConOficina ValidUser(string user, string password)
        {
            UsuarioConOficina usuarioConOficina = (UsuarioConOficina)null;
            SqlConnection sqlConnection = (SqlConnection)null;
            StringBuilder stringBuilder = new StringBuilder();
            MD5Encryption md5Encryption = new MD5Encryption();
            user = user.Replace("'", "").Replace(",", "").Replace("=", "");
            stringBuilder.AppendLine("SELECT U.*, O.nombre_oficina From USUARIOS_V2 U INNER JOIN OFICINAS O ON U.COD_OFICINA = O.codigo_oficina WHERE nombre = @user");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Parameters.Add(new SqlParameter("@user", user));
            try
            {
                sqlConnection = DALBase.GetConnectionSIIMVA();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = stringBuilder.ToString();
                sqlCommand.Connection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                int ordinal1 = sqlDataReader.GetOrdinal("cod_usuario");
                int ordinal2 = sqlDataReader.GetOrdinal("nombre");
                int ordinal3 = sqlDataReader.GetOrdinal("legajo");
                int ordinal4 = sqlDataReader.GetOrdinal("administrador");
                int ordinal5 = sqlDataReader.GetOrdinal("nombre_completo");
                int ordinal6 = sqlDataReader.GetOrdinal("email");
                int ordinal7 = sqlDataReader.GetOrdinal("baja");
                int ordinal8 = sqlDataReader.GetOrdinal("COD_OFICINA");
                int ordinal9 = sqlDataReader.GetOrdinal("nombre_oficina");
                int ordinal10 = sqlDataReader.GetOrdinal("cuit");
                while (sqlDataReader.Read())
                {
                    if (sqlDataReader.GetString(sqlDataReader.GetOrdinal("passwd")) == MD5Encryption.EncryptMD5(password.Trim().ToUpper() + user.Trim().ToUpper()))
                    {
                        usuarioConOficina = new UsuarioConOficina();
                        if (!sqlDataReader.IsDBNull(ordinal4))
                            usuarioConOficina.administrador = sqlDataReader.GetBoolean(ordinal4);
                        if (!sqlDataReader.IsDBNull(ordinal7))
                            usuarioConOficina.baja = sqlDataReader.GetBoolean(ordinal7);
                        if (!sqlDataReader.IsDBNull(ordinal1))
                            usuarioConOficina.cod_usuario = sqlDataReader.GetInt32(ordinal1);
                        if (!sqlDataReader.IsDBNull(ordinal6))
                            usuarioConOficina.email = sqlDataReader.GetString(ordinal6);
                        if (!sqlDataReader.IsDBNull(ordinal3))
                            usuarioConOficina.legajo = sqlDataReader.GetInt32(ordinal3);
                        if (!sqlDataReader.IsDBNull(ordinal2))
                            usuarioConOficina.nombre = sqlDataReader.GetString(ordinal2);
                        if (!sqlDataReader.IsDBNull(ordinal5))
                            usuarioConOficina.nombre_completo = sqlDataReader.GetString(ordinal5);
                        usuarioConOficina.passwd = string.Empty;
                        if (!sqlDataReader.IsDBNull(ordinal8))
                            usuarioConOficina.cod_oficina = sqlDataReader.GetInt32(ordinal8);
                        if (!sqlDataReader.IsDBNull(ordinal9))
                            usuarioConOficina.nombre_oficina = sqlDataReader.GetString(ordinal9);
                        if (!sqlDataReader.IsDBNull(ordinal10))
                            usuarioConOficina.cuit = sqlDataReader.GetString(ordinal10);
                    }
                }
                return usuarioConOficina;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + " Error en la Autenticación!!!.");
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public static UsuarioConOficina getByPk(int cod_usuario)
        {
            SqlConnection sqlConnection = (SqlConnection)null;
            StringBuilder stringBuilder = new StringBuilder();
            UsuarioConOficina byPk = (UsuarioConOficina)null;
            stringBuilder.AppendLine("SELECT U.*, O.nombre_oficina From USUARIOS_V2 U INNER JOIN OFICINAS O ON U.COD_OFICINA = O.codigo_oficina WHERE cod_usuario = @cod_usuario");
            SqlCommand sqlCommand = new SqlCommand();
            try
            {
                sqlConnection = DALBase.GetConnectionSIIMVA();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = stringBuilder.ToString();
                sqlCommand.Parameters.AddWithValue("@cod_usuario", cod_usuario);
                sqlCommand.Connection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                int ordinal1 = sqlDataReader.GetOrdinal(nameof(cod_usuario));
                int ordinal2 = sqlDataReader.GetOrdinal("nombre");
                int ordinal3 = sqlDataReader.GetOrdinal("legajo");
                int ordinal4 = sqlDataReader.GetOrdinal("administrador");
                int ordinal5 = sqlDataReader.GetOrdinal("nombre_completo");
                int ordinal6 = sqlDataReader.GetOrdinal("email");
                int ordinal7 = sqlDataReader.GetOrdinal("baja");
                int ordinal8 = sqlDataReader.GetOrdinal("COD_OFICINA");
                int ordinal9 = sqlDataReader.GetOrdinal("nombre_oficina");
                int ordinal10 = sqlDataReader.GetOrdinal("cuit");
                while (sqlDataReader.Read())
                {
                    byPk = new UsuarioConOficina();
                    if (!sqlDataReader.IsDBNull(ordinal4))
                        byPk.administrador = sqlDataReader.GetBoolean(ordinal4);
                    if (!sqlDataReader.IsDBNull(ordinal7))
                        byPk.baja = sqlDataReader.GetBoolean(ordinal7);
                    if (!sqlDataReader.IsDBNull(ordinal1))
                        byPk.cod_usuario = sqlDataReader.GetInt32(ordinal1);
                    if (!sqlDataReader.IsDBNull(ordinal6))
                        byPk.email = sqlDataReader.GetString(ordinal6);
                    if (!sqlDataReader.IsDBNull(ordinal3))
                        byPk.legajo = sqlDataReader.GetInt32(ordinal3);
                    if (!sqlDataReader.IsDBNull(ordinal2))
                        byPk.nombre = sqlDataReader.GetString(ordinal2);
                    if (!sqlDataReader.IsDBNull(ordinal5))
                        byPk.nombre_completo = sqlDataReader.GetString(ordinal5);
                    byPk.passwd = string.Empty;
                    if (!sqlDataReader.IsDBNull(ordinal8))
                        byPk.cod_oficina = sqlDataReader.GetInt32(ordinal8);
                    if (!sqlDataReader.IsDBNull(ordinal9))
                        byPk.nombre_oficina = sqlDataReader.GetString(ordinal9);
                    if (!sqlDataReader.IsDBNull(ordinal10))
                        byPk.cuit = sqlDataReader.GetString(ordinal10);
                }
                return byPk;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + " Error en la Autenticación!!!.");
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public static bool ValidaPermiso(string User, string Proceso)
        {
            string str1 = "SELECT * FROM PROCESOS_V2 a, PROCESOS_x_USUARIO_V2 b, " + "USUARIOS_V2 c WHERE " + "c.nombre='" + User + "' AND " + "c.cod_usuario=b.cod_usuario AND " + "b.cod_proceso=a.cod_proceso AND " + "a.proceso='" + Proceso + "'";
            MD5Encryption md5Encryption = new MD5Encryption();
            SqlConnection connectionSiimva = DALBase.GetConnectionSIIMVA();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connectionSiimva;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = str1.ToString();
            sqlCommand.Connection.Open();
            try
            {
                SqlDataReader sqlDataReader1 = sqlCommand.ExecuteReader();
                if (sqlDataReader1.Read())
                {
                    sqlDataReader1.Close();
                    return true;
                }
                string str2 = "SELECT * FROM USUARIOS_V2 WHERE " + "administrador=1 AND " + "nombre='" + User + "'";
                sqlDataReader1.Close();
                sqlCommand.CommandText = str2.ToString();
                SqlDataReader sqlDataReader2 = sqlCommand.ExecuteReader();
                if (sqlDataReader2.Read())
                {
                    sqlDataReader2.Close();
                    return true;
                }
                sqlDataReader2.Close();
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + " Error en la Autorización de Permiso!!!.");
            }
            finally
            {
                connectionSiimva.Close();
            }
        }
    }
}
