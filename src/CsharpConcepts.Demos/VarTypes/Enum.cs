using CsharpConcepts.Core.Interfaces;

namespace CsharpConcepts.Demos.VarTypes;

enum TemperatureUnit
{
    Celsius,
    Fahrenheit,
    Kelvin,
}

class Temperature
{
    public Temperature(TemperatureUnit unit, decimal value)
    {
        Unit = unit;
        Value = value;
    }

    public TemperatureUnit Unit { get; set; }
    public decimal Value { get; set; }
    public virtual decimal ValueInCelsius
    {
        get
        {
            if (Unit == TemperatureUnit.Celsius)
            {
                return Value;
            }
            if (Unit == TemperatureUnit.Fahrenheit)
            {
                return (Value - 32) * 5 / 9;
            }
            if (Unit == TemperatureUnit.Kelvin)
            {
                return Value - 273.15m;
            }
            throw new ArgumentOutOfRangeException(nameof(Unit), "Unknown temperature unit");
        }
    }
}

public class EnumDemo : IDemo
{
    public static void Run()
    {
        var tempC = new Temperature(TemperatureUnit.Celsius, 25);
        var tempF = new Temperature(TemperatureUnit.Fahrenheit, 77);
        var tempK = new Temperature(TemperatureUnit.Kelvin, 298.15m);

        Console.WriteLine($"25 Temperature in Celsius: {tempC.ValueInCelsius}°C");
        Console.WriteLine($"77 Temperature in Fahrenheit: {tempF.ValueInCelsius}°C");
        Console.WriteLine($"298.15 Temperature in Kelvin: {tempK.ValueInCelsius}°C");
    }
}
