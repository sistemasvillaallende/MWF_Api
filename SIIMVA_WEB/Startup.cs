﻿// Decompiled with JetBrains decompiler
// Type: MOTOR_WORKFLOW.Startup
// Assembly: MOTOR_WORKFLOW, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 007B8F5F-49BB-4EE7-8464-22FD2F567A18
// Assembly location: C:\Muni\DEV\WebApiMWF\MOTOR_WORKFLOW.dll
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Primitives;
using MOTOR_WORKFLOW.Controllers.Controllers;
using MOTOR_WORKFLOW.Services;
using MOTOR_WORKFLOW.Services.CIDI;
using MOTOR_WORKFLOW.Services.JWT;
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
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
            options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ValidIssuer = "TuIssuer",
                ValidAudience = "TuAudience",
                IssuerSigningKey = new Microsoft.IdentityModel.Tokens.SymmetricSecurityKey(
                    System.Text.Encoding.UTF8.GetBytes("your-very-long-secret-key-that-is-at-least-32-characters"))
            };
            options.Events = new JwtBearerEvents
            {
                OnAuthenticationFailed = context =>
                {
                    Console.WriteLine("❌ Error de autenticación: " + context.Exception.Message);
                    return Task.CompletedTask;
                },
                OnTokenValidated = context =>
                {
                    Console.WriteLine("✅ Token validado correctamente para: " + context.Principal.Identity.Name);
                    return Task.CompletedTask;
                }
            };

        });
            services.Configure<FormOptions>(options =>
            {
                options.MultipartBodyLengthLimit = 104857600; // 100 MB, ajusta este valor según tus necesidades
            });
            services.AddControllers();
            services.AddSwaggerGen();
            services.AddScoped<IAdjuntoService, AdjuntoService>();
            services.AddScoped<ICIDIServices, CIDIServices>();
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
            services.AddScoped<IControlPagoServices, ControlPagoServices>();
            services.AddScoped<IValidacionesServices, ValidacionesServices>();
            services.AddScoped<IInmuebles_rentasServices, Inmuebles_rentasServices>();
            services.AddScoped<IPagosPayperticServices, PagosPayPerTicServices>();
            services.AddScoped<ICtasCtesInmServices, CtasCtesServices>();
            services.AddScoped<IVecinoDigitalServices, VecinoDigitalServices>();
            services.AddScoped<IComunicacionesService, ComunicacionesService>();
            services.AddScoped<IContenido_ingreso_paso_particularService, Contenido_ingreso_paso_particularService>();
            services.AddScoped<JwtTokenService>();

            services.AddCors();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI();
            app.UseStaticFiles();
            app.UseAuthentication();  
            app.UseAuthorization();  
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