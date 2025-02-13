using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ADV01
{
    internal class Range<T> where T : IComparable<T>, ISubtractionOperators<T, T, T>
    {

        public T Min { get; set; }
        public T Max { get; set; }
        public Range(T min, T max)
        {
            if (Max?.CompareTo(Min) < 0)
                throw new ArgumentException("Maximum value should be greater than minimum value");

            Min = min;
            Max = max;
        }

        public bool IsInRange(T value) => value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0;
        public T GetLength() => Max - Min;

    }
    

    }

