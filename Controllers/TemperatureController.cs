using Microsoft.AspNetCore.Mvc;
using UnitConverter.Models;

namespace UnitConverter.Controllers
{
    public class TemperatureController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Convert(string convertType, double temperature)
        {
            TemperatureConverter converter = new TemperatureConverter();

            if (convertType == "ToFahrenheit")
            {
                converter.Celsius = temperature;
                ViewBag.Result = $"Fahrenheit (°F): {converter.CelsiusToFahrenheit()} ºF";
                ViewBag.Calculation = $"Calculation: {temperature} ºC x 9/5 + 32 = {converter.CelsiusToFahrenheit()} ºF";
            }
            else if (convertType == "ToCelsius")
            {
                converter.Fahrenheit = temperature;
                ViewBag.Result = $"Celsius (°C): {converter.FahrenheitToCelsius()} ºC";
                ViewBag.Calculation = $"Calculation: ({temperature} ºF - 32) x 5/9 = {converter.FahrenheitToCelsius()} ºC";
            }

            return View("Index");
        }
    }
}
