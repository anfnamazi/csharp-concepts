namespace Csharp.OOP;

interface ICar
{
    string GetModel();
    int GetTopSpeed();
}

class TeslaCar : ICar
{
    public string GetModel()
    {
        return "Tesla-2011";
    }

    public int GetTopSpeed()
    {
        return 150;
    }
}
class BmwCar : ICar
{
    public string GetModel()
    {
        return "BMW-2020";
    }

    public int GetTopSpeed()
    {
        return 220;
    }
}

public class InterfaceDemo
{
    public static void Run()
    {
        ICar teslaCar = new TeslaCar();
        ICar bmwCar = new BmwCar();
        Console.WriteLine(teslaCar.GetModel());
        Console.WriteLine(bmwCar.GetTopSpeed());
    }
}

