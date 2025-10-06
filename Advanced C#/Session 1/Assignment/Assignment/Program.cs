using Assignment.Generics;
using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;

namespace Assigment
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            //The Bubble Sort algorithm has a time complexity of O(n^2) in its worst and average cases, which makes it inefficient for large datasets. How we can optimise the Bubble Sort algorithm And implement the code of this optimised bubble sort algorithm
            /*
            int[] intArray = { 4, 5, 8, 34, 6, 53, 7 };
            Console.WriteLine("Original Integers: " + String.Join(",", intArray));
            BubbleSort.GenericBubbleSort(intArray);
            Console.WriteLine("Sorted Integers: " + String.Join(",", intArray));
            */

            #endregion

            #region Task 2
            /*
             Create a generic Range<T> class that represents a range of values from a minimum value to a maximum value. The range should support basic operations such as checking if a value is within the range and determining the length of the range.
              Requirements:
                Create a generic class named Range<T> where T represents the type of values.
                Implement a constructor that takes the minimum and maximum values to define the range.
                Implement a method IsInRange(T value) that returns true if the given  value is within the range, otherwise false.
                Implement a method Length() that returns the length of the range (the difference between the maximum and minimum values).
                Note: You can assume that the type T used in the Range<T> class implements the IComparable<T> interface to allow for comparisons.

             */
            var intRange = new RangeGenerics<int>(10, 20);
            Console.WriteLine(intRange.IsInRange(15)); 
            Console.WriteLine(intRange.Length());      

            var doubleRange = new RangeGenerics<double>(2.5, 7.5);
            Console.WriteLine(doubleRange.IsInRange(8.1)); 
            Console.WriteLine(doubleRange.Length());       




            #endregion

        }
    }
}