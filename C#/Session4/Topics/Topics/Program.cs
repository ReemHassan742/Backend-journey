using System.Globalization;

namespace CSharpFourGroupTwo
{
    //Class
    //Enum
    //Interface
    //Struct
    class Data
    {
        public int Sum { get; set; }
        public int Multiply { get; set; }
    }
    class Program
    {
        #region Functions 1 [PrintShape] 
        //static void PrintShape( string Pattern , int Counter = 10)
        //{
        //    for(int i = 0; i < Counter; i++)
        //    {
        //        Console.WriteLine(Pattern);
        //    }
        //}
        #endregion

        #region Functions 2 [Swap]
        //static void Swap(int x , int y)
        //{
        //    int Temp = x;
        //    x = y;
        //    y = Temp;
        //}
        //static void Swap(ref int x, ref int y)
        //{
        //    int Temp = x;
        //    x = y;
        //    y = Temp;
        //}
        #endregion

        #region Functions 3 [SumArray change element]
        //static int SumArray(int[] Arr)
        //{

        //    int Sum = 0;
        //    if (Arr is not null)
        //    {
        //        Arr[0] = 100;
        //        for (int i = 0; i < Arr.Length; i++)
        //            Sum += Arr[i];
        //    }

        //    return Sum;
        //}
        //static int SumArray(ref int[] Arr)
        //{

        //    int Sum = 0;
        //    if (Arr is not null)
        //    {
        //        Arr[0] = 100;
        //        for (int i = 0; i < Arr.Length; i++)
        //            Sum += Arr[i];
        //    }

        //    return Sum;
        //}
        #endregion

        #region Functions 4 [SumArray change the reference]
        //static int SumArray(int[] Arr) //1 , 2 , 3 
        //{
        //    int Sum = 0;
        //    if (Arr is not null)
        //    {
        //        Arr = new int[3] { 100, 200, 300 };
        //        for (int i = 0; i < Arr.Length; i++)
        //            Sum += Arr[i];
        //    }

        //    return Sum;
        //}
        //static int SumArray(ref int[] Arr) //1 , 2 , 3 
        //{
        //    int Sum = 0;
        //    if (Arr is not null)
        //    {
        //        Arr = new int[3] { 100, 200, 300 };
        //        for (int i = 0; i < Arr.Length; i++)
        //            Sum += Arr[i];
        //    }

        //    return Sum;
        //}
        #endregion

        #region Functions 5 [MultiplySum]
        //static int MultiplySum(int X , int Y)
        //{
        //    return X * Y;
        //    return X + Y;
        //}
        //static int[] MultiplySum(int X, int Y)
        //{
        //    return new int[] { X * Y, X + Y };
        //}
        //static Data MultiplySum(int X, int Y)
        //{
        //    Data data = new Data() { Multiply = X * Y, Sum = X + Y };
        //    return data;
        //}
        //static void MultiplySum(int X, int Y , out int Sum , out int Multiply)
        //{
        //    Sum = X + Y;
        //    Multiply = X * Y;
        //}

        #endregion

        #region Functions 6 [SumArr params]
        //static int SumArray(int size,int def = 10,params int[] Arr)
        //{
        //    int Sum = 0;
        //    if(Arr is not null)
        //    {
        //        for (int i = 0; i < Arr.Length; i++)
        //            Sum += Arr[i];
        //    }
        //    return Sum;
        //}
        #endregion

        #region Functions 7 [DoSomeCode - DoSomeCleanCode] 
        //static void DoSomeCode()
        //{
        //    int X = int.Parse(Console.ReadLine());
        //    int Y = int.Parse(Console.ReadLine());
        //    int Divison = X / Y;
        //    Console.WriteLine(Divison);
        //    int[] Arr = { 1, 2, 3 };
        //    Arr[100] = 10;
        //}
        //static void DoSomeProtictiveCode()
        //{
        //    int X , Y;
        //    bool flag;
        //    do
        //    {
        //        Console.WriteLine("Please enter X");
        //        flag = int.TryParse(Console.ReadLine(), out X);
        //    } while (!flag);
        //    do
        //    {
        //        Console.WriteLine("Please enter Y");
        //        flag = int.TryParse(Console.ReadLine(), out Y);
        //    } while (!flag || Y <=0 );

        //    int Divison = X / Y;
        //    Console.WriteLine(Divison);

