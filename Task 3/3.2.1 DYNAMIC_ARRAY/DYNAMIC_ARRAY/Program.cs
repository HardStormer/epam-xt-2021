using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DYNAMIC_ARRAY
{
    class program
    {
        static void Main(string[] args)
        {
        }
    }
    internal class DynamicArray<T> : IEnumerable, IEnumerable<T>
    {
        
        #region Конструктор без параметров (создаётся массив ёмкостью 8 элементов).
        public DynamicArray()
        {
            Capacity = 8;
            MyArray = new T[Capacity];
        }
        #endregion
        #region Конструктор с одним целочисленным параметром (создаётся массив указанной ёмкости).
        public DynamicArray(int capacity)
        {
            this.Capacity = capacity;
            MyArray = new T[capacity];
        }
        #endregion
        public DynamicArray(IEnumerable<T> collection)
        {
            int count = collection.Count();
            MyArray = new T[count];
            int k = 0;
            foreach (var i in collection)
            {
                MyArray[k] = i;
                k++;
            }
        }
        public void Add(T what)
        {
            if (Length == Capacity)
            {
                Capacity *= 2;
            }

            MyArray[Length++] = what;
        }


        public void AddRange(IEnumerable<T> ts)
        {
            int count = ts.Count();
            while (Length + count > Capacity)
            {
                Capacity *= 2;
            }
            int k = Length;
            foreach (var i in ts)
            {
                MyArray[k] = i;
                k++;
            }
            Length += count;
        }



        public void RemoveAt(int index)
        {
            if (index > Length)
            {
                throw new ArgumentException("The specified index is larger than the list size");
            }
            else if (index >= 0)
            {
                Array.Copy(MyArray, index + 1, MyArray, index, Length - index);
            }
            else
            {
                Array.Copy(MyArray, Length + index + 1, MyArray, Length + index, -index);
            }

            Length--;
        }

        public bool Remove(T item)
        {
            for (int i = 0; i < Length; i++)
            {
                if (MyArray[i].Equals(item))
                {
                    RemoveAt(i);
                    return true;
                }
            }

            return false;
        }

        public bool Insert(T item, int index)
        {

            if (Length + 1 > Capacity)
            {
                Capacity *= 2;
            }

            if (index >= 0)
            {
                for (int i = Length; i > index; i--)
                {
                    MyArray[i] = MyArray[i - 1];
                }

                MyArray[index] = item;
            }
            else
            {
                for (int i = Length; i > Length + index; i--)
                {
                    MyArray[i] = MyArray[i - 1];
                }

                MyArray[Length + index] = item;
            }

            Length++;
            return true;
        }

        public IEnumerator GetEnumerator()
        {
            return MyArray.GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return ((IEnumerable<T>)MyArray).GetEnumerator();
        }

        public int Capacity { get; set; }
        public int Length { get; set; }
        private T[] MyArray { get; set; }

        public T this[int index]
        {
            get
            {
                if ((index < 0) || (index >= Length))
                {
                    throw new ArgumentOutOfRangeException();
                }

                return MyArray[index];

            }
            set
            {
                if ((index < 0) || (index >= Length))
                {
                    throw new ArgumentOutOfRangeException();
                }

                MyArray[index] = value;

            }
        }
    }
}
