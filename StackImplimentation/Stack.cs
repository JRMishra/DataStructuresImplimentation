using System;
using System.Collections.Generic;
using System.Text;
using DataStructuresImplimentation;

namespace StackImplimentation
{
    class Stack<T>
    {
        MyLinkedList<T> stack = new MyLinkedList<T>();

        public void Push(T data)
        {
            stack.Insert(1, data);
        }
    }
}
