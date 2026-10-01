using System.Collections;
using session_10.Models;
using session_10.Services;

namespace session_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ==========================================
            // 1. Optimized Bubble Sort
            // ==========================================

            int[] numbers = { 5, 3, 8, 4, 2 };

            BubbleSort.Sort(numbers);

            Console.WriteLine("1. Optimized Bubble Sort:");

            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
            Console.WriteLine();


            // ==========================================
            // 2. Generic Range<T>
            // ==========================================

            Range<int> range = new Range<int>(10, 20);

            Console.WriteLine("2. Generic Range:");

            Console.WriteLine(
                $"15 in range: {range.IsInRange(15)}");

            Console.WriteLine(
                $"25 in range: {range.IsInRange(25)}");

            Console.WriteLine(
                $"Length: {range.Length()}");

            Console.WriteLine();


            // ==========================================
            // 3. Reverse ArrayList
            // ==========================================

            ArrayList list = new ArrayList
            {
                1,
                2,
                3,
                4,
                5
            };

            ArrayListReverser.Reverse(list);

            Console.WriteLine("3. Reversed ArrayList:");

            foreach (object item in list)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.WriteLine();


            // ==========================================
            // 4. Find Even Numbers
            // ==========================================

            List<int> inputNumbers = new List<int>
            {
                1, 2, 3, 4, 5, 6, 7, 8
            };

            List<int> evenNumbers =
                EvenNumbersFinder.GetEvenNumbers(inputNumbers);

            Console.WriteLine("4. Even Numbers:");

            foreach (int number in evenNumbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
            Console.WriteLine();


            // ==========================================
            // 5. FixedSizeList<T>
            // ==========================================

            FixedSizeList<string> fixedList =
                new FixedSizeList<string>(3);

            fixedList.Add("Mina");
            fixedList.Add("Ahmed");
            fixedList.Add("Mohamed");

            Console.WriteLine("5. FixedSizeList:");

            Console.WriteLine(fixedList.Get(0));
            Console.WriteLine(fixedList.Get(1));
            Console.WriteLine(fixedList.Get(2));

            Console.WriteLine();


            // ==========================================
            // 6. First Non-Repeated Character
            // ==========================================

            string text = "swiss";

            int index =
                FirstNonRepeatedCharacter.Find(text);

            Console.WriteLine(
                "6. First Non-Repeated Character:");

            Console.WriteLine($"Text: {text}");
            Console.WriteLine($"Index: {index}");
        }
    }
}