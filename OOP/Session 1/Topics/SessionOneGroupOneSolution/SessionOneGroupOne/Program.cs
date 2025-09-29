using Common;

namespace SessionOneGroupOne
{

    #region Enums
    [Flags]
    enum Permission : byte //8bit 1 --> 255
    {
        Read = 1,
        Write = 2,
        Delete = 4,
        Execute = 8,
    }
    class Employee
    {
        //public int Id { get; set; } 
        public int Id;
        public string Name;
        public double Salary;
        public Gender Gender;
        public Role Role;
        public Permission Permission;
    }
    enum Role : byte //1 -->255
    {
        Admin,
        Editor,
        Viewer,
    }
    enum Grades : int
    {
        A,
        B,
        C,
        D,
        E,
        F
    }
    enum Days
    {
        Saturday,
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday
    }
    enum Branches
    {
        Maadi,
        Dooki,
        Alex,
        NasrCity,
        SaudiArabia
    }
    enum Gender
    {
        M = 1,
        Male = 1,
        F = 2,
        Female = 2
    } 
    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1 ] Class library

            #endregion

            #region 2 ] Access modifiers
            //TypeA typeA = new TypeA(); //Accessible in different project
            //TypeB typeB = new TypeB();//Invalid because its accessiblity level
            //typeA.X = 10; //Invalid because x is private [accessible through its scope]
            //typeA.Y = 20; //Invalid because Y is internal , accessible through its project
            //typeA.Z = 30; //Valid because Z is public , accessible through the project and through the project refer to common
            #endregion

            #region 3 ] Enum Part 1
            // Gender gender = Gender.Male;
            //Grades geade = Grades.F;
            //Console.WriteLine("Please enter the grade");
            //char grade1 =  char.Parse(Console.ReadLine());
            //Grades grade1 = Grades.F;
            //if (grade1 == Grades.A)
            //    Console.WriteLine("Good");
            //else
            //    Console.WriteLine("Bad");
            //Branches Branch1 = Branches.Maadi;
            //Console.WriteLine(Branch1);

            //Employee employee = new Employee();
            //employee.Name = "Mariam";
            //employee.Salary = 1000;
            //employee.Id = 10;
            //employee.Gender = Gender.Female;

            //Grades grade = (Grades)2;
            //grade = (Grades)10;
            //Console.WriteLine(grade);

            /***************Try Enums [Branch , Gender , Roles , Grades , Days]********************/

            /***************Explict Casting from int to Enum********************/

            /***************Casting using Parse********************/
            //Console.WriteLine("Please enter the grade");
            //Grades grade1 = (Grades) Enum.Parse(typeof(Grades), Console.ReadLine());
            //Console.WriteLine(grade1);

            /***************Casting using TryParse********************/
            //Console.WriteLine("Please enter the grade");
            //bool Result= Enum.TryParse(typeof(Grades), Console.ReadLine(), out object? grade);
            //Console.WriteLine($"Result = {Result}");
            //Console.WriteLine(grade);


            #endregion

            #region 4 ] Enum Part 2
            /***************Case sensitivity********************/
            /***************Try to convert from string to gender explicitly********************/
            //Console.WriteLine("Please enter the gender");

            //Gender gender;
            //gender = (Gender)Enum.Parse(typeof(Gender), Console.ReadLine());
            //bool Result = Enum.TryParse(typeof(Gender), Console.ReadLine(), out object? gender);
            //Console.WriteLine(Result);
            //Console.WriteLine(gender);

            /***************Try to convert from string to gender using TryParse********************/
            //bool Result = Enum.TryParse<Gender>(Console.ReadLine(), true, out Gender gender);
            //Console.WriteLine(Result);
            //Console.WriteLine(gender);

            //Gender g1 = (Gender)1;
            //Console.WriteLine(g1);

            //Gender g1 = new Gender();
            //g1 = (Gender)1;
            //Console.WriteLine(g1);

            /***************Default value for enum********************/

            /***************Multilabel in enum********************/

            #endregion

            #region 5 ]  Permission Enum
            // Employee Emp1 = new Employee();
            // Emp1.Name = "Mariam";
            // Emp1.Id = 100;
            // Emp1.Salary = 1000;
            //Emp1.Permission[0] = Permission.Read;
            //Emp1.Permission[1] = Permission.Write;

            //enum Permission : byte //8bit 1 --> 255
            // {
            //     Read = 1,
            //     Write = 2,
            //     Delete = 4,
            //     Execute = 8,
            // }
            //Console.WriteLine(Emp1.Permission);
            // ^
            //XOR : add the permission if not exist , else remove the permission
            //Console.WriteLine(Emp1.Permission);

            //And : Check for the permission
            //if ((Emp1.Permission & Permission.Delete) == Permission.Delete)
            //{
            //    Console.WriteLine(Emp1.Permission);
            //    Console.WriteLine("Delete permission is exist");
            //}
            //else
            //{
            //    Emp1.Permission = Emp1.Permission ^ Permission.Delete;
            //    Console.WriteLine(Emp1.Permission);
            //    Console.WriteLine("Delete permission added successfully");

            //}
            //& | ^

            //Or | : Add permission if not exist , it exist do no thing
            //Emp1.Permission = (Permission)2; // write
            //Emp1.Permission = Emp1.Permission | Permission.Read;
            //Console.WriteLine(Emp1.Permission);
            #endregion

            #region  6 ] Struct
            Point p1; //Allocate for 8 bytes in stack [Unintialized]
            //p1 = new Point();
            p1 = new Point(10);
            //p1.X = 10;
            //p1.Y = 20;
            //new allow to me to choose the constructor that intialize the attributes inside struct
            //Console.WriteLine(p1.X);
            //Console.WriteLine(p1.Y);

            //Console.WriteLine(p1); //Boxing & Unboxing
            //Console.WriteLine(p1.ToString());
            //Point p2 = new Point(1, 2);
            //Console.WriteLine(p2);

            //.net 5 C# 9 Feature
            Point p2 = new();


            //int X = 10;
            //Console.WriteLine(X);
            #endregion

            #region 7 ] What is oop ?

            #endregion
        }
    }
}
