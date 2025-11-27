using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;
using static LinqTwoGroup2.ListGenerator;
namespace LinqTwoGroup2
{

    internal class Program
    {
        class ProductComparer : IComparer<Product>
        {
            public int Compare(Product? x, Product? y)
            {
                return x?.UnitsInStock.CompareTo(y?.UnitsInStock) ?? (y is null ? 0 : -1);
            }
        }
        class StringEqualityComparer : IEqualityComparer<string>
        {
            public bool Equals(string? x, string? y)
            {
                return x?.ToLower().Equals(y?.ToLower()) ?? (y is null ? true : false); 
            }

            public int GetHashCode([DisallowNull] string obj)
            {
                return obj?.ToLower().GetHashCode() ?? 0;
            }
        }
        class ProductEqualityComparer : IEqualityComparer<Product>
        {
            public bool Equals(Product? x, Product? y)
            {
                return x?.UnitPrice.Equals(y?.UnitPrice) ?? y is null ? true : false; 
            }

            public int GetHashCode([DisallowNull] Product obj)
            {
                return obj?.UnitPrice.GetHashCode() ?? 0;
            }
        }
        class ProductComparerTwo : IComparer<int>
        {
            public int Compare(int x, int y)
            {
               return y.CompareTo(x);
            }
        }
        static void Main(string[] args)
        {
            #region Aggregate operators - [Immediate execution] Count , TryGetNonEnumeratedCount
            //1] Get the number of products in the product list
            //var Result = ProductList.Count();
            //Console.WriteLine(ProductList.Count);
            //Console.WriteLine(Result);

            //2] Try to get number of elements in IEnumerable of 100 number
            //IEnumerable<int> Numbers = Enumerable.Range(0, 100);
            //Console.WriteLine(Numbers.Count());


            //3] Get the number of products out of stock 
            //var Result = ProductList.Where(P => P.UnitsInStock == 0).Count();
            //Console.WriteLine(Result);

            //.NET 6.0 GetNonEnumeratedCount
            //4] Get the number of products in product list
            //var Result = ProductList.TryGetNonEnumeratedCount(out int count);
            //Console.WriteLine(Result);
            //Console.WriteLine(count);

            //5] Get the numebr of elements in list [GetNonEnumeratedCount]
            //IEnumerable<int> Numbers = Enumerable.Range(0, 100);
            //bool Result = Numbers.TryGetNonEnumeratedCount(out int Count);

            //Console.WriteLine(Result);
            //Console.WriteLine(Count);

            //var Result = ProductList.TryGetNonEnumeratedCount(out int cnt); //Count property
            //Console.WriteLine(Result);
            //Console.WriteLine(cnt);

            //var Result = ProductList.Where(P => P.UnitsInStock == 0);
            //bool res = Result.TryGetNonEnumeratedCount(out int count);
            //Console.WriteLine(count);


            #endregion

            #region Aggregate operators [Immediate execution] - Sum , Average
            //1] Get the sum of prices of products
            //var Result = ProductList.Sum(P => P.UnitPrice);
            //Console.WriteLine(Result);

            //2] Get the avg price of all products prices
            //var Result = ProductList.Average(P => P.UnitPrice);
            //Console.WriteLine(Result);

            #endregion

            #region Aggregate operators [Immediate execution] - Min , Max , MinBy , MaxBy
            // Max , Min
            //1] Get the max , min product
            //var Result = ProductList.Max();
            //Result = ProductList.Min();
            //Console.WriteLine(Result);

            //2] Get the max , min product based on different condition [ProductComparer]
            //var Result = ProductList.Max(new ProductComparer());
            //Result = ProductList.Min(new ProductComparer());
            //Console.WriteLine(Result);

            //3] Get the max product , min product based on unit in stock [orderby]
            //var Result = ProductList.OrderByDescending(P => P.UnitsInStock).FirstOrDefault();
            //Result = ProductList.OrderBy(P => P.UnitsInStock).FirstOrDefault();
            //Console.WriteLine(Result);


            //.NET 6 MaxBy , MinBy
            //4]Find Max , Min product due to the unit price
            //var Result = ProductList.MaxBy(P => P.UnitPrice);
            //Result = ProductList.MinBy(P => P.UnitPrice);
            //Console.WriteLine(Result);


            //4]Find Max , Min product due to the unit stock
            //var Result = ProductList.MaxBy(P => P.UnitsInStock);
            //Result = ProductList.MinBy(P => P.UnitsInStock);
            //Console.WriteLine(Result);


            //5]Provide different implementation to int compare [Second overload] - [Unit In stock]
            //var Result = ProductList.MaxBy(P => P.UnitsInStock ,new ProductComparerTwo());

            //Result = ProductList.MinBy(P => P.UnitsInStock , new ProductComparerTwo());
            //Console.WriteLine(Result);


            //11 overload to Max , Min
            //6]Find the highest , lowest value of the price in the product prices
            //var Result = ProductList.Max(P => P.UnitPrice);
            //Result = ProductList.Min(P => P.UnitPrice);
            //Console.WriteLine(Result);

            //7]Find the highest , lowest value of the name in the product names
            //var Result = ProductList.Max(P => P.ProductName);
            //Result = ProductList.Min(P => P.ProductName);
            //Console.WriteLine(Result);



            #endregion

            #region Aggregate operators [Immediate execution] - Aggregate
            //  To make custom aggregation function 
            //  Try to combine the names
            // string[] Names = { "Mariam", "Yasser", "Omar", "Mohamed" };
            // string FullName = Names.Aggregate((str1 , str2 ) => $"{str1 + " " + str2}");
            // str1                  str2
            // Mariam                 Yasser
            // Mariam Yasser          Omar
            // Mariam Yasser Omar     Mohamed
            // Marriam Yasser Omar Mohamed
            //  Console.WriteLine(FullName);

            // Second overload ==> Seed value
            // string FullName= Names.Aggregate("Hello" , (str1 , str2) => $"{str1 + " " + str2}");
            // Console.WriteLine(FullName);


            // Third overload
            // string FullName = Names.Aggregate("Hello", (str1, str2) => $"{str1 + " " + str2}", TAcc => TAcc.Replace(" ", "$"));
            // Console.WriteLine(FullName);

            #endregion

            #region Casting/Conversion operators [Immediate execution]
            //1] Get Products out of stock and convert them to list
            //List<Product> Result = ProductList.Where(P => P.UnitsInStock == 0).ToList();

            //2] Get Products out of stock and convert them to array
            //Product[] Result2 = ProductList.Where(P => P.UnitsInStock == 0).ToArray();

            //3] Get Products Id and Products for products out of stock and store them in dictionary

            //4] Get Products Id and Products Names for products out of stock and store them in dictionary //Dictionary<long, Product> Result3 = ProductList.Where(P => P.UnitsInStock == 0).ToDictionary(P => P.ProductID);
            //Dictionary<long, string> Result4 = ProductList.Where(P => P.UnitsInStock == 0).ToDictionary(P => P.ProductID, P => P.ProductName);

            //Dictionary<string, Product> Resul5 = ProductList.Where(P => P.UnitsInStock == 0).ToDictionary(P => P.ProductName, new StringEqualityComparer());

            //Dictionary<string, long> Result6 = ProductList.Where(P => P.UnitsInStock == 0).ToDictionary(P => P.ProductName, P => P.ProductID, new StringEqualityComparer());

            //Custom Equality Comparer ToDictionary

            //5] Get Products out of stock and store them in hashset
            //HashSet<Product> Result7 = ProductList.Where(P => P.UnitsInStock == 0).ToHashSet();
            //HashSet<Product> Result8 = ProductList.Where(P => P.UnitsInStock == 0).ToHashSet(new ProductEqualityComparer());

            //Custom Equality Comparer ToHashSet

            //6]Get products out of stock and store them in  Immutable Sorted Set
            //ImmutableSortedSet< Product> Result9 = ProductList.Where(P => P.UnitsInStock == 0).ToImmutableSortedSet();
            //Result9.Add(new Product { ProductName = "Hamada" });
            //foreach(var item in Result9)
            //    Console.WriteLine(item);
            #endregion

            #region Generation operators [Range - Repeat - Empty]

            //The only operators that you can calling them is to call them through Enumerable class
            //As static method

            //Generate sequence

            //1] Create sequence from 0 to 99
            //var Result = Enumerable.Range(0, 100); // 0 .. 99
            //foreach(var item in Result)
            //{
            //    Console.Write(item + " ");
            //}

            //2] Repeat number 2 ==> 100 
            //var Result = Enumerable.Repeat(2, 100);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item + " ");
            //}

            //3] Generate 100 product with same category
            //var Result = Enumerable.Repeat(new Product() { Category = "MEAT" }, 100);

            //4] Generate empty sequence
            //var Result = Enumerable.Empty<Product>();

            #endregion

            #region Set operators [Union - Concat - Except - Intersect - Distinct]
            // ==> Work based on equals and getHashCode

            //add sequene 0 , 100 , sequence 50 , 100
            //var Sequence1 = Enumerable.Range(0, 100); // 0 .. 99
            //var Sequence2 = Enumerable.Range(50, 100); // 50 .. 149

            //foreach(var x in Sequence1)
            //{
            //    Console.Write(x + " ");
            //}
            //Console.WriteLine();
            //foreach (var y in Sequence2)
            //{
            //    Console.Write(y + " ");
            //}
            //Union
            //1] Merge two sequences without duplications
            //var Result = Sequence1.Union(Sequence2);
            //Result = Sequence1.Concat(Sequence2);
            //Result = Sequence1.Distinct(); // 1 2 1 3 1 4 5 
            //                               //1 2 3 4 5
            //Result = Sequence1.Intersect(Sequence2);
            //Result = Sequence1.Except(Sequence2);
            //Result = Sequence2.Except(Sequence1);

            //foreach (var item in Result)
            //{
            //    Console.Write(item +" ");
            //}
            //Concat
            //2] Merge two sequences with duplications

            //Distinct
            //3] Remove duplicates

            //Intersect
            //4] Get the common between two sequences

            //Except
            //5] Get the elements in seq01 and not in seq02



            //Two sequences of products
            //var Seq01 = new List<Product>()
            //{
            //    new Product() { ProductID = 1, ProductName = "Chai", Category = "Beverages", UnitPrice = 18.00M, UnitsInStock = 100},
            //    new Product() { ProductID = 2, ProductName = "Chang", Category = "Beverages", UnitPrice = 19.0000M, UnitsInStock = 17 },
            //    new Product() { ProductID = 2, ProductName = "Chang", Category = "Beverages", UnitPrice = 19.0000M, UnitsInStock = 17 },
            //    new Product() { ProductID = 3, ProductName = "Aniseed Syrup", Category = "Condiments", UnitPrice =  10.0000M, UnitsInStock = 13 },
            //};
            //
            //var Seq02 = new List<Product>()
            //{
            //    new Product() { ProductID = 1, ProductName = "Chai", Category = "Beverages", UnitPrice = 18.00M, UnitsInStock = 100},
            //    new Product() { ProductID = 3, ProductName = "Aniseed Syrup", Category = "Condiments", UnitPrice = 10.0000M, UnitsInStock = 13 },
            //    new Product() { ProductID = 4, ProductName = "Chef Anton's Cajun Seasoning", Category = "Condiments", UnitPrice = 22.0000M, UnitsInStock = 53 },
            //    new Product() { ProductID = 5, ProductName = "Chef Anton's Gumbo Mix", Category = "Condiments", UnitPrice = 21.3500M, UnitsInStock = 17 },
            //
            //};

            //var Result = Seq01.Union(Seq02);

            //Result = Seq01.Union(Seq02, new ProductEqualityComparer());

            //foreach (var Product in Result)
            //{
            //    Console.WriteLine(Product);
            //}

            //var Result = Seq01.UnionBy(Seq02, P => P.UnitPrice);
            //foreach (var Product in Result)
            //{
            //    Console.WriteLine(Product);
            //}

            //Merge the 2 sequences with removing duplicates [Because override equals , gethashcode] [Union]



            //Merge the 2 sequences with removing duplicates provide new implementation to equals , gethashcode [Union]


            //Merge the 2 seuqneces using union by , provide the property to check duplicated based on it 


            //Find the common products in the 2 sequences based on unit price [Intersect]
            //var Result = Seq01.Intersect(Seq02);
            //Result = Seq01.Intersect(Seq02, new ProductEqualityComparer());
            //var Result = Seq01.IntersectBy(Seq02.Select(P => P.UnitsInStock), P => P.UnitsInStock);
            // foreach (var Product in Result)
            // {
            //     Console.WriteLine(Product);
            // }


            //Find the common products in the 2 sequnces based on unit price [Intersectby]


            //Find the products in the sequnce1 and not in sequence 2 based on unit price [Except]
            //var Result = Seq01.Except(Seq02,new ProductEqualityComparer());
            //Result = Seq01.ExceptBy(Seq02.Select(p => p.UnitPrice), P => P.UnitPrice);
            //foreach (var Product in Result)
            // {
            //     Console.WriteLine(Product);
            // }

            //Find the products in the sequnce1 and not in sequence 2 based on unit price [ExceptBy]


            //Find the distinct products based on productName
            //var Result = Seq01.Distinct(new ProductEqualityComparer());
            //Result = Seq01.DistinctBy(P => P.UnitPrice);
            //foreach(var item in Result)
            //    Console.WriteLine(item);

            #endregion

            #region Quantifier operators [Any - All - SequenceEqual - contains]
            //Return boolean values

            //Determine whether the sequence contain any element or not
            //ProductList = new List<Product>();
            //Console.WriteLine(ProductList.Any());
            //Determine whether the sequence contain any element that has UnitInStock == 0
            //Console.WriteLine(ProductList.Any( P => P.UnitsInStock == 5003030));

            //Determine whether all the elements is unit in stock > 0
            //Console.WriteLine(ProductList.All(P => P.UnitsInStock > 0));

            //Determine whether contains specific product or not
            //Console.WriteLine(ProductList.Contains(new Product
            //{
            //    ProductID = 2,
            //    ProductName = "Chang",
            //    Category = "beverages",
            //    UnitPrice = 19.0000M,
            //    UnitsInStock = 17
            //}));


            //Determine whether seq1 equals seq2 or not
            //IEnumerable<int> Seq1 = Enumerable.Range(0, 100);
            //IEnumerable<int> Seq2 = Enumerable.Range(50, 100);
            //Console.WriteLine(Seq1.SequenceEqual(Seq2));

            //var Seq01 = new List<Product>()
            //{
            //    new Product() { ProductID = 1, ProductName = "Chai", Category = "Beverages", UnitPrice = 18.00M, UnitsInStock = 100},
            //    new Product() { ProductID = 2, ProductName = "Chang", Category = "Beverages", UnitPrice = 19.0000M, UnitsInStock = 17 },
            //    new Product() { ProductID = 3, ProductName = "Aniseed Syrup", Category = "Condiments", UnitPrice = 10.0000M, UnitsInStock = 13 },
            //};

            //var Seq02 = new List<Product>()
            //{
            //    new Product() { ProductID = 1, ProductName = "Chai", Category = "Beverages", UnitPrice = 18.00M, UnitsInStock = 100},
            //    new Product() { ProductID = 3, ProductName = "Chef Anton's Cajun Seasoning", Category = "Condiments", UnitPrice = 19.0000M, UnitsInStock = 53 },
            //    new Product() { ProductID = 2, ProductName = "Aniseed Syrup", Category = "Condiments", UnitPrice = 10.0000M, UnitsInStock = 13 },
            //};

            //Console.WriteLine(Seq01.SequenceEqual(Seq02,new ProductEqualityComparer()));
            #endregion

            #region Transformation operators - Zip
            //1] Create list of strings , array numbers

            //string[] Names = { "Ten", "Tweeny", "Thirty", "Fourty" }; 
            //int[] Numbers = { 10, 20, 30, 40, 50, 60 };

            //var Result = Names.Zip(Numbers); //("Ten",10) , ("Tweny",20)
            ////foreach(var item in Result)
            ////{
            ////    Console.WriteLine(item);
            ////}
            //var Result2= Names.Zip(Numbers, new int[] { 100, 200, 300, 400 });
            ////foreach(var item in Result2)
            ////{ Console.WriteLine(item); }

            //var Result3 = Names.Zip(Numbers, (N, Num) => $"{N} :: {Num}");
            //foreach(var item in Result3)
            //    Console.WriteLine(item);
            ////2] Try to zip the 2 sequences

            ////3] Try to zip 3 sequences 


            ////4] Try to specify the result selector


            #endregion

            #region Grouping operators - [Groupby - chunk]
            //1] Try to make groups of products based on category [Fluent - Query]
            //var Result = from P in ProductList
            //             group P by P.Category;
            //Result = ProductList.GroupBy(P => P.Category);
            //foreach(var item in Result)
            //{
            //    Console.WriteLine("**************" + item.Key);
            //    foreach(var product in item)
            //    {
            //        Console.WriteLine(product);
            //    }
            //}

            //2] Write a LINQ query to find product categories that have products in stock and each gro
            //   has more than 10 products,
            //   and return the category name along with the count of products. [Fluent - Query]
            //var Result = from P in ProductList
            //             where P.UnitsInStock > 0
            //             group P by P.Category
            //             into ProdGroup
            //             where ProdGroup.Count() > 10
            //             select new
            //             {
            //                 ProductCategory = ProdGroup.Key,
            //                 ProductCount = ProdGroup.Count()
            //             };
            //Result = ProductList.Where(P => P.UnitsInStock > 0).GroupBy(P => P.Category)
            //    .Where(ProdGrp => ProdGrp.Count() > 10).Select(ProdGrp => new
            //    {
            //        ProductCategory = ProdGrp.Key,
            //        ProductCount = ProdGrp.Count()
            //    });
            //foreach(var item in Result)
            //{
            //    Console.WriteLine(item);
            //}




            //Overloads
            //3] Group by based on Category [Provide default equality comparer]
            //var Result = ProductList.GroupBy(P => P.Category, new StringEqualityComparer());
            //foreach(var item in Result)
            //{
            //    Console.WriteLine("**************" + item.Key);
            //    foreach(var product in item)
            //    {
            //        Console.WriteLine(product);
            //    }
            //}

            //var Result = ProductList.GroupBy(P => P.Category , P => P.ProductName);
            //var Result = ProductList.GroupBy(P => P.Category, P => P.ProductName,new StringEqualityComparer());
            //var Result = ProductList.GroupBy(P => P.Category, (P) => new {P.ProductID , P.ProductName} , new StringEqualityComparer());
            //var Result = ProductList.GroupBy(P => P.Category, P => new {ProductId = P.ProductID , ProductName = P.ProductName}, (C,P) => new {C = C , P = P.Count()} , new StringEqualityComparer());



            //foreach (var item in Result)
            //{
            //    Console.WriteLine("**************" + item.C);
            //    Console.WriteLine(item.P);
            //}


            //4] Group by based on Category [Select only products names as values]

            //5] Group by based on Category [Select only products names and ids as values]


            //6] Group by based on category [select the key as category and count as values [element selector]]


            //7] Group by based on category [select only products names and ids as values and
            //   select the element &result selector ] 



            //Chunk 
            //https://blog.nimblepros.com/blogs/new-linq-apis/

            //var fruits = new[] { "Banana", "Pear", "Apple", "Orange", "Plum", "Lemon" , "Watermelon" };
            //var chunks = fruits.Chunk(2);
            //foreach(var chunk in chunks)
            //{
            //    foreach(var item in chunk)
            //        Console.Write(item + " ");
            //    Console.WriteLine();
            //}

            #endregion

            #region Partinioning operators [Take - Skip - TakeLast - SkipLast - TakeWhile - SkipWhile]

            //1] Get the first , last 3 products out of stock
            //var Result = ProductList.Where(P => P.UnitsInStock == 0).Take(3);
            //Result = ProductList.Where(P => P.UnitsInStock == 0).TakeLast(3);
            //foreach(var Product in Result)
            //{
            //    Console.WriteLine(Product);
            //}



            //2] Skip the first , last 5 products out of stock
            //var Result = ProductList.Where(P => P.UnitsInStock == 0).Skip(2);
            //Result = ProductList.Where(P => P.UnitsInStock == 0).SkipLast(2);
            //foreach(var Product in Result)
            //{
            //    Console.WriteLine(Product);
            //}

            //3] Pagination 
            // 10 Products [PageSize] , PageIndex [4]
            //int PageIndex = 4, PageSize = 10;

            //var Result = ProductList.Skip((PageIndex - 1) * PageSize).Take(PageSize);

            //foreach(var Product in Result)
            //{
            //    Console.WriteLine(Product);
            //}

            //4] Take numbers starting from the beginning of the array until a number is hit that is
            //int[] Numbers = { -1, -2, -3, 1, 20, 4 };
            //var Result = Numbers.TakeWhile((n, i) => n < i);
            //foreach(var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            ///5] Get the elements of the array starting from the first element divisible by 3.
            //int[] Numbers = { 1, 2, 10, 3, 20, 4 };
            //var Result = Numbers.SkipWhile(n => n % 3 != 0);
            //foreach(int n in Result)
            //{
            //    Console.WriteLine(n);
            //}

            #endregion

            #region Let & Into  
            // aeiouAEIOU
            //string[] Names = { "Mariam", "Mohamed", "Mahmoud", "Mostafa", "Abderlhman" };
            //var Result = from N in Names
            //             select Regex.Replace(N, "[aeiouAEIOU]", "")
            //             into NonVowelName
            //             where NonVowelName.Length >= 3
            //             select NonVowelName;

            //Result = from N in Names
            //         let NonVowelName  = Regex.Replace(N , "[aeiouAEIOU]" , "")
            //         where NonVowelName.Length >= 3
            //         select NonVowelName;


            //foreach(var name in Result)
            //    Console.WriteLine(name);
            
            
            #endregion
        }
    }
}
