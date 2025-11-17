using CsharpConcepts.Core.Interfaces;

namespace CsharpConcepts.Demos.Advance;

class RandomItemGenerator<T>
{
    private readonly List<T> _items = new List<T>();
    private readonly Random random = new Random();

    public void Add(T item)
    {
        _items.Add(item);
    }

    public T Get()
    {
        var index = random.Next(0, _items.Count);
        return _items[index];
    }
}

public class GenericTypeDemo : IDemo
{
    public static void Run()
    {
        var randomCities = new RandomItemGenerator<string>();
        randomCities.Add("Zurich");
        randomCities.Add("New York");
        randomCities.Add("Munich");
        randomCities.Add("Rome");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(randomCities.Get());
        }

        var randomNumber = new RandomItemGenerator<int>();
        randomNumber.Add(32);
        randomNumber.Add(54);
        randomNumber.Add(17);
        randomNumber.Add(84);
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(randomNumber.Get());
        }
    }
}
