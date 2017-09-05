using System;
using System.Collections.Generic;

namespace Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> tasks = new Queue<string>();

            tasks.Enqueue("Do the washing up");
            tasks.Enqueue("Finish C# module");
            tasks.Enqueue("Buy chocolate");
            tasks.Enqueue("Buy more chcolate");

            Console.WriteLine("\r\nALLTASKS: ");
            foreach (string title in tasks)
                Console.WriteLine(title);

            //removes and returns the object at the beginning of the queue
            string nextTask = tasks.Dequeue();
            Console.WriteLine("\r\n" + nextTask);
            Console.WriteLine("\r\nALLTASKS: ");
            foreach (string title in tasks)
                Console.WriteLine(title);

            //returns the object at the beginning of the queue without removing it
            string nextTask2 = tasks.Peek();
            Console.WriteLine("\r\n" + nextTask2);
            Console.WriteLine("\r\nALLTASKS: ");
            foreach (string title in tasks)
                Console.WriteLine(title);
        }
    }
}
