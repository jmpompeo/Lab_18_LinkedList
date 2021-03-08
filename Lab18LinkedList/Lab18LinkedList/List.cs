using System;
using System.Collections.Generic;
using System.Text;

namespace Lab18LinkedList
{
    class List
    {
        private int _count = 0;
        private readonly string[] _array;

        public List(int maxLength)
        {
            _array = new string[maxLength];
        }

        public int Count()
        {
            return _count;
            
               
        }

        private bool RemoveAt(int index)
        {
            for (int i = index; i < _count; i++)
            {
                _array[i] = _array[i + 1];
            }

            if (index > _count)
            {
                return false;
            }
            _count--;

            return true;
        }

        private void PrintReverse()
        {
            int index = _array.Length;

            for (int i = index; i >= _count; i--)
            {
                Console.WriteLine(_array);
            }
        }

        private bool IsFull()
        {
            return _count == _array.Length;
        }

        private bool InsertAt(int index, object o)
        {
            if (IsFull())
            {
                return false;
            }

            _array[index] = (string)o;
            _count++;

            return true;
        }

    }
}
