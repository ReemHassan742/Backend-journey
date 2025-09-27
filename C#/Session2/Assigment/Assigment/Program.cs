using System;
namespace Assigment
{

    class Program {
        class Person
        {
            public string Name;
        }
        static void Main(string[] args)
        {
            #region Task 1 
            //Write a program that allows the user to enter a number then print it.
            //Console.WriteLine("Enter a number:");
            //int number = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("You entered: " + number);
            #endregion

            #region Task 2
            //Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen
            string Example = "123abc";
            Console.WriteLine(Example);
            //int num = Convert.ToInt32(str); // This will throw a FormatException
            #endregion

            #region Task 3
            //Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen
            //float Number1 = 5.5f;
            //float Number2 = 2.2f;
            //float Result = Number1 + Number2;
            //Console.WriteLine(Result); // This will work fine and print 7.7

            #endregion

            #region Task 4
            //Write C# program that Extract a substring from a given string.
            //string str = "Hello, World!";
            //string SubString = str.Substring(7, 5);
            // Console.WriteLine(SubString); 
            #endregion

            #region Task 5
            //Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            int a = 10;
            int b = a; // b is now 10
            b = 20; // Changing b to 20
            Console.WriteLine(b);
            #endregion

            #region Task 6
            //Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
            Person person1 = new Person();
            person1.Name = "Alice";
            Person person2 = person1; // person2 references the same object as person1
            person2.Name = "Bob"; // Changing the Name property through person2
            Console.WriteLine(person2.Name);
            Console.WriteLine(person1.Name);

            #endregion

            #region Task 7
            //Write C# program that take two string variables and print them as one variable 
            //string str1 = "Hello, ";
            //string str2 = "World!";
            //string combined = str1 + str2;
            //Console.WriteLine(combined);
            #endregion

            #region Task 8
            //Write a program that calculates the simple interest given the principal amount, rate of interest, and time. The formula for simple interest is Interest = (principal * rate * time) / 100.

            //Console.WriteLine("Enter principal amount:");
            // Double principal = Convert.ToDouble(Console.ReadLine());


            //Console.WriteLine("Enter rate of interest:");
            //Double rate = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter time in years:");
            // Double time = Convert.ToDouble(Console.ReadLine());
            //Double interest = (principal * rate * time) / 100;
            // Console.WriteLine("Simple Interest: " + interest);
            #endregion

            #region Task 9
            //Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms and height in meters. The formula for BMI is BMI = (Weight) / (Height * Height)

            //Console.WriteLine("Enter weight in kilograms:");
            //Double weight = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter height in meters:");
            //Double height = Convert.ToDouble(Console.ReadLine());

            //Double bmi = weight / (height * height);
            //Console.WriteLine("Body Mass Index (BMI): " + bmi);
            #endregion

            #region Task 10
            /*
             * Write a program that takes the date from the user and displays it in various formats using string interpolation.
                Ex :
                Today’s date : 20 , 11 , 2001
                Today's date : 20 / 11 / 2001
                Today's date : 20 – 11 – 2001

             */

            /* int day = 0, month = 0, year = 0;

            bool validInput = false;
            while (!validInput)
            {
                Console.Write("Enter day (1-31): ");
                if (int.TryParse(Console.ReadLine(), out day) && day >= 1 && day <= 31)
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid day! Please enter between 1-31.");
                }
            }

            validInput = false;
            while (!validInput)
            {
                Console.Write("Enter month (1-12): ");
                if (int.TryParse(Console.ReadLine(), out month) && month >= 1 && month <= 12)
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid month! Please enter between 1-12.");
                }
            }

            validInput = false;
            while (!validInput)
            {
                Console.Write("Enter year: ");
                if (int.TryParse(Console.ReadLine(), out year) && year > 0)
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid year! Please enter a positive number.");
                }
            }

            Console.WriteLine("\nToday's date in different formats:");
            Console.WriteLine("==================================");
            Console.WriteLine($"Today's date : {day} , {month} , {year}");
            Console.WriteLine($"Today's date : {day} / {month} / {year}");
            Console.WriteLine($"Today's date : {day} - {month} - {year}");
            */
            #endregion

            #region Task 11,12,13
            /*
             What is the output of the following C# code?

              DateTime date = new DateTime(2024, 6, 14); Console.WriteLine($"The event is on {date:MM/dd/yyyy}");
              
              The event is on 14/06/2024
              The event is on 2024-06-14
              The event is on 06/14/2024  ==> The answer
              The event is on June 14, 2024

              
            Which of the following statements is correct about the C#.NET code snippet given below?

            int d; 
            d = Convert.ToInt32( !(30 < 20) );


            A value 0 will be assigned to d.
            A value 1 will be assigned to d.  ==> The answer
            A value -1 will be assigned to d.
            The code reports an error.
            The code snippet will work correctly if ! is replaced by Not.


            Which of the following is the correct output for the C# code given below?


            Console.WriteLine(13 / 2 + " " + 13 % 2); 


            6.5 1
            6.5 0
            6 0 
            6 1    ==> The answer
            6.5 6.5
             */
            #endregion
        }
    }

}