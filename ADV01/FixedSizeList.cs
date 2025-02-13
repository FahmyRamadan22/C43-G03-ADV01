using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV01
{
    internal class FixedSizeList<T> : IEnumerable<T>
    {
        public int Capacity { get; set; }
        public List<T> Values { get; set; }

        public T Current => throw new NotImplementedException();


        public FixedSizeList(int capacity)
        {
            Capacity = capacity;
            Values = new List<T>(capacity);
        }

        public void Add(T value)
        {
            if (Values.Count < Capacity)
                Values.Add(value);
            else
                throw new InvalidOperationException("You can't add new element, the list reached the maximum capacity");

        }

        public T GetValue(int index)
        {
            if (index < 0 || index >= Values.Count)
                throw new IndexOutOfRangeException("Index is out of range");

            return Values[index];
        }

        public IEnumerator<T> GetEnumerator()
        {
            return Values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    
    }

