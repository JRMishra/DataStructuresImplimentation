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
            linkedList.Add(17);
            linkedList.Add(54);
            linkedList.Insert(2, 56);
            linkedList.Insert(4, 62);
            linkedList.Display();
            linkedList.DeleteFirstElement();
            linkedList.Display();
            linkedList.DeleteLastElement();
            linkedList.Display();
        }
    }
}
