using NUnit.Framework;

namespace NUnit
{
    public class TemperatureConverterTests
    {
        [TestCase(32, 0)]
        [TestCase(47, 8.33)]
        [TestCase(86, 30)]
        [TestCase(90.5, 32.5)]
        [TestCase(120.18, 48.99)]
        [TestCase(212, 100)]
        public void TestTemperatureConversion(
            double tempFahrenheit, double tempCelsius)
        {
            double calculated =
                Temp.TemperatureConverter.FahrenheitToCelsius(tempFahrenheit);
            Assert.AreEqual(tempCelsius, calculated);
        }
    }
}