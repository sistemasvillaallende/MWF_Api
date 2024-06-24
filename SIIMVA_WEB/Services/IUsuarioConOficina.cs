// Decompiled with JetBrains decompiler
// Type: MOTOR_WORKFLOW.Services.LOGIN.IUsuarioConOficina
// Assembly: MOTOR_WORKFLOW, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 007B8F5F-49BB-4EE7-8464-22FD2F567A18
// Assembly location: C:\Muni\DEV\WebApiMWF\MOTOR_WORKFLOW.dll

#nullable enable
namespace MOTOR_WORKFLOW.Services.LOGIN
{
    public interface IUsuarioConOficina
    {
        MOTOR_WORKFLOW.Entities.LOGIN.UsuarioConOficina ValidUser(string user, string password);

        MOTOR_WORKFLOW.Entities.LOGIN.UsuarioConOficina getByPk(int cod_usuario);

        bool ValidaPermiso(string User, string Proceso);
    }
}