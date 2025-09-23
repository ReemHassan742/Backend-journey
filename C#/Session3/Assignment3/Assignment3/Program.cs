using System;
using System.Collections.Generic;
using System.ComponentModel;
namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            //Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            /*
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 3 == 0 && number % 4 == 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");



            }
            */
            #endregion

            #region Task 2
            //Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            /*
            Console.WriteLine("Enter an integer:");
            Double number = Convert.ToDouble(Console.ReadLine());
            if (number < 0)
            {
                Console.WriteLine("Negative");
            }
            else
            {
                Console.WriteLine("Positive");
            }
            */
            #endregion

            #region Task 3
            // Write a program that takes 3 integers from the user then prints the max element and the min element.
            /*
            Console.WriteLine("Enter first integer:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second integer:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third integer:");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 >= num2 && num1 >= num3)
            {
                Console.WriteLine("Max element is: " + num1);
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                Console.WriteLine("Max element is: " + num2);
            }
            else
            {
                Console.WriteLine("Max element is: " + num3);
            }
            */
            #endregion

            #region Task 4
            //Write a program that allows the user to insert an integer number then check If a number is even or odd.
            /*
            Console.WriteLine("Enter an integer number:");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine(number + " is even");
            }
            else
            {
                Console.WriteLine(number + " is odd");
            }
            */
            #endregion

            #region Task 5
            //Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
            /*
            Console.WriteLine("Enter a character:");
            char character = Convert.ToChar(Console.ReadLine().ToLower());
            if (character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u')
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Consonant");
            }
            */
            #endregion

            #region Task 6
            //Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            /*
            Console.WriteLine("Enter an Inger number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= num1; i++)
            {
                Console.WriteLine(i);
            }
            */
            #endregion

            #region Task 7
            // Write a program that allows the user to insert an integer then print a multiplication table up to 12.
            /*
            Console.WriteLine("Enter an integer number:");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine(number + " * " + i + " = " + (number * i));
            }
            */
            #endregion

            #region Task 8
            //Write a program that allows to user to insert number then print all even numbers between 1 to this number
            /*
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            */
            #endregion

            #region Task 9
            // Write a program that takes two integers then prints the power.
            /*
            Console.WriteLine("Enter the first number: ");
            double num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            double num2 = Convert.ToInt32(Console.ReadLine());
            double result = Math.Pow(num1, num2);
            Console.WriteLine("result = " + result);
            */
            #endregion

            #region Task 10
            //Write a program to enter marks of five subjects and calculate total, average and percentage.
            /*
            int total = 0;
            double average = 0;
            double percentage = 0;
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Enter marks of subject " + i + ":");
                int marks = Convert.ToInt32(Console.ReadLine());
                total = marks * 5;
                average = total / 5.0;
                percentage = (total / 500.0) * 100;
            }
            Console.WriteLine("Total marks = " + total);
            Console.WriteLine("Average = " + average);
            Console.WriteLine("Percentage = " + percentage + "%");
            */
            #endregion

            #region Task 11
            // Write a program to input the month number and print the number of days in that month.
            /*
            Console.WriteLine("Enter month number:");
            int month = Convert.ToInt32(Console.ReadLine());
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("31 days");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("30 days");
                    break;
                case 2:
                    Console.WriteLine("28 or 29 days");
                    break;
                default:
                    Console.WriteLine("Invalid month number");
                    break;
            }
            */
            #endregion

            #region Task 12
            // Write a program to create a Simple Calculator.
            /*
            Console.WriteLine("Enter first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter an operator (+, -, *, /): ");
            string op = Console.ReadLine();
            double result;
            
            if (op == "+")
            {
                result = num1 + num2;
                Console.WriteLine("Result: " + result);
            }
            else if (op == "-")
            {
                result = num1 - num2;
                Console.WriteLine("Result: " + result);
            }
            else if (op == "*")
            {
                result = num1 * num2;
                Console.WriteLine("Result: " + result);
            }
            else if (op == "/")
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    Console.WriteLine("Result: " + result);
                }
                else
                {
                    Console.WriteLine("Error: Division by zero");
                }
            }
            else
            {
                Console.WriteLine("Invalid operator");
            }
            */
            #endregion

            #region Task 13
            //Write a program to allow the user to enter a string and print the REVERSE of it.
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            string reversed = new string(charArray);

            Console.WriteLine($"Reversed string: {reversed}");
            #endregion
        }
    }
}
