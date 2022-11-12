using ConsoleApp1;
using System.Collections;

public class Program : OnpClass
{
    static void Main(string[] args)
    {
        Console.WriteLine("Stack:");
        Stack();

        Console.WriteLine("\nQueue:");
        Queue();

        Console.WriteLine("\nOnp:");
        Onp("5 + ((1 + 2) * 4) - 3");

    }

    private static void Stack()
    {
        Stack stack = new Stack();
        stack.Push("stack1");
        stack.Push("stack2");
        stack.Push("stack3");

        stack.Pop();

        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }
    }

    private static void Queue()
    {
        Queue queue = new Queue();
        queue.Enqueue("queue1");
        queue.Enqueue("queue2");
        queue.Enqueue("queue3");

        queue.Dequeue();

        foreach (var item in queue)
        {
            Console.WriteLine(item);
        }
    }
}