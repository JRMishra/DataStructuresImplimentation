using System;

namespace DataStructuresImplimentation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stack Operation Implimentation Program");
            Console.WriteLine("==================================================");

            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.Add(30);
            linkedList.Add(70);
            linkedList.Insert(2, 56);
            linkedList.Display();
        }
    }
}
