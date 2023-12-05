using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyVecktorTask
{
    internal class MyVector<T>:IEnumerable
    {
        T[] _data;
        public int Capacity { get { return _data.Length; } }
        public int Size { get; private set; }
        public IEnumerator GetEnumerator()
        {
            return new MyVectorEnumerator(_data, Size);
        }
        class MyVectorEnumerator : IEnumerator
        {
            public object Current { get { return _data[index]; } }
            T[] _data;
            int _size;
            int index = -1;
            public MyVectorEnumerator(T[] data, int size)
            {
                _data = data;
                _size = size;
            }
            public bool MoveNext()
            {
                if (index + 1 == _size) return false;
                index++;
                return true;
            }

            public void Reset()
            {
                index = -1;
            }
        }
        public T this[int index]
        {
            get
            {
                if (Math.Abs( index) >= Size) throw new Exception("Не корректрный индекс");
                return _data[index];
            }
            set
            {
                if (Math.Abs(index) >= Size) throw new Exception("Не корректрный индекс");
                _data[index] = value;
            }
        }
        public MyVector(int leng,T initValue)
        {
            
            Size = leng;
            _data = new T[leng*2];
            for (int i = 0; i <  leng; i++)
            {
                _data[i] = initValue;
            }
        }
        public void Resize(int leng,T defValue)
        {   
            if (leng > Capacity)
            {
                Reserve(leng * 2);
            }
            for (int i = Size; i < leng; i++)
            {
                _data[i]=defValue;
            }
            Size = leng;

        }
        public void Reserve(int newcapacity)
        {
            if (newcapacity < Size)
            {
                throw new Exception("Физическая длина < вектора");
            }
            
            T[] newArray = new T[newcapacity];
            for (int i = 0; i < Size; i++)
            {
                newArray[i] = _data[i];
            }
            _data = newArray;
        }
        public void SetValue(int index, T value)
        {
            if (index >= Size)
            {
                throw new Exception("За пределами вектора");
            }
            _data[index] = value;
        }
        public void ShrinkToFit()
        {
            Reserve(Size);
        }
        public T At(int index)
        {
            if (index >= Size) { throw new Exception("За переделами вектора"); }
            return _data[index];
        }
        public void Add(T value)
        {
            if (Size +1 > Capacity)
            {
                Reserve((Size * 2)+2);
                _data[Size] = value;
            }
            _data[Size] = value;

                    
            Size++;
        }

    }
}