        //    int[] Arr = { 1, 2, 3 };
        //    if (Arr is not null)
        //    {
        //        try
        //        {
        //            Arr[1] = 10;
        //        }
        //        catch(Exception ex)
        //        {
        //            Console.Write(ex.Message);
        //        }
        //        finally
        //        {
        //            Console.Write("Hello from Finally");
        //            //Relase , Remove , Deallocate UnManaged rousrces [Db , Files]
        //        }
        //    }
        //}
        #endregion
        static void Main(string[] args)
        {
            #region Arrays [2D Array - Judged array - Marks]
            // int[][] Marks = new int[3][];
            // Marks[0] = new int[3] { 10, 20, 30 };
            // Marks[1] = new int[2] { 10, 20 };
            // Marks[2] = new int[1] { 10 };
            // int[][] Marks2 = [new int[3] { 10, 20, 30 }, new int[2] { 10, 20 }, new int[1] { 10 }];
            //for(int i = 0; i< Marks.Length; i++)
            //{
            //    for (int j = 0; j < Marks[i].Length;j++)
            //    {
            //        Console.Write(Marks[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //   

            //Console.Write("Please enter the size of judgged array ");
            //int size = int.Parse(Console.ReadLine());
            //int[][] Marks3 = new int[size][];
            //for(int i = 0; i < Marks3.Length; i++)
            //{
            //    Console.Write($"Please enter the size of the array for student {i+1} ");
            //    int sizeTwo = int.Parse(Console.ReadLine());
            //    for(int j = 0; j < sizeTwo; j++)
            //    {
            //        Console.Write($"Please enter element number {j+1} ");
            //        int.TryParse(Console.ReadLine(), out Marks[i][j]);
            //    }
            //}

            #endregion

            #region Array Methods
            //1 - class member method [static method]
            //int[] Numbers = { 10, 23, 5, 6, 0 , 10};
            //int[] Numbers2 = new int[5];

            //Array.Sort(Numbers);
            //Array.Reverse(Numbers);
            //Array.Copy(Numbers, Numbers2, 3);
            // Array.ConstrainedCopy(Numbers, 1, Numbers2, 1, 3);
            //Console.WriteLine(Array.IndexOf(Numbers, 10));
            //Console.WriteLine(Array.LastIndexOf(Numbers, 10));

            //int[]Arr = (int[]) Array.CreateInstance(typeof(int), 5);  //int[] Arr = new int[5];
            //int[,]Arr = (int[,]) Array.CreateInstance(typeof(int), 5 , 6);

            //Console.WriteLine(Arr.Length);
            //for(int i = 0; i < Numbers2.Length; i++)
            //{
            //    Console.WriteLine(Numbers2[i]);
            //}
            //2 - object member method [non static method]
            //int[] Numbers = { 1, 2, 3, 4, 5 };
            //int[] Numbers2 = new int[5];
            //Numbers.CopyTo(Numbers2, 0);
            //for(int i = 0; i < Numbers2.Length; i++)
            //{
            //    Console.WriteLine(Numbers2[i]);
            //}
            //Numbers.SetValue(10, 0); // Numbers[0] = 10
            //Console.WriteLine(Numbers[0]);
            //Console.WriteLine(Numbers.GetValue(0)); //Numbers[0]

            #endregion

            #region Boxing & UnBoxing
            //Boxing --> Casting from value type to reference type
            //UnBoxing --> Casting from reference type to value type

            //object obj = new object();
            //obj = "Mariam"; //Refernce type = reference type
            //obj = 10; //Boxing from int to obj
            //          //Implicit castong from int to obj [Safe]
            //obj = true;
            //obj = 13.5;
            //obj = new DateTime();
            //Animal = dog

            //int X = 15;
            //object obj = 10;
            //// obj = "Mariam";
            //X = (int)obj; // Explicit casting [unsafe]
            //Dog = animal

            //Employee = (PartimeEmployee) Employee2
            #endregion

            #region Nullable Types && Null coalescing operator
            //Nullable types ==> value types allow null as a valid value 
            //Nullable ==> Allow its type OR NULL
            #region Examples
            //string? Name = null;
            ////int Num = null;

            //int[] Numbers;
            //Numbers = null;

            //int? Num = 10;
            //Num = null;

            //double? Salary = 100.5;
            //Salary = null;
            #endregion

            #region Casting between nullable type and value type
            //int X = 5;
            //int? Y = 10;
            //Y = X;

            //int? X = 10;
            //X = null;
            //int Y;
            //if (X != null)
            //    Y = (int)X;
            //else
            //    Y = 0;
            /*************************/
            //if (X is not null)
            //    Y = (int)X;
            //else
            //    Y = 0;
            //Console.WriteLine(Y);
            /*************************/

            //int? X = 10;
            //X = null;
            //int Y;

            //if (X.HasValue)
            //    Y = X.Value;
            //else
            //    Y = 0;
            /*************************/

            // Y = X is not null ? (int)X : 0;
            // Console.WriteLine(Y);
            /*************************/
            //Y = X ?? 0;
            //Console.WriteLine(Y);

            #endregion
            #endregion

            #region Null Propagation operator
            //double Salary = default; //0
            //Console.WriteLine(Salary);
            //int[] Arr;
            //Arr = default;
            ////for(int i = 0; i < Arr.Length; i++)
            ////{
            ////    Console.WriteLine(Arr[i]);
            ////}
            //for(int i = 0;(Arr is not null) && (i < Arr.Length); i++)
            //{
            //    Console.WriteLine(Arr[i]);
            //}
            //Arr = new int[4] { 1, 2, 3, 4 };

            //for (int i = 0; i< Arr?.Length ; i++)
            //{
            //    Console.WriteLine(Arr[i]);
            //}
            //if(Arr is not null)
            //{
            //    for (int i = 0; i < Arr.Length; i++)
            //    {
            //        Console.WriteLine(Arr[i]);
            //    }
            //}

            //Employee {Id , Name , Department}
            //Deparmtent {DeptId , DeptName}
            //Employee?.Department?.DeptName

            //int[] Numbers = { 1, 2, 3 };
            //Numbers = null;

            //Console.WriteLine(Numbers?.Length);
            //int? Num = null;
            //Console.WriteLine(Num);

            #endregion

            #region Null forgeviness operator
            //string Name = null!;
            //Console.WriteLine(Name);
            //string email = _config["Email"]!;
            //int? Number2 = null!;
            #endregion

            #region Function [PrintShape]

            // PrintShape();
            // PrintShape(10, "-_-");
            // PrintShape(Pattern :"-_-",Counter :10); //Passing by name
            // PrintShape();
            // PrintShape(Pattern : "****");
            // PrintShape(Counter : 20 , Pattern : @"/*\");
            #region \ @

            // Console.Write("Mariam \n Shindy");
            // Console.Write("Mariam \t Shindy");
            // Console.Write("Mariam \\ Shindy");
            // string filePath = "D:\\WorkShop\\Extra\\C#";
            //Console.WriteLine(@"Mariam \n Shindy");
            #endregion
            #endregion

            #region Function [Value type parameters] [Passing by value , by ref]
            //Passing by value
            //int a = 10, b = 5;
            //Console.WriteLine($"a before swap = {a}");
            //Console.WriteLine($"b before swap = {b}");
            //Swap(a, b); //Send copy of values in variables
            //Console.WriteLine($"a After swap = {a}"); //5
            //Console.WriteLine($"b After swap = {b}"); //10

            //Passing by ref
            //Console.WriteLine($"a before swap = {a}"); //10
            //Console.WriteLine($"b before swap = {b}"); //5
            //Swap(ref a,ref b); // Send varibales itself
            //Console.WriteLine($"a After swap = {a}"); //5
            //Console.WriteLine($"b After swap = {b}"); //10

            #endregion

            #region Function [Reference type parameters] [Passing by value , by ref]
            #region Example 1
            //Passing by value
            //int[] Numbers = { 1, 2, 3, 4 };
            //int Result = SumArray(Numbers); 
            //Console.WriteLine(Result);
            //Console.WriteLine(Numbers[0]); //100

            //Passing by ref
            //int[] Numbers = { 1, 2, 3, 4 };
            //int Result = SumArray(ref Numbers);
            //Console.WriteLine(Result);
            //Console.WriteLine(Numbers[0]); 
            #endregion

            #region Example 2
            //Passing by value
            //int[] Numbers = { 1, 2, 3 };
            //int Result = SumArray(Numbers);
            ////Console.WriteLine(Result);
            //Console.WriteLine(Numbers[0]);

            //Passing by ref
            //int[] Numbers = { 1, 2, 3 };
            //int Result = SumArray(ref Numbers);
            //Console.WriteLine(Result);
            //Console.WriteLine(Numbers[0]); //100
            #endregion
            #endregion

            #region Function [Passing by out] [SumMultiply]
            //int A = 10, B = 5;
            //int Sum = 0, Multiply = 0;  
            //MultiplySum(A, B, out _, out  _);
            //MultiplySum(A, B, ref Sum, ref Multiply);
            //Console.WriteLine(Sum);
            //Console.WriteLine(Multiply);
            #endregion

            #region Function [Params]
            //int[] Numbers = { 10, 20, 30 };
            //int Result = SumArray(10 , 20 , 30 , 40 , 50);
            //Console.WriteLine(Result);
            #endregion

            #region Exception handling
            //DoSomeCode();
            //DoSomeProtictiveCode();
            /* Exception
            ///// 1. SystemException
            /////////////// 1. FormatException
            /////////////// 2. IndexOutOfRangeException
            /////////////// 4. NullReferenceException
            /////////////// 4. InvalidOperationException
            /////////////// 5. ArithmeticException
            ///////////////////// 5.1 DivideByZeroException
            ///////////////////// 5.2 OverflowException
            ///// 2. ApplicationException
            */

            #endregion

        }
    }
}