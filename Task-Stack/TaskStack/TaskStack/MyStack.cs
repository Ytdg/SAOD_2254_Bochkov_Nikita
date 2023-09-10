using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskStack
{
    internal class MyStack<T>
    {
        public int Capacity { get; private set; }
        public int Count { get; private set; }
        T[] data;
        T defaoultValue;
        public MyStack(int capacity)
        {
            Capacity = capacity;
            data = new T[Capacity];
            defaoultValue = data[0];
        }
        int currentIndex;
        public void Push(T val)
        {
            if (Count == Capacity)
            {
                throw new Exception("Стек заполнен!");
            }

            data[currentIndex] = val;
            Count++;
            currentIndex++;

        }

        public T Pop()
        {
            if (Count == 0)
            {
                throw new Exception("Стек пуст!");
            }

            var item = data[currentIndex - 1];
            data[currentIndex - 1] = defaoultValue;
            Count--;
            currentIndex--;
            return item;


        }

        public T Peek()
        {
            if (Count == 0)
            {
                throw new Exception("Стек пуст!");
            }

            return data[currentIndex - 1];

        }
        public List<T> Values()
        {

            List<T> result = new List<T>();
            for (int i = currentIndex - 1; i >= 0; i--)
            {
                result.Add(data[i]);
            }
            return result;

        }







    
}
}
