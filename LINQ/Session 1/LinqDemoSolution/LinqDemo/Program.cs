using LinqDemo.Data;
using System.Net.Http.Headers;
using static LinqDemo.ListGenerator;

namespace LinqDemo
{
    public class ProudctNew
    {
        public long ProductId { get; set; }
        public string ProductName { get; set; }
        public override string ToString()
        {
            return $"{ProductId} , {ProductName}";
        }
    }
    internal class Program
    {
     
        static void Main(string[] args)
        {
            #region Implicitly typed local variable [dynamic - var]
            //string Name = "Mariam";

            //Var ==> Compiler will detect the type , based on intial value
            //Var ==> You must intialize the variable

            //var Name = "Mariam"; //Intialization String

            //var Number = 5;

            ////var X = null; //Invalid
            //Name = null; //Set value to null but you cant intialize with null

            //var Number2;//Invalid

            //dynamic
            //CLR will detect the data type of the variable run time
            //Based on last value assigned
            //dynamic Name = "Mariam";
            //Name = 3;
            //Name = true;
            //Name = 3.14;
            //Console.WriteLine(Name);
            //dynamic X = null; //CLR
            //Console.WriteLine(X);

            //var recommended ==> Detect any problems in compilation time 
            //var Y = null;

            //Fun(var x)
            //Class Employee {var Id}
            //var Fun()
            //var Name1 = "Mariam";
            //Name1 = "ziad";
            //Name1 = 1;


            #endregion

            #region Anonymous type        
            //Employee employee = new Employee() { Id = 100 , Name = "Mariam" , Salary = 1000 };

            //object emp1 = new { Id = 100, Name = "Mariam", Salary = 1000 };
            ////emp1 = 10;
            ////emp1 = "Mariam";
            //Console.WriteLine(emp1.Salary);

            //Anonymous type
            //var Employee = new { Id = 100 , Name = "Mariam" , Salary = 1000 };
            //Console.WriteLine(Employee.Salary);
            //Console.WriteLine(Employee.GetType().Name); //_AnonymousType0`3

            ////Employee.Salary = 2000; //Invalid

            ////till C# 9
            //var Employee2 = new { Id = Employee.Id, Name = Employee.Name, Salary = 2000 };
            //Console.WriteLine(Employee.GetType().Name);//_AnonymousType0`3

            ////C# 10 Feature
            //var Employee3 = Employee with { Salary = 2000 };
            //Console.WriteLine(Employee3.GetType().Name);//_AnonymousType0`3

            //var Employee4 = new { Id = 1000, Name = "Mohamed" };//_AnonymousType1`2
            //Console.WriteLine(Employee4.GetType().Name);

            //var Employee5 = new { Name = Employee.Name, Id = Employee.Id, Salary = 2000 };
            //Console.WriteLine(Employee5.GetType().Name);//_AnonymousType2`3


            //Anonymous type will be the same type if :
            //1] Names of Properties are the same [Case sensitive]
            //2] Number of properties are the same
            //3] Order of properties are the same





            //int X = 5;
            //Console.WriteLine(X.GetType().Name);

            #endregion

            #region Extension method
            //int X = 12345;
            //int Result = IntExtensions.ReverseNumber(X);
            //int Result = X.ReverseNumber();
            //Console.WriteLine(Result);
            //long Y = 1234567891;
            //long Result2 = Y.ReverseNumber();
            //Console.WriteLine(Result2);
            #endregion

            #region LINQ
            // LINQ ==> Language intergrated query
            // Linq ==> Some extensions methods
            // DQL ==> Some extensions methods 
            // LINQ ==> +40 operators  
            // LINQ ==> 13 Category
            // Extension methods implemented in class Enumerable
            // LINQ Operators ==> Sequence
            // List , Any Collection that implement interface IEnumerable
            // SQL Queries ==> SqlServer Syntax ==> ORM [EF] ==> Db
            // SQL Queries ==> Postgresql

            //LINQ ==> ORM [EF] ==> Convert to sql based on connection [Mysql - Postgresql - SqlServer]

            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            ////List<int>OddNumbers = Numbers.Where(X => X % 2 == 1).ToList();
            // var OddNumbers = Numbers.Where(X => X % 2 == 1);


            //foreach(var number in OddNumbers)
            //{
            //    Console.Write(number + " ");
            //}

            //Sequence ==> object from any class that implement interface [IEnumerable]
            //1] Local sequence 
            //// A] Static [L2Object]
            //// B] XML    [L2XML]

            //2] Remote sequence
            ////  [L2EF]

            //You can use linq operators against the data [stored in sequence]
            // Regardless data store [Orcale , Postgresql , MySql , SqlServer]

            //https://source.dot.net/#q=Enumerable

            #endregion

            #region LINQ Syntax [Fluent , Query]

            #region Fluent syntax
            //1] As Static Method
            //2] As Extension Method 

            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            ////1] As Static Method
            //var oddNumbers = Enumerable.Where(Numbers, X => X % 2 == 1);
            //foreach(var number in oddNumbers)
            //{
            //    Console.Write(number + " ");
            //}
            //Console.WriteLine();
            ////2] As Extension Method  [Recommended]
            //var EvenNumbers = Numbers.Where(X => X % 2 == 0);
            //foreach( var number in EvenNumbers)
            //{
            //    Console.Write(number + " ");

            //}



            #endregion

            #region Query Syntax
            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Like sql
            //In Query Syntax , we write the query in execution order not sql order
            //Select *
            //From Number N
            //Where N % 2 == 1

            //Query syntax ==> Complex queries 
            //Query syntax ==> Readible [Join , GroupBy]

            //1] From , 2] Where , 3] Select
            //Query syntax must begin with from
            //Query syntax must end with [Select , GroupBy]

            //var oddNumbers = from N in Numbers 
            //                 where N % 2 == 1
            //                 select N;

            //foreach(var n in oddNumbers)
            //{
            //    Console.WriteLine(n);
            //}

            #endregion

            #endregion

            #region Linq Execution Ways
            //Deffered execution [10 categories] [Latest version of data]
            //Immediate execution [3 categories] [Casting operators , Element operators , aggregate operators]

            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var OddNumbers = Numbers.Where(X => X % 2 == 1); // 1 3 5 7 9 
            //Numbers.AddRange(new int[] { 11, 12, 13, 14, 15 });
            ////Where ==> Deffered execution
            ////Where ==> Call when i used the sequence OddNumbers
            //foreach(int number in OddNumbers)
            //{
            //        Console.WriteLine(number);
            //}


            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var OddNumbers = Numbers.Where(X => X % 2 == 1).ToList(); // 1 3 5 7 9 
            ////Immediate execution ==> Execute once called
            //// To make deffered linq operator work as immediate [use immediate operator]
            //Numbers.AddRange(new int[] { 11, 12, 13, 14, 15 });
            ////Where ==> Deffered execution
            ////Where ==> Call when i used the sequence OddNumbers
            //foreach (int number in OddNumbers)
            //{
            //    Console.WriteLine(number);
            //}
            #endregion

            #region Data SetUp
            //Console.WriteLine(ProductsList[0]);
            //Console.WriteLine(CustomersList[0]);

            #endregion

            #region Filteration/Restriction Operators [Where - OfType]
            //1 ] Get products out of stock [Fluent , Query]
            //  Where ==> Filteration based on condition 
            //Fluent Syntax
            //var Result = ProductsList.Where(P => P.UnitsInStock == 0); //Readable
            //Query syntax
            /*
             * Select *
             * From ProductList P
             * Where P.UnitInStock == 0
             */
            //Result = from P in ProductsList
            //         where P.UnitsInStock == 0
            //         select P;
            //foreach(var product in Result)
            //{
            //    Console.WriteLine(product);
            //}


            // 2 ] Get products in stock and in category of Meat/Poultry 
            //Fluent Syntax
            //var Result = ProductsList.Where(P => P.UnitsInStock > 0 && P.Category == "Meat/Poultry");
            //foreach (var Product in Result)
            //{
            //    Console.WriteLine(Product);
            //}

            //Query Syntax 
            //var Result = from P in ProductsList
            //             where P.UnitsInStock > 0 && P.Category == "Meat/Poultry"
            //             select P;

            //foreach (var Product in Result)
            //{
            //    Console.WriteLine(Product);
            //}



            //3 ] Get products out of stock in first 10 elements
            //Indexed where[valid Fluent syntax only]
            //var Result = ProductsList.Where((P, I) => P.UnitsInStock == 0 && I < 10);
            //foreach (var Product in Result)
            //{
            //    Console.WriteLine(Product);
            //}


            //4 ] Get products that of type product02
            //var Result = ProductsList.OfType<Product2>();
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Transformation/Projection Operators [Select - Select Many]
            //1 ] Select product name
            //Fluent synatx
            //var Result = ProductsList.Select(P => P.ProductName);
            //foreach (var Product in Result)
            //{
            //    Console.WriteLine(Product);
            //}

            //Query Syntax
            //var Result = from P in ProductsList
            //             select P.ProductName;

            //foreach (var Product in Result)
            //{
            //    Console.WriteLine(Product);
            //}


            //2 ] Select customer name

            //var Result = CustomersList.Select(C => C.CustomerName);
            //var Result2 = from C in CustomersList
            //         select C.CustomerName;
            //foreach(var CustomerName in Result2)
            //{
            //    Console.WriteLine(CustomerName);
            //}

            //3 ] Select customer orders
            //var Result = CustomersList.SelectMany(C => C.Orders);

            //Query Syntax
            //var Result = from C in CustomersList
            //             from O in C.Orders
            //             select O;

            //foreach(var result in Result)
            //{
            //    Console.WriteLine(result);
            //}

            //4 ] Select product id and product name 
            //Fluent
            //var Result = ProductsList.Select(P => new Product { ProductID = P.ProductID , ProductName = P.ProductName});
            //var Result = ProductsList.Select(P => new ProudctNew { ProductId = P.ProductID , ProductName = P.ProductName});
            //var Result = ProductsList.Select(P => new {  P.ProductID ,  P.ProductName});

            //Result = from P in ProductsList
            //             select new
            //             {
            //                 ProductID = P.ProductID,
            //                 ProductName = P.ProductName,
            //             };
            ////Anonymous type by default override to string
            //foreach (var Product in Result)
            //{
            //    Console.WriteLine(Product);
            //}

            //5 ] Select product in stock and apply discount 10 % on its price
            //var Result = ProductsList.Where(P => P.UnitsInStock > 0)
            //    .Select(P => new
            //    {
            //        ProductName = P.ProductName,
            //        OldPrice = P.UnitPrice,
            //        NewPrice = P.UnitPrice - (P.UnitPrice * .01M)
            //    });

            //var Result = from P in ProductsList
            //             where P.UnitsInStock > 0
            //             select new
            //             {
            //                 ProductName = P.ProductName,
            //                 OldPrice = P.UnitPrice,
            //                 NewPrice = P.UnitPrice - (P.UnitPrice * .01M)
            //             };
            //foreach(var result in Result)
            //{
            //    Console.WriteLine(result);
            //}


            //6 ] Select product index and product name for products in stock
            //Fluent syntax only

            //Indexed Select , Indexed Where ==> Valid only with fluent Syntax
            //var Result = ProductsList.Where(P => P.UnitsInStock > 0).Select((P, I) => new
            //{
            //    Index = I,
            //    ProductName = P.ProductName,
            //});
            //foreach (var Item in Result)
            //{
            //     Console.WriteLine(Item);
            //}


            #endregion

            #region Order Operators [Order - OrderDescending - OrderBy - OrderByDescending - ThenBy - ThenByDescending - Reverse]
            //var Result = ProductsList.Order();
            //Result = ProductsList.OrderDescending();
            //var Result = ProductsList.OrderBy(P => P.UnitPrice);
            //var Result = ProductsList.OrderByDescending(P => P.UnitPrice);
            //Sort , order by one col [UnitPrice]
            //var Result = ProductsList.OrderBy(P => P.UnitPrice).ThenByDescending(P => P.UnitsInStock); //Based on coloumns Orderby , ThenBy
            //Sort based on UnitPrice
            //Sort based on UnitInStock

            //var Result = from P in ProductsList
            //             orderby P.UnitPrice descending , P.UnitsInStock descending
            //             select P;
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            //1 ] Get Products Ordered By Price Asc

            //2 ] Get Products Ordered By Price Desc

            //3 ] Get Products Ordered By Price Asc and Number Of Items In Stock
            //var Result = ProductsList.OrderBy(P => P.UnitPrice).Select(P => new
            //{
            //    ProductPrice = P.UnitPrice , 
            //    UnitStock = P.UnitsInStock
            //});
            //foreach(var item in Result)
            //{
            //    Console.WriteLine($"{item}");
            //}

            //4 ] Get Products Out Of Stock In Reversed Order
            //var Result = ProductsList.Where(P => P.UnitsInStock == 0).Reverse(); //Fluent
            //foreach(var product in Result)
            //    Console.WriteLine(product);

            //reverse ==> is only valid with fluent synatx

            #endregion

            #region Element Operators - Immediate execution [First - FirstOrDefault - Last - LastOrDefault - ElementAt - ElementAtOrDefault - Single - SingleOrDefault]

            //If First , Last ==> Empty sequence ==> Throw Exception
            //var Result = ProductsList.First();
            //Result = ProductsList.Last();
            //Result = ProductsList.FirstOrDefault();
            //Result = ProductsList.LastOrDefault();
            //Console.WriteLine(Result?.ProductName ?? "N/A");

            //var Result = ProductsList.FirstOrDefault(new Product() { ProductName = "DefaultProduct", ProductID = 1000 });
            //Result = ProductsList.LastOrDefault(new Product() { ProductName = "Hamada" });

            //Console.WriteLine(Result?.ProductName ?? "N/A");

            //1 OverLoad [first , Last ] ==> 2 OverLoads [FirstOrDefault , LastOrDefault]

            //var Result = ProductsList.First(P => P.UnitPrice == 0);
            //var Result = ProductsList.FirstOrDefault(P => P.UnitPrice == 0);
            //var Result = ProductsList.Last(P => P.UnitPrice == 0);
            //var Result = ProductsList.LastOrDefault(P => P.UnitPrice == 0);

            //var Result = ProductsList.FirstOrDefault(P => P.UnitPrice == 0, new Product() { ProductName = "Product111" });

            //var Result = ProductsList.LastOrDefault(P => P.UnitPrice == 0, new Product() { ProductName = "Product111" });
            //Console.WriteLine(Result?.ProductName);


            //ProductsList = new List<Product>();
            //var Result = ProductsList.ElementAt(1);
            //var Result = ProductsList.ElementAtOrDefault(1);
            //Result = ProductsList.ElementAtOrDefault(new Index(10,true));
            //Result = ProductsList.ElementAtOrDefault(^10); //Syntax Sugar

            //Console.WriteLine(Result);



           // List<Product> DiscountList = new List<Product>() {  };
            //var Result = DiscountList.Single();
            //Result = DiscountList.SingleOrDefault();
            //Console.WriteLine(Result);
            //var Result = ProductsList.Single(P => P.ProductID ==  10000);
            //Console.WriteLine(Result);


            //var Result = ProductsList.SingleOrDefault(P => P.UnitsInStock > 0) ;
            //Console.WriteLine(Result);

            //var Result = DiscountList.SingleOrDefault(new Product() { ProductName = "Hamada", ProductID = 10000 });
            //Console.WriteLine(Result);

            //var Result = DiscountList.SingleOrDefault(P => P.UnitPrice == 0, new Product() { ProductName = "Hamada" });
            //Console.WriteLine(Result);

            //SingleOrDefault overload 2 ==> If Sequence contain unique element , will return single element
            //If there are more than one element , throw exception , Sequence is empty [Condition not match] return default value

            //Single overload 2 ==> If Sequence contain unique element , will return single element
            //If there are more than one element , throw exception , Sequence is empty

            //Single ==> If Sequence contain only one element , Will return single element
            // else Throw exception [More than one element , Empty]

            //SingleOrDefault ==> If Sequence contain only one element , Will return single element
            // else Throw exception [More than one element ]


            //1 ] Find first, last product in product list

            //2 ] Find first , last product that out of stock in product list

            //3 ] Find first , last product that out of stock in product list ,
            //if not found return new product with name = “DefaultProduct”

            //4 ] Find Product at index 0 , 100

            //5 ] Try to find the single product in product list

            //6 ] Find first product that has id  = 10
            // FirstOrDefault , SingleOrDefault

            //var Result1 = ProductsList.FirstOrDefault(P => P.ProductID == 10); //Top 1

            //var Result2 = ProductsList.SingleOrDefault(P => P.ProductID == 10); //Top 2


            //Element operators ==> Valid only with fluent syntax
            //Hybird syntax [fluent syntax ] , [Query syntax]

            //var Result = (from P in ProductsList
            //             where P.UnitsInStock == 0
            //             select P).FirstOrDefault();
            //Console.WriteLine(Result);
            //foreach(var res in Result)
            //{
            //    Console.WriteLine(res);
            //}


            #endregion
        }
    }
}
