using System;
using System.Collections.Generic;
using System.Text;

namespace session_10.Models
{
    public class FixedSizeList<T>
    {
        private readonly T[] items;
        private int count;

        public FixedSizeList(int capacity)
        {
            if (capacity <= 0)
            {
                throw new ArgumentException(
                    "Capacity must be greater than zero.");
            }

            items = new T[capacity];
            count = 0;
        }

        public void Add(T item)
        {
            if (count >= items.Length)
            {
                throw new InvalidOperationException(
                    "Cannot add more elements. The list is full.");
            }

            items[count] = item;
            count++;
        }

        public T Get(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException(
                    "Invalid index.");
            }

            return items[index];
        }
    }
}