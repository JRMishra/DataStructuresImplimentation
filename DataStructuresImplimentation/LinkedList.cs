using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresImplimentation
{
    class LinkedList<T>
    {
        internal Node<T> head;
        int Length { get; set; } = 0;

        internal void Add(T data)
        {
            Node<T> node = new Node<T>(data);
            if (this.head == null)
                this.head = node;
            else
            {
                Node<T> temp = head;
                while (temp.next != null)
                    temp = temp.next;
                temp.next = node;
                Console.WriteLine($"{node.data} inserted into Linked List");
            }
            Length++;
        }

        
    }
}
