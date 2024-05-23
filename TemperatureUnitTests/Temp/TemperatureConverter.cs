namespace Temp
{
    public static class TemperatureConverter
    {
        public static double FahrenheitToCelsius(double temperature)
            //=> (temperature - 32) / 1.8; // Simulação de falha
            => Math.Round((temperature - 32) / 1.8, 2);
    }
}