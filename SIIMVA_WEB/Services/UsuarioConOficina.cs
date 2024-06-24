// Decompiled with JetBrains decompiler
// Type: MOTOR_WORKFLOW.Services.LOGIN.UsuarioConOficina
// Assembly: MOTOR_WORKFLOW, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 007B8F5F-49BB-4EE7-8464-22FD2F567A18
// Assembly location: C:\Muni\DEV\WebApiMWF\MOTOR_WORKFLOW.dll

using System;

#nullable enable
namespace MOTOR_WORKFLOW.Services.LOGIN
{
    public class UsuarioConOficina : IUsuarioConOficina
    {
        public MOTOR_WORKFLOW.Entities.LOGIN.UsuarioConOficina getByPk(int cod_usuario)
        {
            try
            {
                return MOTOR_WORKFLOW.Entities.LOGIN.UsuarioConOficina.getByPk(cod_usuario);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool ValidaPermiso(string User, string Proceso)
        {
            try
            {
                return MOTOR_WORKFLOW.Entities.LOGIN.UsuarioConOficina.ValidaPermiso(User, Proceso);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public MOTOR_WORKFLOW.Entities.LOGIN.UsuarioConOficina ValidUser(string user, string password)
        {
            try
            {
                return MOTOR_WORKFLOW.Entities.LOGIN.UsuarioConOficina.ValidUser(user, password);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}

