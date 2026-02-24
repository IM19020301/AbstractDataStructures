using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bsc_sc_rpn
{
    internal class ArrayStack<T> : IStack<T>
    {
        private int TOP;
        private T[] Items;

        public ArrayStack(int length)
        {
            TOP = -1;
            Items = new T[length];
        }


        public void Push(T item)
        {
            try
            {
                TOP++;
                Items[TOP] = item;

                Console.WriteLine(item + " added to stack.");
            }
            catch
            {
                Console.WriteLine("Item cannot be added, Stack is full.");
            }
        }

        public T Pop()
        {
            T item;

            item = Items[TOP];
            TOP--;

            Console.WriteLine(item + " removed from stack.");

            return (T)Convert.ChangeType(item, typeof(T));
        }

        public T Peek()
        {
            return (T)Convert.ChangeType(Items[TOP], typeof(T));
        }

        public bool IsEmpty()
        {
            if (TOP != -1)
            {
                Console.WriteLine("Stack is not currently empty");
                return false;
            }
            else
            {
                Console.WriteLine("Stack is currently empty");
                return true;
            }
        }
    }
}
