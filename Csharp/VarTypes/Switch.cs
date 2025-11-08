using Csharp.Interfaces;
using Csharp.VarTypes;

namespace Csharp.VarTypes;

class Temperature2 : Temperature
{
    public Temperature2(TemperatureUnit unit, decimal value) : base(unit, value)
    {
    }

    public override decimal ValueInCelsius
    {
        get
        {
            return Unit switch
            {
                TemperatureUnit.Celsius when Value > 100 => Math.Round(Value, 0),
                TemperatureUnit.Celsius => Value,
                TemperatureUnit.Fahrenheit => (Value - 32) * 5 / 9,
                TemperatureUnit.Kelvin => Value - 273.15m,
                _ => throw new ArgumentOutOfRangeException(nameof(Unit), "Unknown temperature unit")
            };
        }
    }
}

class switchDemo : IDemo
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