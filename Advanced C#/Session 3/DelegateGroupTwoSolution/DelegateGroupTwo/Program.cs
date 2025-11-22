using DelegateGroupTwo.Example_1;
using DelegateGroupTwo.Example_2;
using DelegateGroupTwo.Example_3;
using System.Linq.Expressions;

namespace DelegateGroupTwo
{
    //1] Declare delegate 
    //Delgate [class]
    //Delegate can refer to static or non static method
    //Delegate can refer to one or more methods

    //public delegate int StringFuncDelegate(string s);
    internal class Program
    {
        //public static Action DoAction()
        //{
        //    //return delegate () { Console.WriteLine("Hello word"); };
        //    return () => Console.WriteLine("HelloWorld");
        //}
        static void Main(string[] args)
        {


            #region Example 0 - UpperCase
            //C# is pure oop
            //Delegate ==> c# language feature ==> C# pure oop language
            //1] Functional programming paradiagm [Pointer to function]
            // --> Store function address in variable
            // --> Send function as parameter
            // --> Return function from another function
            //2] Event driven programming paradiagm

            //Steps :-
            //1] Declare delegate
            //2] Declare reference from delegateE
            //3] Intialize the reference from delegate
            //4] Use the delegate [Invoke]

            //int X = StringFunctions.CountUpperCase;
            //2] Declare reference from delegatee
            //StringFuncDelegate stringFuncDelegate; //reference

            ////3] Intialize the reference from delegate
            //stringFuncDelegate = new StringFuncDelegate(StringFunctions.CountUpperCase);
            ////refer to function [CountUpperCase]
            //stringFuncDelegate = StringFunctions.CountUpperCase;//Syntax sugar

            ////int cnt = stringFuncDelegate.Invoke("OmarAli");
            ////stringFuncDelegate ==> can refer to one or more method with the same signature
            ////take one parameter [string] and return int

            //stringFuncDelegate += StringFunctions.CountLowerCase;
            ////Ignore to the old method
            ////stringFuncDelegate ==> LowerCase

            //stringFuncDelegate -= StringFunctions.CountLowerCase;
            //int cnt = stringFuncDelegate("OmarAli"); //5
            //Console.WriteLine(cnt);

            #endregion

            #region Example 1 - SortingAlgo [BubbleSort] [NonGeneric , Generic]
            //int[] Arr = { 10, 1, 2, 3, 20, 9, 8 };
            //CompareFuncDelegate compareFuncDelegate = ComapingFunctions.CompareGreater;
            //SortingAlgorithms.BubbleSort(Arr, compareFuncDelegate);
            //foreach(int i in Arr)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine();
            //Console.WriteLine();
            ////SortingAlgorithms.BubbleSortDesc(Arr);
            //SortingAlgorithms.BubbleSort(Arr, ComapingFunctions.CompareLess);

            //foreach (int i in Arr)
            //{
            //    Console.Write(i + " ");
            //}

            //string[] ArrNames = { "Amr", "Abdelrhman", "Mohamed", "Ali", "Omar" };
            //SortingAlgorithms<string>.BubbleSort(ArrNames, ComapingFunctions.CompareStr);
            //foreach(string s in ArrNames)
            //{
            //    Console.WriteLine(s);
            //}

            //SortingAlgorithms<string>.BubbleSort(ArrNames, ComapingFunctions.CompareStrDsc);
            //foreach (string s in ArrNames)
            //{
            //    Console.WriteLine(s);
            //}

            #endregion

            #region Example 2 - Numbers [Odd - even] [NonGeneric , Generic] 
            //List<int> Numbers = Enumerable.Range(1, 100).ToList();
            //foreach (int i in Numbers)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine();
            //Console.WriteLine();
            //List<int> OddNumbers = Helper.GetElements(Numbers,FilterationFunctions.CheckOdd);
            //foreach (int i in OddNumbers)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine();
            //Console.WriteLine();
            //List<int> EvenNumbers = Helper.GetElements(Numbers,FilterationFunctions.CheckEven);
            //foreach (int i in EvenNumbers)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine();
            //Console.WriteLine();
            //FilterationFuncDelgate<int> filterationFuncDelgate = FilterationFunctions.CheckDivisbleBy7;
            //List<int> NumbersDivisibleBy7 = Helper.GetElements(Numbers, filterationFuncDelgate);
            //foreach (int i in NumbersDivisibleBy7)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine();
            //Console.WriteLine();

            //filterationFuncDelgate = FilterationFunctions.CheckDivisbleBy10;
            //List<int> NumbersDivisbileBy10 = Helper.GetElements(Numbers, filterationFuncDelgate);
            //foreach (int i in NumbersDivisbileBy10)
            //{
            //    Console.Write(i + " ");
            //}

            //List<string> Names = new List<string>() {"Omar", "Amr" , "Mohamed" , "Abderlhman" };
            //List<string> FilteredNames = Helper.GetElements(Names, FilterationFunctions.CheckStrLen);
            //foreach(string Name in FilteredNames)
            //{
            //        Console.Write(Name + " ");
            //}
            #endregion

            #region Built-In Delegates
            /*
             * Predicate ==> A delegate that takes one parameter and returns a bool .
             * Func ==> A delegate that returns a value and can take up to 16 parameters.
             * Action ==> A delegate for methods that return void and can take up to 16 parameters.
             */

            // ******* Predicate ==> can refer to any function that take one parameter from
            // any type and return bool

            //List<int> Numbers = Enumerable.Range(1, 100).ToList();
            //foreach (int i in Numbers)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine();
            //Console.WriteLine();
            //List<int> OddNumbers = Helper.GetElements(Numbers, FilterationFunctions.CheckOdd);
            //foreach (int i in OddNumbers)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine();
            //Console.WriteLine();
            //List<int> EvenNumbers = Helper.GetElements(Numbers, FilterationFunctions.CheckEven);
            //foreach (int i in EvenNumbers)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine();
            //Console.WriteLine();
            //Predicate<int> filterationFuncDelgate = FilterationFunctions.CheckDivisbleBy7;
            //List<int> NumbersDivisibleBy7 = Helper.GetElements(Numbers, filterationFuncDelgate);
            //foreach (int i in NumbersDivisibleBy7)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine();
            //Console.WriteLine();

            //filterationFuncDelgate = FilterationFunctions.CheckDivisbleBy10;
            //List<int> NumbersDivisbileBy10 = Helper.GetElements(Numbers, filterationFuncDelgate);
            //foreach (int i in NumbersDivisbileBy10)
            //{
            //    Console.Write(i + " ");
            //}

            //List<string> Names = new List<string>() { "Omar", "Amr", "Mohamed", "Abderlhman" };
            //List<string> FilteredNames = Helper.GetElements(Names, FilterationFunctions.CheckStrLen);
            //foreach (string Name in FilteredNames)
            //{
            //    Console.Write(Name + " ");
            //}
            // ******* Func ==> refer to function take 0 to 16 param and must return value
            //Func<string,int> stringFuncDelegate; //reference
            ////Func can refer to function that take one paraameter string , return int
            ////3] Intialize the reference from delegate
            //stringFuncDelegate = new Func<string, int>(StringFunctions.CountUpperCase);
            ////refer to function [CountUpperCase]
            //stringFuncDelegate = StringFunctions.CountUpperCase;//Syntax sugar

            ////int cnt = stringFuncDelegate.Invoke("OmarAli");
            ////stringFuncDelegate ==> can refer to one or more method with the same signature
            ////take one parameter [string] and return int

            //stringFuncDelegate += StringFunctions.CountLowerCase;
            ////Ignore to the old method
            ////stringFuncDelegate ==> LowerCase

            //stringFuncDelegate -= StringFunctions.CountLowerCase;
            //int cnt = stringFuncDelegate("OmarAli"); //5
            //Console.WriteLine(cnt);


            // *******Action ==> Has 2 types [Generic - NonGeneric]
            //==> NonGeneric : Refer to method that not take parameters and must be void
            //==> Generic : Can refer to function take from 1 to 16 paramters and no return [void]


            #endregion

            #region Built-In Delegates Part 2
            //Predicate ==> Refer to method that take one parameter T and return bool
            //Func ==> Refer to method that take 0 - 16 input parameter and must be return 
            //Action ==> Generic : Refer to method take 1 - 16 parameter and must be void
            //       ==> NonGeneric : Refer to method not take parameters and void 
            //reference from delegate
            //Predicate<int> predicate; 
            ////predicate = new Predicate<int>(TestingFunctions.Test1);
            //predicate = TestingFunctions.Test1;
            //bool result = predicate.Invoke(10);
            //Console.WriteLine(result);

            //Func<int, string> func;            //create refernce from built in delegate

            //func = TestingFunctions.Test2;
            ////Console.WriteLine(func.Invoke(33));
            //Console.WriteLine(func(33));

            //Action action; //Refer to method that take no parameters and must be void
            //action = TestingFunctions.Test3;
            //action.Invoke();
            //action();

            // Action<string> action; //create reference from built in delegate
            // action = new Action<string>(TestingFunctions.Test4);
            // action.Invoke("Mariam");
            // action("Mariam");

            #endregion

            #region Anonymous method and lambda expression
            //Anonymous method[C# 2 [2005]]
            //Predicate ==> Refer to method that take one parameter T and return bool
            //Func ==> Refer to method that take 0 - 16 input parameter and must be return 
            //Action ==> Generic : Refer to method take 1 - 16 parameter and must be void
            //       ==> NonGeneric : Refer to method not take parameters and void 
            //reference from delegate
            //Predicate<int> predicate;
            ////predicate = new Predicate<int>(TestingFunctions.Test1);
            //predicate = delegate (int x){return x > 0;};
            //bool result = predicate.Invoke(10);
            //Console.WriteLine(result);

            //Func<int, string> func;            //create refernce from built in delegate

            //func =   delegate (int x) { return x.ToString(); };
            //Console.WriteLine(func.Invoke(33));
            //Console.WriteLine(func(33));

            //Action action; //Refer to method that take no parameters and must be void
            //action =    delegate() { Console.WriteLine($"Hello"); };
            //action.Invoke();
            //action();

            //Action<string> action; //create reference from built in delegate

            //action = new Action<string>(delegate (string name) { Console.WriteLine($"Hello {name}"); });
            //action.Invoke("Mariam");
            //action("Mariam");


            //Lambda Expression [C# 3]
            //Anonymous method[C# 2 [2005]]
            //Predicate ==> Refer to method that take one parameter T and return bool
            //Func ==> Refer to method that take 0 - 16 input parameter and must be return 
            //Action ==> Generic : Refer to method take 1 - 16 parameter and must be void
            //       ==> NonGeneric : Refer to method not take parameters and void 
            //reference from delegate
            //Predicate<int> predicate;
            //predicate =  (x) =>  x > 0; ; //Lambda expression
            //bool result = predicate.Invoke(10);
            //Console.WriteLine(result);

            //Func<int, string> func;            //create refernce from built in delegate
            //func = x => x.ToString(); ; //Lambda expression
            //Console.WriteLine(func.Invoke(33));
            //Console.WriteLine(func(33));

            ////Action action; //Refer to method that take no parameters and must be void
            ////action = () => { Console.WriteLine($"Hello"); };
            ////action.Invoke();
            ////action();
            //Action<string> action; //create reference from built in delegate

            //action = new Action<string>( ( name) =>  { Console.WriteLine($"Hello {name}"); });
            //action.Invoke("Mariam");
            //action("Mariam");

            #endregion

            #region New Features C# 10 [var]
            //C# ==> strongly typed language
            //int X = 10;

            //var predicate = (int X) => X % 2 == 0;
            //var Func = (int X) => X.ToString();
            //var Action = () => Console.Write("Hello");


            #endregion

            #region List Methods [delegate]
            //foreach (int num in Numbers)
            //{
            //    Console.Write(num + " ");
            //}
            //Console.WriteLine();
            //Console.WriteLine();

            //List<int>OddNumbers = Numbers.FindAll(x => x % 7 == 0);
            //foreach (int num in OddNumbers)
            //{
            //    Console.Write(num + " ");

            //}
            //int result =Numbers.Find(x => x % 2 == 1);
            //result = Numbers.FindIndex(x => x % 2 == 0);
            //result = Numbers.FindLastIndex(x => x % 2 == 0);

            //Console.WriteLine(result);
            //List<int> OddNumbers = Helper.GetElements(Numbers, FilterationFunctions.CheckOdd);
            //foreach(int num in OddNumbers)
            //{
            //    Console.Write(num + " ");
            //}
            //Numbers.Remove(2);
            //List<int> Numbers = Enumerable.Range(1, 100).ToList();
            //Numbers.ForEach(x => Console.Write(x+5 + " ")) ;
            ////int cnt = Numbers.RemoveAll(x => x % 5 == 0);
            ////Console.WriteLine($" ==> {cnt}");
            //Console.WriteLine();
            //foreach (int num in Numbers)
            //{
            //    Console.Write(num + " ");
            //}
            #endregion

            #region Function return function
            //DoAction().Invoke();
            //DoAction()();
            #endregion
        }
    }
    class TestingFunctions
    {
        public static bool Test1(int x) { return x > 0;}
        public static string Test2(int x) { return x.ToString();}
        public static void Test3(){Console.WriteLine($"Hello");}
        public static void Test4(string name){Console.WriteLine($"Hello {name}");}
    }
}
