using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQuereTask
{
    internal class MyQueue<T>
    {
        public int Capacity { get; private set; }
        public int Count { get; private set; }
        T[] data;
        
        public MyQueue(int size)
        {
            Capacity = size;
            data = new T[Capacity];
        }
        int indexOut;
        int indexIn;
        public void Enqueue(T value)
        {
            if (Count == Capacity)
            {
                throw new Exception("Заполнено");
            }
            if (indexIn == Capacity && Count < Capacity)
            {
                indexIn = 0;
            }
            data[indexIn] = value;
            indexIn++;
            Count++;
        }
        public T Peek()
        {
            if (Count == 0)
            {
                throw new Exception("Пусто!");
            }

            return data[indexOut];
        }
        public T Dequeue()
        {
            if (Count == 0)
            {
                throw new Exception("Пусто!");
            }
            var value = data[indexOut];
            data[indexOut] = default(T);
            indexOut++;
            Count--;
            if (indexOut == Capacity) { indexOut = 0; }
            return value;
        }
        public T[] Values()
        {
            T[] values = new T[Count];
            int index = 0;
            if (Count == 0)
            {
                indexOut = 0;
                indexIn = 0;
            }
            else
            {
                if (indexOut < indexIn)
                {
                    for (int i = indexOut; i < indexIn; i++)
                    {
                        values[index] = data[i];
                        index++;
                    }
                }
                else
                {
                    for (int i = indexOut; i < Capacity; i++)
                    {
                        values[index] = data[i];
                        index++;
                    }
                    for (int i = 0; i < indexIn; i++)
                    {
                        values[index] = data[i];
                        index++;
                    }
                }
            }
            return values;

        }
    }
}
