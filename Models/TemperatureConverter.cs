namespace UnitConverter.Models
{
    public class TemperatureConverter
    {
        public double? Celsius { get; set; }
        public double? Fahrenheit { get; set; }

        public double CelsiusToFahrenheit()
        {
            if (!Celsius.HasValue)
            {
                throw new InvalidOperationException("The Celsius value is zero.");
            }

            return (Celsius.Value * 9 / 5) + 32;
        }

        public double FahrenheitToCelsius()
        {
            if (!Fahrenheit.HasValue)
            {
                throw new InvalidOperationException("The Fahrenheit value is zero.");
            }

            return (Fahrenheit.Value - 32) * 5 / 9;
        }
    }
}
