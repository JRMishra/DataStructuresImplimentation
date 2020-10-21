using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresImplimentation
{
    class LinkedList<T>
    {
        internal Node<T> head;
        int _length=0;
        public int Length { get => _length; } 

        public void Add(T data)
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
            _length++;
        }

        public void Append(T[] datas)
        {
            foreach (T data in datas)
            {
                Add(data);
            }
        }
    }
}
