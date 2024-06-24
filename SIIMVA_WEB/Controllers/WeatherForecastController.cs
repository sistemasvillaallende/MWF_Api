// Decompiled with JetBrains decompiler
// Type: MOTOR_WORKFLOW.Controllers.WeatherForecastController
// Assembly: MOTOR_WORKFLOW, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 007B8F5F-49BB-4EE7-8464-22FD2F567A18
// Assembly location: C:\Muni\DEV\WebApiMWF\MOTOR_WORKFLOW.dll

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

#nullable enable
namespace MOTOR_WORKFLOW.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class WeatherForecastController : ControllerBase
  {
    private static readonly string[] Summaries = new string[10]
    {
      "Freezing",
      "Bracing",
      "Chilly",
      "Cool",
      "Mild",
      "Warm",
      "Balmy",
      "Hot",
      "Sweltering",
      "Scorching"
    };
    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
      this._logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
      return (IEnumerable<WeatherForecast>) Enumerable.Range(1, 5).Select<int, WeatherForecast>((Func<int, WeatherForecast>) (index => new WeatherForecast()
      {
        Date = DateTime.Now.AddDays((double) index),
        TemperatureC = Random.Shared.Next(-20, 55),
        Summary = WeatherForecastController.Summaries[Random.Shared.Next(WeatherForecastController.Summaries.Length)]
      })).ToArray<WeatherForecast>();
    }
  }
}
