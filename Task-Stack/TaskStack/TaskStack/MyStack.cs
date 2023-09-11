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
            if (currentIndex == Capacity)
            {
                throw new Exception("Стек заполнен!");
            }
            data[currentIndex] = val;
            currentIndex++;

        }

        public T Pop()
        {
            if (currentIndex == 0)
            {
                throw new Exception("Стек пуст!");
            }

            var item = data[currentIndex - 1];
            data[currentIndex - 1] = defaoultValue;
            currentIndex--;
            return item;


        }

        public T Peek()
        {
            if (currentIndex == 0)
            {
                throw new Exception("Стек пуст!");
            }

            return data[currentIndex - 1];

        }
        public T[] Values()
        {
            T[] values=new T[currentIndex];
            int c=0;
            for (int i = currentIndex - 1; i >= 0; i--)
            {
                values[c] = data[i];
                c++;
            }
            return values;

        }







    
}
}
