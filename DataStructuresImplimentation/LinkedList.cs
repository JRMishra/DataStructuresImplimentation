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
            }
            Console.WriteLine($"{node.data} inserted into Linked List");
            _length++;
        }

        public void Append(T[] datas)
        {
            foreach(T data in datas)
            {
                Add(data);
            }
        }

        public void Insert(int position, T data)
        {
            int insertionPosition = position;

            if(position<1 || position>Length)
            {
                Console.WriteLine("Invalid Position");
                return;
            }
            Node<T> node = new Node<T>(data);
            if (position==1)
            {
                node.next = head;
                head = node;
            }
            else
            {
                Node<T> temp = head;
                while(--position>1)
                {
                    temp = temp.next;
                }
                node.next = temp.next;
                temp.next = node;
            }
            Console.WriteLine($"{node.data} inserted at a position {insertionPosition}");
        }

        public void DeleteFirstElement()
        {
            head = head.next;
            _length--;
        }

        public void DeleteLastElement()
        {
            Node<T> temp = head;
            int i = 1;
            if (Length == 1)
                head = null;
            else
            {
                while (i < Length)
                {
                    temp = temp.next;
                    i++;
                }
                temp.next = null;
            }
            _length--;
        }

        public int FindNodePosition(T value)
        {
            Node<T> temp = head;
            int position=1;

            while(!temp.data.Equals(value) && temp.next!=null)
            {
                temp = temp.next;
                position++;
            }
            
            return temp.data.Equals(value) ? position : -1;
        }

        public void InsertAfterValue(T insertAfter, T valueToInsert)
        {
            int position = FindNodePosition(insertAfter);
            if(position!=-1)
            {
                Insert(position + 1, valueToInsert);
            }
        }

        public void DeleteAValue(T value)
        {
            int position = FindNodePosition(value);
            if (position == -1)
                return;
            if (position == 1)
                head = head.next;
            else
            {
                Node<T> temp = head;
                while (!temp.next.data.Equals(value))
                    temp = temp.next;
                temp.next = temp.next.next;
            }
        }

        public void Display()
        {
            Node<T> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
    }
}
