using System;
using Microsoft.AspNetCore.Mvc;
using APITemperaturas.Models;

namespace APITemperaturas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConversorTemperaturasController : ControllerBase
    {
        [HttpGet("Fahrenheit/{temperatura}")]
        public object GetConversaoFahrenheit(double temperatura)
        {
            Temperatura dados = new Temperatura();
            dados.ValorFahrenheit = temperatura;
            dados.ValorCelsius =
                Math.Round((temperatura - 32.0) / 1.8, 2);
            dados.ValorKelvin = dados.ValorCelsius + 273.15;

            return dados;
        }
    }
}