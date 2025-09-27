using System.Drawing;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Variables

            //int UserId;
            //UserId = 1;
            //Console.WriteLine(UserId);

            #endregion

            #region  Value type & Reference type
            #region Value type
            //int x;
            ////CLR WILL ALLOCATE 4 BYTES IN STACK [UNINITIALIZED]
            ////int --> C# KEYWORD
            //x = 5;
            ////CLR WILL ASSIGN VALUE 5 TO X
            //Int32 y;
            //y = x; //5
            ////Copy from x value
            //x++;
            //Console.WriteLine(x);
            //Console.WriteLine(y);

            #endregion

            #region Refernce type
            //Point p1;
            ////CLR WILL ALLOCATE 4 BYTES IN STACK
            ////CLR WILL ALLOCATE 0 BYTES IN HEAP
            //p1 = new Point();
            //// new 
            //// Allocate the number of bytes needed for the object in the heap
            //// Intialize with the default values of its datatypes
            //// Call user defined constructor [if exist]
            //// Set reference to the obj
            //Console.WriteLine(p1.x);
            //Console.WriteLine(p1.y);
            //Point p2 = new Point(); //Unreachable obj
            //p2 = p1;
            //p1.x = 10;
            //Console.WriteLine(p2.x);
            #endregion

            #endregion

            #region Object
            Point p1 = new Point();
            //p1.x = 10;
            //p1.y = 20;
            //Console.Write(p1.ToString()); 
            Point p2 = new Point();
            p2 = p1;
            //Console.WriteLine(p1.GetHashCode());
            //Console.WriteLine(p2.GetHashCode());
            //Console.WriteLine(p1.Equals(p2));

            //Console.WriteLine(p1.GetType().FullName) ; //SessionTwo.Point
            object obj;
            obj = new object();
            obj = "Mariam";
            obj = 10;
            obj = true;
            obj = 'A';
            string myName = "Mariam"; //Syntax sugar 
            string MyName = new string("Mariam");
            obj = 10;
            int x = (int)obj;
            int z = 10;
            #endregion

            #region Fraction & Discard
            //double Num = 31.2131313;
            //float Num2 = 21.3223f;
            //decimal Num3 = 21.219219m;

            //long Num4 = 1000_000_000;
            //Console.WriteLine(Num4);
            #endregion

            #region Implicit casting & Explicit casting 
            #region Implicit casting [Safe]
            //int num1 = 100;
            //long num2;
            //num2 =num1;
            //Console.WriteLine(num2);
            #endregion
            #region Explicit casting & checked block [Unsafe]
            //long num = 1000320000023232393;
            //int num2;
            //checked
            //{
            //    num2 = (int)num;
            //    unchecked
            //    {
            //        Console.WriteLine(num2);

            //    }
            //}

            #endregion
            #region Implicit casting & explicit casting int , double
            //int num1 = 10;
            //double num2 = num1;
            //Console.WriteLine(num2); //safe casting 

            //double num1 = 10.232;
            //int num2 =  (int)num1;
            //Console.WriteLine(num2);

            #endregion
            #endregion

            #region Convert & Parse
            #region Convert
            // Convert --> is a class containg set of methods used for converting from datatype to another
            // Example : Read name , age , salary from user 
            //Console.WriteLine("Please enter your name");
            //string MyFullName = Console.ReadLine();
            //Console.WriteLine("Please enter your age");
            //int Age =Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter your salary");
            //double Salary =Convert.ToDouble(Console.ReadLine());
            //Console.Clear();
            //Console.Beep(234, 500);
            //Console.WriteLine("Name " + MyFullName);
            //Console.WriteLine("Age " + Age);
            //Console.WriteLine("Salary " + Salary);


            #endregion

            #region Parse
            // Parse --> is a method used for casting from string to the caller dataType
            //Console.WriteLine("Please enter your name");
            //string MyFullName = Console.ReadLine();
            //Console.WriteLine("Please enter your age");
            //int Age = int.Parse(Console.ReadLine());    
            //Console.WriteLine("Please enter your salary");
            //double Salary = double.Parse(Console.ReadLine());
            //Console.Clear();
            //Console.Beep(234, 500);
            //Console.WriteLine("Name " + MyFullName);
            //Console.WriteLine("Age " + Age);
            //Console.WriteLine("Salary " + Salary);
            #endregion
            #endregion

            #region TryParse
            // string y = "10";
            // y = "Mariam";
            // int num;
            // bool flag = int.TryParse(y, out int num);
            // Console.WriteLine(flag);
            // Console.WriteLine(num);
            #endregion

            #region Operators
            #region Unary Operators
            //// Unary --> works on one variable , one operand 
            //int X = 10;
            //// 1] ++
            //Console.WriteLine("Initial Value: " + X); // 10
            //Console.WriteLine("++X: " + ++X); // 11 [Prefix increment]
            //Console.WriteLine("X++: " + X++); // 11 [Postfix increment]
            //Console.WriteLine("Final Value: " + X); // 12

            //2] --
            //int Y = 10;
            //Console.WriteLine("Initial Value: " + Y); // 10
            //Console.WriteLine("--Y: " + --Y);         // 9  [Prefix decrement]
            //Console.WriteLine("Y--: " + Y--);         // 9  [Postfix decrement]
            //Console.WriteLine("Final Value: " + Y);   // 8
            #endregion

            #region Binary Operators 
            //Binary operators --> between 2 operands / 2 variables
            //int a = 10, b = 5;
            //Console.WriteLine("Addition: " + (a + b));          // 15
            //Console.WriteLine("Subtraction: " + (a - b));      // 5
            //Console.WriteLine("Multiplication: " + (a * b));  // 50
            //Console.WriteLine("Division: " + (a / b));       // 2
            //Console.WriteLine("Modulus: " + (a % 3));       // 1
            #endregion

            #region Assignment Operators
            //int a = 5;

            //// 1. Simple Assignment 
            //a = 10;
            //Console.WriteLine("Simple Assignment: " + a); // 10

            //// 2. Add and Assign [a = a + 5]
            //a += 5;
            //Console.WriteLine("Add and Assign (a += 5): " + a); // 15

            //// 3. Subtract and Assign [a = a - 3]
            //a -= 3;
            //Console.WriteLine("Subtract and Assign (a -= 3): " + a); // 12

            //// 4. Multiply and Assign [a = a * 2]
            //a *= 2;
            //Console.WriteLine("Multiply and Assign (a *= 2): " + a); // 24

            //// 5. Divide and Assign [a = a / 2]
            //a /= 2;
            //Console.WriteLine("Divide and Assign (a /= 2): " + a); // 12

            //// 6. Modulus and Assign [a = a % 5]
            //a %= 5;
            //Console.WriteLine("Modulus and Assign (a %= 5): " + a); // 2
            #endregion

            #region Relational Operators [Comparison]
            //int a = 10, b = 5;

            //// Equal to (==)
            //Console.WriteLine("a == b: " + (a == b)); // false

            //// Not equal to (!=)
            //Console.WriteLine("a != b: " + (a != b)); // true

            //// Greater than (>)
            //Console.WriteLine("a > b: " + (a > b)); // true

            //// Less than (<)
            //Console.WriteLine("a < b: " + (a < b)); // false

            //// Greater than or equal to (>=)
            //Console.WriteLine("a >= b: " + (a >= b)); // true

            //// Less than or equal to (<=)
            //Console.WriteLine("a <= b: " + (a <= b)); // false
            #endregion

            #region Logical Operators
            //bool A = true, B = false;
            //// Logical NOT
            //Console.WriteLine("!A: " + (!A));         // !true ==> false
            //Console.WriteLine("!B: " + (!B));         // !false ==> true

            //// Logical AND [Short Circuit]
            //Console.WriteLine("B && A: " + (B && A)); // false && true ===> false

            //// Logical OR [Short Circuit]
            //Console.WriteLine("A || B: " + (A || B)); // true || false ==> true

            #endregion

            #region Bitwise Operators

            //int a = 5; // Binary --> 0101
            //int b = 3; // Binary --> 0011

            //// Bitwise AND
            //Console.WriteLine("a & b: " + (a & b)); // 1 --> 0001

            //// Bitwise OR
            //Console.WriteLine("a | b: " + (a | b)); // 7 --> 0111

            //// Bitwise XOR
            //Console.WriteLine("a ^ b: " + (a ^ b)); // 6 --> 0110

            //int a = 5; // Binary --> 0100
            //int b = 3; // Binary --> 0000

            //// Bitwise NOT
            //Console.WriteLine("~a: " + (~a));       // -6 ( 2's complement of 5 --> 1010 ) 

            //// Left Shift
            //Console.WriteLine("a << 1: " + (a << 1)); // 10 --> 1010 

            //// Right Shift
            //Console.WriteLine("a >> 1: " + (a >> 1)); // 2 --> 0010 
            #endregion

            #region Ternary Operators
            //int a = 10, b = 20;
            //string result;
            //// Example : Simple Comparison
            //if (a > b)
            //    result = "a is greater";
            //else if (b > a)
            //    result = "b is greater";
            //else
            //    result = "a equals b";

            //result = (a > b) ? "a is greater" : "b is greater"; // if , else
            //result = (a > b) ? "a is greater" : (b > a) ? "b is greater" : "a equal b"; // if , else if , else
            //Console.WriteLine(result); // b is greater
            #endregion
            #endregion

            #region Operators Priority [Presedence] & Associtivity
            //// Operators Priority :-
            ///*
            // * 1- Unary Operators [Prefix]
            // * 2- Round Braces ()
            // * 3- * / %
            // * 4- + -
            // */

            //int a = 10, b = 20, c = 30;

            //int equation1 = a - b * c;
            //Console.WriteLine("Equation 1: " + equation1);  // Output: -590

            //int equation2 = a + b / c;
            //Console.WriteLine("Equation 2: " + equation2);  // Output: 10

            //int equation3 = (a + b) / c;
            //Console.WriteLine("Equation 3: " + equation3);  // Output: 1

            //int equation4 = a + b * c / a;
            //Console.WriteLine("Equation 4: " + equation4);  // Output: 70

            //int equation5 = (a + b) % c;
            //Console.WriteLine("Equation 5: " + equation5);  // Output: 0
            #endregion

            #region String formating

            #region Using +
            //int num1 = 10;
            //int num2 = 5;
            //Eqaution = 10 + 5 = 15
            //string message = "Equation" + " = " + num1 + " + " + num2 + " = " + (num1 + num2);
            //Console.WriteLine(message);

            #endregion
            #region Composite formatting
            //string message = string.Format("Equation = {0} + {1} = {2}", num1, num2, num1 + num2);
            //Console.WriteLine("Equation = {0} + {1} = {2}", num1, num2, num1 + num2);
            #endregion
            #region String interpolation
            //string message = $"Equation = {num1} + {num2} = {num1+num2}";
            //Console.WriteLine($"Equation = {num1} + {num2} = {num1 + num2}");
            #endregion
            #endregion
        }
    }
}