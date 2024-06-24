// Decompiled with JetBrains decompiler
// Type: MOTOR_WORKFLOW.Startup
// Assembly: MOTOR_WORKFLOW, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 007B8F5F-49BB-4EE7-8464-22FD2F567A18
// Assembly location: C:\Muni\DEV\WebApiMWF\MOTOR_WORKFLOW.dll

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Primitives;
using MOTOR_WORKFLOW.Services;
using MOTOR_WORKFLOW.Services.LOGIN;
using Swashbuckle.AspNetCore.SwaggerUI;
using System;

#nullable enable
namespace MOTOR_WORKFLOW
{
    public class Startup
    {
        public Startup(IConfiguration configuration) => this.Configuration = configuration;

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerGen();
            services.AddScoped<IAdjuntoService, AdjuntoService>();
            services.AddScoped<ICampos_x_formularioService, Campos_x_formularioService>();
            services.AddScoped<IFormularioService, FormularioService>();
            services.AddScoped<IIngresos_x_pasoService, Ingresos_x_pasoService>();
            services.AddScoped<IPasoService, PasoService>();
            services.AddScoped<ITipo_campoService, Tipo_campoService>();
            services.AddScoped<IValidacion_campoService, Validacion_campoService>();
            services.AddScoped<IValidacion_x_campo_formularioService, Validacion_x_campo_formularioService>();
            services.AddScoped<IWs_configura_campo_formularioService, Ws_configura_campo_formularioService>();
            services.AddScoped<IWs_contenido_campo_formularioService, Ws_contenido_campo_formularioService>();
            services.AddScoped<IWs_headers_parametersService, Ws_headers_parametersService>();
            services.AddScoped<IWs_url_parametersService, Ws_url_parametersService>();
            services.AddScoped<IWs_web_serviceService, Ws_web_serviceService>();
            services.AddScoped<IPasosService, PasosService>();
            services.AddScoped<ITramitesService, TramitesService>();
            services.AddScoped<ITramiteService, TramiteService>();
            services.AddScoped<IUsuarioConOficina, UsuarioConOficina>();
            services.AddScoped<IOficinasService, OficinasService>();
            services.AddScoped<IIngresos_x_pasoService, Ingresos_x_pasoService>();
            services.AddScoped<IContenido_ingreso_pasoService, Contenido_ingreso_pasoService>();
            services.AddScoped<IDdjjService, DdjjService>();
            services.AddScoped<IAdjuntoService, AdjuntoService>();
            services.AddScoped<IBarriosService, BarriosService>();
            services.AddScoped<ICallesService, CallesService>();
            services.AddCors();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI();
            app.UseStaticFiles();
            app.UseStaticFiles(new StaticFileOptions()
            {
                OnPrepareResponse = (Action<StaticFileResponseContext>)(ctx => ctx.Context.Response.Headers.Add("X-Copyright", (string)"Copyright 2016 - JMA"))
            });
            app.UseSwaggerUI((Action<SwaggerUIOptions>)(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Taskman API V1")));
            app.UseRouting();
            app.UseCors((Action<CorsPolicyBuilder>)(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()));
            Console.WriteLine(env.EnvironmentName);
            app.UseRouting();
            app.UseEndpoints((Action<IEndpointRouteBuilder>)(endpoints => endpoints.MapControllers()));
        }
    }
}