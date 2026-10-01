using System;
using System.Collections.Generic;
using System.Text;

namespace session_10.Models
{
    public class Range<T> where T : IComparable<T>
    {
        private readonly T minimum;
        private readonly T maximum;

        public Range(T minimum, T maximum)
        {
            if (minimum.CompareTo(maximum) > 0)
            {
                throw new ArgumentException(
                    "Minimum cannot be greater than maximum.");
            }

            this.minimum = minimum;
            this.maximum = maximum;
        }

        public bool IsInRange(T value)
        {
            return value.CompareTo(minimum) >= 0 &&
                   value.CompareTo(maximum) <= 0;
        }

        public T Length()
        {
            dynamic min = minimum;
            dynamic max = maximum;

            return max - min;
        }
    }
}