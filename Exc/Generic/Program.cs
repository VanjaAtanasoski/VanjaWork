using System;
using System.Collections.Generic;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> List1= new List<int>();
            List<string> List2 = new List<string>();
           /* for(int i = 0; i < 10; i++)
            {
                List2.Add(Console.ReadLine());
            }
            for(int i = 0; i < 10; i++) {
                Console.WriteLine(List2.);
            }*/
            Dictionary<string, int> ageDictionary = new Dictionary<string, int>()
            {
                {"Petko",23 },
                {"Drago", 57},
                {"Dragan", 24}
            };
            
            ageDictionary.Add("Vanja", 23);
            Console.WriteLine($"The age of Petko is{ageDictionary["Petko"]}");
            List<int> intList = new List<int>();
            intList.AddRange(new List<int>() { 3, 7, 9, 4 });
            intList.AddRange(new List<int>() { 4, 5, 6 });
            Console.WriteLine($"First occurence of 4 is {intList.IndexOf(4)}");
            intList.Insert(intList.Count, 8);
            Queue<DateTime> dateTimeQueue = new Queue<DateTime>();
            dateTimeQueue.Enqueue(DateTime.Now);
            dateTimeQueue.Enqueue(DateTime.Now.AddDays(-1));
            dateTimeQueue.Enqueue(DateTime.Now.AddDays(-2));
            dateTimeQueue.Enqueue(DateTime.Now.AddDays(-3));
            dateTimeQueue.Enqueue(DateTime.Now.AddDays(-4));
            dateTimeQueue.Enqueue(DateTime.Now.AddDays(-5));
            Console.WriteLine(dateTimeQueue.Dequeue());
            Console.WriteLine(dateTimeQueue.Dequeue());
            Console.WriteLine(dateTimeQueue.Peek());


            bool isSuccsesfull = dateTimeQueue.TryDequeue(out DateTime lastDate);
            Stack<double> doubleStack = new Stack<double>();
            doubleStack.Push(23.555);
            doubleStack.Push(233333);
            doubleStack.Push(24242424);
            Console.WriteLine(doubleStack.Pop());
        }
    }
}
