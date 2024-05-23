namespace XUnitTest;

public class TemperatureConverterTests
{
    [Theory]
    [InlineData(32, 0)]
    [InlineData(47, 8.33)]
    [InlineData(86, 30)]
    [InlineData(90.5, 32.5)]
    [InlineData(120.18, 48.99)]
    [InlineData(212, 100)]
    public void TestTemperatureConversion(
        double tempFahrenheit, double tempCelsius)
    {
        double calculated =
            Temp.TemperatureConverter.FahrenheitToCelsius(tempFahrenheit);
        Assert.Equal(tempCelsius, calculated);
    }
}
