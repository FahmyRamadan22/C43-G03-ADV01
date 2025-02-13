using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV01
{
    internal static class Helper
    {
        public static void PrintCollection(ICollection collection)
        {
            foreach (var item in collection)
                Console.Write(item + " ");

            Console.WriteLine();
        }

        public static void ReverseArray(ArrayList list)
        {
            int left = 0;
            int right = list.Count - 1;

            while (left < right)
            {
                object? temp = list[left]; 
                list[left] = list[right]; 
                list[right] = temp; 
                left++;
                right--;
            }
        }


        public static List<int> GetEvenNumbers(List<int> numbers)
        {
            List<int> evenNumbers = new List<int>();

            foreach (var number in numbers)
                if (number % 2 == 0)
                    evenNumbers.Add(number);

            return evenNumbers;
        }


        public static int FindFirstIndex(string input)
        {
            Dictionary<char, int> result = [];

            foreach (char c in input)
            {
                if (result.TryGetValue(c, out int value))
                    result[c] = ++value;
                else
                    result[c] = 1;

            }

            for (int i = 0; i < input.Length; i++)
                if (result[input[i]] == 1)
                    return i;

            return -1;



        }
    }
}

