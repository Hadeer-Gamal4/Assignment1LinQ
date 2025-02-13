using LinqDemo;
using static LinqDemo.ListGenerator;
namespace Assignment1LinQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = ProductList.Where(Product => Product.UnitsInStock == 0);
            foreach (var item in result)
                Console.WriteLine(result);
        }
    }
}
