using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Arrays
            #region Task 1
            // Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            /*
            int[] array1 = { 1, 3, 5, 7 };
            int[] array2 = { 2, 4, 6, 8 };
            
            Console.WriteLine("Merging two sorted arrays:");
            Console.WriteLine("Array 1" + string.Join(", ", array1));
            Console.WriteLine("Array 2" + string.Join(", ", array2));

            int[] mergedArray = MergeSortedArrays(array1, array2);

            Console.WriteLine("Merged Array: " + string.Join(", ", mergedArray));

            static int[] MergeSortedArrays(int[] arr1 , int[] arr2)
            {
                int[] merged = new int[arr1.Length + arr2.Length];

                int i = 0, j = 0, k = 0; //Pointers for arr1, arr2 and merged array
                while (i < arr1.Length && j < arr2.Length)
                {
                    if (arr1[i] < arr2[j])
                    {
                        merged[k++] = arr1[i++];
                    }
                    else
                    {
                        merged[k++] = arr2[j++];
                    }
                }

                while (i < arr1.Length)
                {
                    merged[k++] = arr1[i++];
                }
                while (j < arr2.Length)
                {
                    merged[k++] = arr2[j++];
                }
                return merged;
            }
            */
            #endregion

            #region Task 2
            //Write a program in C# Sharp to count the frequency of each element of an array.
            /*
            int[] arr = { 1, 2, 2, 3, 4, 4, 4, 5 };

            Console.WriteLine("Element Frequency Counter");
            Console.WriteLine("Original Array: " + string.Join(", ", arr));
            Console.WriteLine("\nElement Frequencies:");
            CountFrequency(arr);


            static void CountFrequency(int[] arr)
            {
                bool[] visited = new bool[arr.Length];

                for (int i = 0; i < arr.Length; i++)
                {
                    if (visited[i]) continue;

                    int count = 1;
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            count++;
                            visited[j] = true;
                        }
                    }

                    Console.WriteLine($"Element {arr[i]} appears {count} time(s)");
                    visited[i] = true;
                }
            }
            */
            #endregion

            #region Task 3
            //Write a program in C# Sharp to find maximum and minimum element in an array
            /*
            int[] arr = { 3, 5, 1, 8, -2, 7 };
            int max = 0;
            int min = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("Array: " + string.Join(", ", arr));
            Console.WriteLine($"Maximum Element: {max}");
            Console.WriteLine($"Minimum Element: {min}");
            */
            #endregion

            #region Task 4
            //Write a program in C# Sharp to find the second largest element in an array.
            /*
            int[] arr = { 3, 5, 1, 8, -2, 7 };
            Array.Sort(arr);
            Console.WriteLine("Array: " + string.Join(", ", arr));
            Console.WriteLine($"Second Largest Element: {arr[^2]}");
            */
            #endregion

            #region Task 5
            /*
             * Consider an Array of Integer values with size N, having values as in this Example
             * write a program find the longest distance between Two equal cells. In this example. The distance is measured by the number Of cells- for example, the distance between the first and the fourth cell is 2 (cell 2 and cell 3).
             * In the example above, the longest distance is between the first 7 and the 10th 7, with a distance of 8 cells, i.e. the number of cells between the 1st 
             * And the 10th 7s.
             * Note:
             * - Array values will be taken from the use
             * - If you have input like 1111111 then the distance is the number of
             * Cells between the first and the last cell.
             */

            /*
            Console.WriteLine("Enter the size of the array:");
            int size = int.Parse(Console.ReadLine());

            if (size < 2) {
                Console.WriteLine("Array size should be at least 2 to find a distance.");
                return;
            }

            int[] arr = new int[size];
            Console.WriteLine($"Enter {size} integer values (space-separated):");

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element {i + 1}:");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Array: " + string.Join(", ", arr));

            int maxDistance = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = arr.Length - 1; j > i; j--)
                {
                    if (arr[i] == arr[j])
                    {
                        int distance = j - i - 1; 
                        if (distance > maxDistance)
                        {
                            maxDistance = distance;
                        }
                        break; 
                    }
                }
            }
            if (maxDistance != -1)
            {
                Console.WriteLine($"The longest distance between two equal cells is: {maxDistance}");
            }
            else
            {
                Console.WriteLine("No equal cells found in the array.");
            }
            
            */
            #endregion

            #region Task 6
            /*
             * 6- Given a list of space separated words, reverse the order of the words.
             * Input: this is a test		Output: test a is this
             * Input: all your base		Output: base your all
             * Input: Word			Output: Word
             * Note : 
             * Check the Split Function (Member in String Class) Output will be a Single Console.WriteLine Statement
             */

            /*
             String sentence = "this is a test";
             string[] words = sentence.Split(' ');
             Array.Reverse(words);
             Console.WriteLine(string.Join(" ", words));
            */
            #endregion

            #region Task 7
            //Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.
            /*
            Console.Write("Enter number of rows: ");
            int rows = int.Parse(Console.ReadLine());

            int[][] firstArray = new int[rows][];
            int[][] secondArray = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                Console.Write($"Enter number of columns for row {i}: ");
                int cols = int.Parse(Console.ReadLine());
                firstArray[i] = new int[cols];
                secondArray[i] = new int[cols];
            }

            Console.WriteLine("\nEnter elements:");
            for (int i = 0; i < firstArray.Length; i++)
            {
                for (int j = 0; j < firstArray[i].Length; j++)
                {
                    Console.Write($"Element [{i},{j}]: ");
                    firstArray[i][j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < firstArray.Length; i++)
            {
                for (int j = 0; j < firstArray[i].Length; j++)
                {
                    secondArray[i][j] = firstArray[i][j];
                }
            }

            Console.WriteLine("\nSecond Array:");
            for (int i = 0; i < secondArray.Length; i++)
            {
                for (int j = 0; j < secondArray[i].Length; j++)
                {
                    Console.Write(secondArray[i][j] + " ");
                }
                Console.WriteLine();
            }
            */

            #endregion

            #region Task 8
            //Write a Program to Print One Dimensional Array in Reverse Order
            /*
            int[] arr = { 1, 2, 3, 4, 5 };
            Array.Reverse(arr);

            Console.Write("Reversed Array: ");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            */
            #endregion

            #endregion

            #region Functions
            #region Task 1,2
            //Explain the difference between passing(Value type parameters) by value and by reference then write a suitable c# example.
            //Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.
            /*
            int number = 5;
            // Value type variable
            Console.WriteLine($"Before PassByValue: {number}");
            PassByValue(number);
            Console.WriteLine($"After PassByValue: {number}");
            Console.WriteLine();

            // Reference type variable
            Console.WriteLine("Before PassByReference: " + number);
            PassByReference(ref number);
            Console.WriteLine("After PassByReference: " + number);


            static void PassByValue(int x)
            {
                x = 10;
                Console.WriteLine($"Inside PassByValue: {x}");
            }
            static void PassByReference(ref int x)
            {
                x = 20;
                Console.WriteLine($"Inside PassByReference: {x}");
            }
            */

            #endregion

            #region Task 3
            //Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
            /*
            Console.WriteLine("Enter four integers:");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());
            SumAndSubtract(num1, num2, num3, num4, out int sum, out int difference);
            static void SumAndSubtract(int num1, int num2, int num3, int num4, out int sum, out int difference)
            {
                sum = num1 + num2;
                difference = num3 - num4;
            }
            Console.WriteLine($"Sum of first two numbers: {sum}");
            Console.WriteLine($"Difference of last two numbers: {difference}");
            */
            #endregion

            #region Task 4
            //Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
            //Enter a number: 25   ==> The sum of the digits of the number 25 is: 7
            /*
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            static int SumOfDigits(int number)
            {
                int sum = 0;
                while (number != 0)
                {
                    sum += number % 10;
                    number /= 10;
                }
                return sum;
            }
            Console.WriteLine($"The sum of the digits of the number {number} is: {SumOfDigits(number)}");
            */
            #endregion

            #region Task 5
            //Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:
            /*
            int[] testNumbers = { -5, 0, 1, 2, 3, 4, 5, 9, 11, 15, 17, 25, 29 };

            foreach (int num in testNumbers)
            {
                Console.WriteLine($"{num} => {IsPrime(num)}");
            }


             static bool IsPrime(int number)
             {
               if (number <= 1) return false;
               if (number == 2) return true;
               if (number % 2 == 0) return false;

               for (int i = 3; i <= number / 2; i += 2)
               {
                  if (number % i == 0)
                      return false;
                }

               return true;
             }
            */
            #endregion

            #region Task 6
            //Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
            /*
            int[] arr = { 3, 5, 1, 8, -2, 7 };
            Console.WriteLine($"Array: {string.Join(",", arr)}");
            int min = 0 , max = 0;
            MinMaxArray(arr, ref min, ref max);
            Console.WriteLine($"Minimum: {min}, Maximum: {max}");

            static void MinMaxArray(int[] arr, ref int min , ref int max)
            {
                min = arr[0];
                max = arr[1];
                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i] < min)
                    {
                        min = arr[i];
                    }
                    if (arr[i] > max)
                    {
                        max = arr[i];
                    }
                }
                
            }
            */

            #endregion

            #region Task 7
            //Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter
            /*
            int factorialNumber = 5;
            Console.WriteLine(Factorial(factorialNumber));

            static int Factorial(int n)
                            {
                if (n < 0) return -1; // Factorial not defined for negative numbers
                int result = 1;
                for (int i = 2; i <= n; i++) 
                {
                    result *= i;
                }
                return result;
            }
            */
            #endregion

            #region Task 8
            //Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter
            
            #endregion
            #endregion
        }
    }
}