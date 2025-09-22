using System;
using System.Text;

namespace Topics
{
    class Person
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public int Age { set; get; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Control statements

            #region A] Conditional statement [If , Switch till c# 6]

            #region Example 1 [Numeric type : Equality] [Month in first quarter]
            //Console.WriteLine("Please enter a month number in first quarter");
            //int MonthNumber = int.Parse(Console.ReadLine());

            //if (MonthNumber == 1)
            //    Console.WriteLine("Jan");
            //else if (MonthNumber == 2)
            //    Console.WriteLine("Feb");
            //else if (MonthNumber == 3)
            //    Console.WriteLine("March");
            //else
            //    Console.WriteLine("Invalid month number in first quarter");
            //switch (MonthNumber)
            //{
            //    case 1:
            //        Console.WriteLine("Jan");
            //        break;
            //    case 2:
            //        Console.WriteLine("Feb");
            //        break;
            //    case 3:
            //        Console.WriteLine("March");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid month number in first quarter"); 
            //        break;
            //}


            #endregion

            #region Example 2 [Numeric type : less than or greater than] [Age of user]
            //Console.WriteLine("Please enter your age");
            //int.TryParse(Console.ReadLine(), out int age);
            //if(age > 22)
            //    Console.WriteLine("Your age is greater than 22");
            //else if (age < 22)
            //    Console.WriteLine("Your age is less than 22");
            //else
            //    Console.WriteLine("Your age is equal 22");

            //switch(age)
            //{
            //    case > 22:
            //        Console.WriteLine("Your age is greater than 22");
            //        break;
            //    case < 22:
            //        Console.WriteLine("Your age is less than 22");
            //        break;
            //    default:
            //        Console.WriteLine("Your age = 22");
            //        break;
            //}
            #endregion

            #region Example 3 [String type : equality] [Names of users]     
            //Console.WriteLine("Please enter your name");
            //string Name = Console.ReadLine();
            //if (Name == "Mariam")
            //    Console.WriteLine("Hello Mariam");
            //else if (Name == "Omar")
            //    Console.WriteLine("Hello Omar");
            //else if (Name == "Mohamed")
            //    Console.WriteLine("Hello Mohamed");
            //else if (Name == "Omnia")
            //    Console.WriteLine("Hello Omnia");
            //else if (Name == "Amira")
            //    Console.WriteLine("Hello Amira");
            //switch (Name)
            //{
            //    case "Mariam":
            //        Console.WriteLine("Hello Mariam");
            //        break;
            //    case "Omar":
            //        Console.WriteLine("Hello Omar");
            //        break;
            //    case "Mohamed":
            //        Console.WriteLine("Hello Mohamed");
            //        break;
            //    case "Omnia":
            //        Console.WriteLine("Hello Omnia");
            //        break;
            //    case "Amira":
            //        Console.WriteLine("Hello Amira");
            //        break;
            //}

            //https://stackoverflow.com/questions/395618/is-there-any-significant-difference-between-using-if-else-and-switch-case-in-c
            #endregion

            #region Example 4 [Goto] [Options]

            //Console.WriteLine("Please enter your salary [1000 , 2000 ,3000]");
            //int Salary = int.Parse(Console.ReadLine());
            //switch(Salary)
            //{
            //    case 3000:
            //        Console.WriteLine("option 3");
            //        //Console.WriteLine("option 2");
            //        //Console.WriteLine("option 1");
            //        goto case 2000;
            //    case 2000:
            //        Console.WriteLine("option 2");
            //        //Console.WriteLine("option 1");
            //        goto case 1000;
            //    case 1000:
            //        Console.WriteLine("option 1");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid option");
            //        break;
            //}
            #endregion
            #endregion

            #region Evolution of switch in c# 7.0

            //https://mihirdave95.medium.com/evaluation-of-switch-in-c-be587f7de47c
            #region Example 1 [Switch on any type ,when , &&  , ||]
            //object input;
            //4 bytes in stack 
            //0 bytes in heap
            // refer to null
            //input = new object();
            //new
            //1]Allocate number of bytes needed in the heap
            //2] Assign defualt value in heap [NULL]
            //3] Call user defined constructor if exist
            //4] Assign the refernce in stack to the obj in heap
            //input = 14; //Boxing
            // input = new Person() { Id = 100, Name = "Mariam" };
            // switch (input)
            // {
            //     case int localInput when localInput > 10 && localInput < 15:
            //         Console.WriteLine($"integer input ==> {localInput}");
            //         break;
            //     case double localInput:
            //         Console.WriteLine("double input");
            //         break;
            //     case Person localInput:
            //         Console.WriteLine("Person input");
            //         break;
            //     default:
            //         Console.WriteLine("UnKnown input");
            //         break;
            // }


            #endregion
            #endregion

            #region Evolution of switch in c# 8.0
            #region Example 1 [Switch expression]
            //Console.WriteLine("Please enter an option [1,2,3]");
            //string Option = Console.ReadLine();
            //string Message;
            //switch(Option)
            //{
            //    case "1":
            //        Message = "Option 1";
            //        break;
            //    case "2":
            //        Message = "Option 2";
            //        break;
            //    case "3":
            //        Message = "Option 3";
            //        break;
            //    default:
            //        Message = "Invalid option";
            //        break;
            //}
            //Message = Option switch
            //{
            //    "1" => "Option 1",
            //    "2" => "Option 2",
            //    "3" => "Option 3",
            //    _ => "Invalid Option"
            //};
            //Console.WriteLine(Message);
            #endregion

            #region Example 2 [Person]
            //Person person = new Person() { Id = 100, Name = "Mariam", Age = 23 };
            //switch (person)
            //{
            //    case { Id: 100, Name: "Mariam", Age: 23 }:
            //        Console.WriteLine("Your name is mariam and your age = 22");
            //        break;
            //    case { Age: 22 }:
            //        Console.WriteLine("Your age is 23");
            //        break;
            //    default:
            //        Console.WriteLine("Your name is 8arib");
            //        break;
            //}
            //string Message = person switch
            //{
            //    {Id : 100 , Name : "Mariam" , Age : 23 } => "Your name is mariam and your age 23",
            //    { Age : 23} => "Your age = 23",
            //    _ => "Your name is 8arib"
            //};
            //Console.WriteLine(Message);
            #endregion
            #endregion

            #region  Evolution of switch in c# 9.0
            #region Example 1  [Person < > , Switch exp]
            //Person person = new Person() { Id = 100, Name = "Mariam", Age = 23 };
            //switch (person)
            //{
            //    case { Id: 100, Name: "Mariam", Age: >23 and <40 }:
            //        Console.WriteLine("Your name is mariam and your age = 22");
            //        break;
            //    case { Age: 22 }:
            //        Console.WriteLine("Your age is 23");
            //        break;
            //    default:
            //        Console.WriteLine("Your name is 8arib");
            //        break;
            //}
            //string Message = person switch
            //{
            //    { Id: 100, Name: "Mariam", Age: >23 and < 40 } => "Your name is mariam and your age 23",
            //    { Age: 23 } => "Your age = 23",
            //    _ => "Your name is 8arib"
            //};
            //Console.WriteLine(Message);

            #endregion
            #endregion

            #region B] Loop statement [For , Foreach , Do-while , While]
            #region Example1 [Print]
            //Console.WriteLine(1+100);
            //Console.WriteLine(2+100);
            //Console.WriteLine(3+100);
            //Console.WriteLine(4+100);
            //Console.WriteLine(5+100);
            //Console.WriteLine(6+100);
            //Console.WriteLine(7+100);
            //Console.WriteLine(8+100);
            //Console.WriteLine(9+100);
            //Console.WriteLine(10+100);
            //Console.WriteLine("*****************************************");
            //for(int i = 100; i <= 110; i++)
            //{
            //    Console.WriteLine(i);
            //}







            #endregion

            #region Example2 [For , Foreach] [Array of numbers]
            //int[] Numbers = { 1, 2, 3, 4, 5 };
            //for(int i = 0; i < 5; i++)
            //{
            //    Numbers[i] += 10;
            //    Console.WriteLine(Numbers[i]);
            //}
            //Console.WriteLine("*******************************");
            //foreach(int number in Numbers)
            //{
            //    //number += 10; 
            //    Console.WriteLine(number);
            //}




            //https://medium.com/@musheikh47/optimized-looping-in-c-d7a96f74d55a

            #endregion

            #region Example3 [While , Do-While] [Even number]
            //int Number;
            ////bool flag;
            //do
            //{
            //    Console.WriteLine("Please enter an even number");
            //   // flag = int.TryParse(Console.ReadLine(),out Number);
            //} while (!(int.TryParse(Console.ReadLine(), out Number)) || Number % 2 == 1);
            //Console.WriteLine(Number);

            /*
             * SqlReader sqlReader = new SqlReader();
             * while (sqlReader.read())
             * {
             *  //Casting 
             * }
             * 
             */

            //int i = 0;
            //while (i < 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            #endregion
            #endregion

            #endregion

            #region String [Name [2]]
            ////String --> is a reference type [Class]
            ////Immutable
            ////Is an array of characters
            //string Name1;
            //Stack [4 bytes]
            //Heap  [0 Bytes]
            //Refernce refer to null
            //Name1 = new string("Mariam"); // 12 Bytes in heap
            //Name1 = "Mariam"; //Syntax sugar
            //Console.WriteLine(Name1);
            //Console.WriteLine(Name1.GetHashCode());
            //string Name2 = "Mariam";
            //Console.WriteLine(Name2);
            //Console.WriteLine(Name2.GetHashCode());

            #region Example 1
            //string Name1 = "Mariam";
            //string Name2 = "Amira";
            //Console.WriteLine(Name1);
            //Console.WriteLine(Name2);
            //Console.WriteLine(Name1.GetHashCode());
            //Console.WriteLine(Name2.GetHashCode());
            //Name2 = Name1;
            //Console.WriteLine("**************After = **************");
            //Console.WriteLine(Name1);
            //Console.WriteLine(Name2);
            //Console.WriteLine(Name1.GetHashCode());
            //Console.WriteLine(Name2.GetHashCode());
            //Name1 = "MariamYasser";
            //Console.WriteLine("**************After Changing Name1 **************");
            //Console.WriteLine(Name1);
            //Console.WriteLine(Name2);
            //Console.WriteLine(Name1.GetHashCode());
            //Console.WriteLine(Name2.GetHashCode());
            #endregion

            #region Example 2 [Message +=]
            //string Message = "Hello"; //Unreachable
            //Console.WriteLine(Message);
            //Console.WriteLine(Message.GetHashCode());
            //Console.WriteLine("**************After Change **************");
            //Message += " Mariam";
            //Console.WriteLine(Message);
            //Console.WriteLine(Message.GetHashCode());
            #endregion

            #endregion

            #region StringBuilder
            //StringBuilder --> is a reference type [Class]
            //Mutable
            //is a linkedList
            StringBuilder Name1 = new StringBuilder("Mariam");
            StringBuilder Name2 = new StringBuilder("Amira");
            //Name2.Append("Amira");
            //Console.WriteLine(Name1);
            //Console.WriteLine(Name2);
            //Console.WriteLine(Name1.GetHashCode());
            //Console.WriteLine(Name2.GetHashCode());
            //Console.WriteLine("******************************");
            //Name2 = Name1;
            //Console.WriteLine(Name1);
            //Console.WriteLine(Name2);
            //Console.WriteLine(Name1.GetHashCode());
            //Console.WriteLine(Name2.GetHashCode());
            //Console.WriteLine("******************************");
            //Name1.Append(" Yasser");
            //Console.WriteLine(Name1);
            //Console.WriteLine(Name2);
            //Console.WriteLine(Name1.GetHashCode());
            //Console.WriteLine(Name2.GetHashCode());

            #region Example 1



            //https://source.dot.net/#System.Private.CoreLib/src/libraries/System.Private.CoreLib/src/System/Text/StringBuilder.cs,adf60ee46ebd299f
            #endregion

            #region StringBuilderMethods
            // Name1.AppendLine(" Yasser");
            // Name1.Append("Hello");
            // //Console.WriteLine(Name1);
            // Name1.Insert(0, "Hello ");
            // Name1.Remove(0, 5);
            //// Console.WriteLine(Name1);
            // //Console.WriteLine("******************************");

            // Name1.Replace("Hello", "HelloNew");
            // //Console.WriteLine(Name1);

            // Name1.Clear();
            // Console.WriteLine(Name1);
            #endregion
            #endregion

            #region Arrays
            #region 1D Array
            #region Example 1 [Numbers]
            ////Array is a class [Refernce type]
            //int[] Numbers;
            //Refer to null
            //4 bytes in stack
            //0 bytes in heap
            //Numbers = new int[5];
            //Allocate number of bytes needed in heap 20bytes
            //Intialize with default value of its datatype [0]
            //Call user-defined consrtucor if exist
            //Refer from stack to heap[Refernce]
            //for(int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(Numbers[i]);
            //}
            //Numbers[0] = 10;
            //Numbers[1] = 20;
            //Numbers[2] = 30;
            //Numbers[3] = 40;
            //Numbers[4] = 50;
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(Numbers[i]);
            //}
            //int[] Numbers1 = new int[5] { 10, 20, 30, 40, 50 };
            //int[] Numbers2 = new int[] { 10, 20, 30, 40, 50 };
            //int[] Numbers3 = { 10, 20, 30, 40, 50 };
            //int[] Numbers4 = [1, 2, 3, 4]; 
            //int[] Numbers3;
            ////Numbers3 = { 10 , 20 , 30}; //Invalid
            //Console.WriteLine($"The length ==> {Numbers3.Length}");
            //Console.WriteLine($"The rank ==> {Numbers3.Rank}");
            //for (int i = 0; i < Numbers.Length ; i++)
            //{
            //    Console.WriteLine(Numbers3[i]);
            //}
            #endregion
            #endregion

            #region 2D Array -  Rectangular
            #region Example 1 [Marks]
            //int[,] Marks = new int[3, 5] /*{{1 , 2 , 3 , 4 , 5 } ,{6 , 7 , 8 , 9 , 1 } ,{2 , 3 , 4 , 5, 6  } }*/;
            //Console.WriteLine(Marks.Length);
            //Console.WriteLine(Marks.Rank);
            //Student number 1 [With index 0]
            //Marks[0,0] = 100;
            //Marks[0,1] = 99;
            //Marks[0,2] = 88;
            //Marks[0,3] = 99;
            //Marks[0,4] = 100;

            //Marks[1, 0] = 100;
            //Marks[1, 1] = 99;
            //Marks[1, 2] = 88;
            //Marks[1, 3] = 99;
            //Marks[1, 4] = 100;

            //Marks[2, 0] = 100;
            //Marks[2, 1] = 99;
            //Marks[2, 2] = 88;
            //Marks[2, 3] = 99;
            //Marks[2, 4] = 100;

            //bool flag;
            //int Grade;
            //for(int i = 0; i < Marks.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Please enter the grades for student number {i + 1}");
            //    for(int j = 0; j < Marks.GetLength(1); )
            //    {
            //        Console.WriteLine($"Please enter the grade for subject number {j + 1}");
            //        j = int.TryParse(Console.ReadLine(), out Grade) ? ++j : j;

            //    }
            //    Console.WriteLine("*********************************");
            //}
            #endregion
            #endregion
            #endregion
        }
    }
}