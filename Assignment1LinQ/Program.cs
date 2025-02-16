using System.Linq;
using System.Threading;
using LinqDemo;
using static LinqDemo.ListGenerator;
namespace Assignment1LinQ
{
    internal class Program
    {
        private static string zero;

        static void Main(string[] args)
        {
            #region LINQ - Restriction Operators
            //1
            //var result = ProductList.Where(Product => Product.UnitsInStock == 0);
            //foreach (var item in result)
            //    Console.WriteLine(item);

            //2
            //var result = ProductList.Where(Product => Product.UnitsInStock != 0 && Product.UnitPrice > 3.00m);                      
            //foreach (var item in result)
            //    Console.WriteLine(item);

            //3
            //String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var result = Arr
            //.Select((name, index) => new { Name = name, Value = index }) 
            //.Where(item => item.Name.Length < item.Value) 
            //.Select(item => item.Name); 

            //foreach (var digit in result)
            //{
            //    Console.WriteLine(digit);
            //}
            #endregion

            #region LINQ - Ordering Operators

            //1
            //var result = ProductList.OrderBy(product => product.ProductName);
            //foreach(var item in result) 
            //    Console.WriteLine(item);


            //2
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result=Arr.OrderBy(x=> x, StringComparer.OrdinalIgnoreCase);
            //foreach(var item in result) 
            //    Console.WriteLine(item);


            //3
            //var result = ProductList.OrderByDescending(product => product.UnitsInStock);
            //foreach (var item in result)
            //    Console.WriteLine(item);


            //4
            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            //var result = Arr.OrderBy(x => x.Length).OrderBy(x => x);
            //foreach (var x in result) 
            //    Console.WriteLine(x);

            //5
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            // var result=Arr.OrderBy(x => x.Length).OrderBy(x=>x,StringComparer.OrdinalIgnoreCase);
            //foreach(var x in result) 
            //    Console.WriteLine(x);

            //6
            //var result = ProductList.OrderByDescending(Product => Product.Category).OrderByDescending(product => product.UnitPrice);
            //foreach (var item in result) 
            //    Console.WriteLine(item);

            //7
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result = Arr.OrderBy(x => x.Length).OrderByDescending(x => x, StringComparer.OrdinalIgnoreCase);
            //foreach(var x in result) 
            //    Console.WriteLine(x);

            //8
            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            //int[] digits = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //var result = new System.Collections.Generic.List<int>();

            //for (int i= 0;i < Arr.Length; i++)
            //{
            //    if (Arr[i].Length >1 && Arr[i][1] =='i')
            //    {
            //        result.Add(digits[i]);
            //    }
            //}
            //result.Reverse();
            //Console.WriteLine(string.Join(", ",result));

            #endregion


            #region LINQ – Transformation Operators

            //1
            //var result = ProductList.Select(x => x.ProductName);
            //foreach (var item in result)
            //    Console.WriteLine(item);

            //2
            //String[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var uppercase = new { index1="APPLE", index2="BLUEPERRY", index3="CHERRY" };
            //var lowercase = new { index1 = "apple", index2 = "blueperry", index3 = "cherry" };

            //3


            //4
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result=Arr.Where((x,Index)=>)

            #endregion




        }
    }
}
