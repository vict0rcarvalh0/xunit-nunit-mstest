namespace MSTest;

[TestClass]
public class TemperatureConverterTests
{
    [DataRow(32, 0)]
    [DataRow(47, 8.33)]
    [DataRow(86, 30)]
    [DataRow(90.5, 32.5)]
    [DataRow(120.18, 48.99)]
    [DataRow(212, 100)]
    [DataTestMethod]
    public void TestTemperatureConversion(
        double tempFahrenheit, double tempCelsius)
    {
        double calculated =
            Temp.TemperatureConverter.FahrenheitToCelsius(tempFahrenheit);
        Assert.AreEqual(tempCelsius, calculated);
    }
}