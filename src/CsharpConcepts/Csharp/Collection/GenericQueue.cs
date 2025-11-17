using Csharp.Interfaces;

namespace Csharp.Collection;

class GenericQueueDemo : IDemo
{
    public static void Run()
    {
        var queue = new Queue<string>();
        queue.Enqueue("John");
        queue.Enqueue("Jessica");
        queue.Enqueue("Robert");

        Console.WriteLine(queue.Peek());

        while (queue.Count > 0)
        {
            var p = queue.Dequeue();
            Console.WriteLine(p);
        }
    }
}
