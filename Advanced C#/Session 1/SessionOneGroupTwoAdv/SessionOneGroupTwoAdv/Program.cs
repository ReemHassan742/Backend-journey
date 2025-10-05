using System.Collections;

namespace SessionOneGroupTwoAdv
{
    internal class Program
    {
        //public static int? SumArrList(ArrayList arrayList)
        //{
        //    int? Sum = 0;
        //    if(arrayList is not null)
        //    {
        //        for (int i = 0; i < arrayList.Count; i++)
        //        {
        //            Sum += (int?)arrayList[i]; //Unboxing
        //        }
        //    }
        //    return Sum;
        //}
        static void Main(string[] args)
        {
            #region Generics - Swap Example [Helper - Point]
            //int A = 10 , B = 20 ;
            //Console.WriteLine(A);
            //Console.WriteLine(B);
            //Console.WriteLine();
            //Helper.Swap<int>(ref A, ref B);
            //Console.WriteLine(A);
            //Console.WriteLine(B);
            //Console.WriteLine();

            //double X = 1.2, Y = 3.4;
            //Console.WriteLine(X);
            //Console.WriteLine(Y);
            //Console.WriteLine();
            //Helper.Swap<double>(ref X, ref Y);
            //Console.WriteLine(X);
            //Console.WriteLine(Y);
            //Console.WriteLine();

            //Point point1 = new Point(1, 2);
            //Point point2 = new Point(2, 3);
            //Console.WriteLine(point1);
            //Console.WriteLine(point2);
            //Console.WriteLine();
            //Helper.Swap<Point>(ref point1 , ref point2);
            //Console.WriteLine(point1);
            //Console.WriteLine(point2);
            //Console.WriteLine();
            //Specify the generic type in class level
            //Compiler can not detect the generic type

            //Specify the generic type in method level
            //Compiler will detect based on passed parameters
            #endregion

            #region Generics - Search Array Example [Helper - Point - Employee - Equals==]
            //int[] Numbers = { 1, 2, 3, 4, 5 };
            //int Index = Helper.SearchArray(Numbers, 6);
            //Console.WriteLine(Index);

            //Point[] Points = new Point[]
            //{
            //    new Point(1,2),
            //    new Point(2,3),
            //    new Point(3,4),
            //};
            //Point point3 = new Point(1, 2);
            //int Index = Helper.SearchArray(Points, point3);
            //Console.WriteLine(Index);

            //Employee[] employees = new Employee[]
            //{
            //    new Employee() {Id = 1 , Name ="Mariam" , Salary = 1000},
            //    new Employee() {Id = 2 ,Name = "Mohamed" , Salary = 2000}
            //};
            //Employee employee3 = new Employee() { Id = 1, Name = "Mariam", Salary = 1000 };
            //int Index = Helper.SearchArray(employees, employee3);
            //Console.WriteLine(Index);
            //Employee emp1 = new Employee() { Id = 1, Name = "Mariam", Salary = 1000 };
            //Employee emp2 = new Employee() { Id = 1, Name = "Mariam", Salary = 1000 };
            //Employee[] employees = new Employee[] { emp1, emp2 };

            //User defined struct ==> Not include == operator
            //Struct ==> ValueType ==> Object
            //Class ==> Object

            //Equals ==> struct : compare object state with object state
            //Equals ==> class : comapre reference with reference
            //Recommeneded : to compare obj state with obj state in class ==> override equals
            //==     ==> class : compare reference with reference

            //if (emp1 == emp2)
            //if (emp1.Equals(emp2)) 
            //    Console.WriteLine("Equal");
            //else
            //    Console.WriteLine("Not Equal");
            #endregion

            #region Equality in struct and class [HashCode]
            //Equals ==> user defined struct ==> ValueType : Object ==> Compare object state
            //==     ==> user defined struct ==> Not implemented (overloading)
            //Equals ==> class ==> Object ==> Compare reference with refernece
            //==     ==> class ==> Object ==> Compare reference with reference
            //Employee emp1 = new Employee() { Id = 1000, Name = "Mariam", Salary = 1 };
            //Employee emp2 = new Employee() { Id = 1, Name = "Mariam", Salary = 1000 };

            //Console.WriteLine(emp1.GetHashCode());
            //Console.WriteLine(emp2.GetHashCode());
            //int X = 1000;
            //Console.WriteLine(X.GetHashCode());
            //Console.WriteLine(X);

            //string Name = "Mariam";
            //Console.WriteLine(Name.GetHashCode());
            //if (emp1.Equals(emp2))
            //{
            //    Console.WriteLine("Equal");
            //}
            //else
            //{
            //    Console.WriteLine("Not equal");
            //}
            #endregion

            #region BubbleSort
            //int[] Numbers = { 9, 1, 2, 5, 10, 0, 12 , 10 , 30 ,129 , 100 };
            //foreach (int number in Numbers)
            //{
            //    Console.Write(number + " ");
            //}
            //Console.WriteLine();
            //Helper<int>.BubbleSort(Numbers);
            //foreach (int number in Numbers)
            //{
            //    Console.Write(number + " ");
            //}

            //Employee emp1 = new Employee() { Id = 1 , Name = "Mariam" , Salary = 10000};
            //Employee emp2 = new Employee() { Id = 2, Name = "Mohamed", Salary = 2000 };
            //Employee emp3 = new Employee() { Id = 3, Name = "Ahmed", Salary = 1000 };
            //Employee[] employees = new Employee[] { emp1, emp2, emp3 };
            //Helper<Employee>.BubbleSort(employees);
            //foreach (Employee emp in employees)
            //{
            //    Console.WriteLine(emp);
            //}

            //Point[] Points = new Point[]
            //{
            //    new Point(20,30),
            //    new Point(20,10),
            //    new Point(10,20),
            //    new Point(1,2),
            //    new Point(2,3),
            //};
            //Helper<Point>.BubbleSort(Points);
            //foreach (Point p in Points)
            //{
            //    Console.WriteLine(p);
            //}

            #endregion

            #region Generics Constraints [Class - Method]

            #endregion

            #region Non Generic Collections - ArrayList
            //ArrayList arrayList;
            //reference arrayList
            //arrayList = new ArrayList();
            //ArrayList is internally an array
            //Array ==> Advantages : access any element in one step
            //Array ==> Disadvantaged : fixed length
            //ArrayList ==> empty array
            //Array size ==> Length
            //ArrayList size ==> Count , Capacity
            //Console.WriteLine($"Count ==> {arrayList.Count}"); // 0
            //Console.WriteLine($"Capacity ==> {arrayList.Capacity}"); //0
            //Count ==> actual numbers of elements in array list
            //Capacity ==> Numbers that arraylist can hold
            //arrayList.Add(1);
            ////Console.WriteLine($"Count ==> {arrayList.Count}"); // 1
            ////Console.WriteLine($"Capacity ==> {arrayList.Capacity}"); //4
            ////Once you added an element ==> Create new array size = defaultCapacity[4]
            //arrayList.AddRange(new int[] { 2, 3, 4 });
            //Console.WriteLine($"Count ==> {arrayList.Count}"); // 4
            //Console.WriteLine($"Capacity ==> {arrayList.Capacity}"); //4
            //arrayList.Add(5);
            //// create new array ==> size = 2 * oldCapacity
            //Console.WriteLine($"Count ==> {arrayList.Count}"); // 5
            //Console.WriteLine($"Capacity ==> {arrayList.Capacity}"); // 8
            //arraylist is dynamic size
            //ArrayList arrayList2 = new ArrayList(5);
            //arrayList2.AddRange(new int[] { 1, 2, 3, 4, 5 });
            //Console.WriteLine($"Count ==> {arrayList2.Count}"); // 5
            //Console.WriteLine($"Capacity ==> {arrayList2.Capacity}"); // 5
            //arrayList2.Add(6);

            // 4 * 4 = 16 bytes
            //Console.WriteLine($"Count ==> {arrayList2.Count}"); // 6
            //Console.WriteLine($"Capacity ==> {arrayList2.Capacity}"); // 10
            //arrayList2.TrimToSize();
            //Console.WriteLine($"Count ==> {arrayList2.Count}"); // 6
            //Console.WriteLine($"Capacity ==> {arrayList2.Capacity}"); // 6

            //arrayList2.Add("Mariam"); //ArrayList heterogenous list
            //arrayList2.Add(12.2);

            ////Compiler will not force the type safety
            ////Boxing  , UnBoxing
            ////foreach (int i in arrayList2)
            ////    Console.WriteLine(i);
            //int? Sum = SumArrList(arrayList2);
            //Console.WriteLine(Sum);
            #endregion
        }
    }
}
