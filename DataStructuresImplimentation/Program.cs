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
            Console.WriteLine(linkedList.FindNodePosition(56));
            Console.WriteLine(linkedList.FindNodePosition(62));
            Console.WriteLine(linkedList.FindNodePosition(16));
            linkedList.InsertAfterValue(62, 44);
            linkedList.Display();
        }
    }
}
