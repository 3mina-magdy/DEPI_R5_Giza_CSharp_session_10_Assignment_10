using System;
using System.Collections.Generic;
using System.Text;

namespace session_10.Services
{
    public static class EvenNumbersFinder
    {
        public static List<int> GetEvenNumbers(List<int> numbers)
        {
            List<int> evenNumbers = new List<int>();

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenNumbers.Add(number);
                }
            }

            return evenNumbers;
        }
    }
}