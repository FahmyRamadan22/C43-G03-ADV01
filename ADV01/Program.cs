using System.Collections;

namespace ADV01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Question01
            /*
             1.	Create a generic Range<T> class that represents a range of values from a minimum value to a maximum value. 
             The range should support basic operations such as checking if a value is within the range and determining the length of the range.
              Requirements:
                ●	Create a generic class named Range<T> where T represents the type of values.
                ●	Implement a constructor that takes the minimum and maximum values to define the range.
                ●	Implement a method IsInRange(T value) that returns true if the given  value is within the range, otherwise false.
                ●	Implement a method Length() that returns the length of the range (the difference between the maximum and minimum values).
                ●	Note: You can assume that the type T used in the Range<T> class implements the IComparable<T> interface to allow for comparisons.
             */

            //Range<int> range = new Range<int>(5, 10);

            //Console.WriteLine($"Is 7 in range ? {range.IsInRange(7)}");
            //Console.WriteLine($"Is 15 in range ? {range.IsInRange(15)}");

            //Console.WriteLine(range.GetLength());


            //Range<char> charRange = new Range<char>('a', 'z');

            //Console.WriteLine($"Is b in range ? {charRange.IsInRange('b')}");
            //Console.WriteLine($"Is A in range ? {charRange.IsInRange('A')}");


            //Console.WriteLine((int)charRange.GetLength());

            #endregion
            #region Question02

            //2.	You are given an ArrayList containing a sequence of elements. try to reverse the order of elements in the ArrayList in-place(in the same arrayList) without using the built-in Reverse. Implement a function that takes the ArrayList as input and modifies it to have the reversed order of elements.

            //ArrayList list = [10, 20, 30, 40, 50];

            //Console.WriteLine("Array Before Reverse");

            //Helper.PrintCollection(list);

            //Helper.ReverseArray(list);

            //Console.WriteLine("Array After Reverse");
            //Helper.PrintCollection(list);



            #endregion
            #region Question03
            //3.	You are given a list of integers. Your task is to find and return a new list containing only the even numbers from the given list.

            //List<int> numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

            //List<int> evenNumbers = Helper.GetEvenNumbers(numbers);

            //Helper.PrintCollection(evenNumbers);


            #endregion
            #region Question04
            /*
             4.	implement a custom list called FixedSizeList<T> with a predetermined capacity. This list should not allow more elements than its capacity and should provide clear messages if one tries to exceed it or access invalid indices.
              Requirements:
              ●	Create a generic class named FixedSizeList<T>.
              ●	Implement a constructor that takes the fixed capacity of the list as a parameter.
              ●	Implement an Add method that adds an element to the list, but throws an exception if the list is already full.
              ●	Implement a Get method that retrieves an element at a specific index in the list but throws an exception for invalid indices.
             */

            //FixedSizeList<int> list = new FixedSizeList<int>(5);
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);
            //list.Add(5);


            //foreach (var item in list)
            //    Console.WriteLine(item);

            //Console.WriteLine(list.GetValue(4));

            #endregion
            #region Question05

            // 5. Given a string, find the first non - repeated character in it and return its index.
            // If there is no such character, return -1.
            // Hint you can use dictionary

           
            
            //string input = "pprogramming"; 

            //Console.WriteLine($"First non-repeated charachter index = {Helper.FindFirstIndex(input)} ");

            //string input2 = "gg";
            //Console.WriteLine($"First non-repeated charachter index = {Helper.FindFirstIndex(input2)} ");


            #endregion
        }
    }
}
