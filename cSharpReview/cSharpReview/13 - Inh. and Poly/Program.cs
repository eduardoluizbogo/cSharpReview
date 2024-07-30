using cSharpReview._13___Inh._and_Poly.Entities;
using System.Globalization;

//This program was made to train inheritance and polymorphism
namespace cSharpReview._13___Inh._and_Poly
{
    internal class Program
    {
        public static void Main1(string[] args)
        {
            List<ProductCommon> listProduct = new List<ProductCommon>();
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Product #" + i + " data");
                Console.Write("Common, used or imported (c/u/i)? ");
                char mode = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (mode == 'c')
                {
                    listProduct.Add(new ProductCommon(name, price));
                }
                else if (mode == 'u')
                {
                    Console.Write("Manufacture date: ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    listProduct.Add(new UsedProduct(date, name, price));
                }
                else if (mode == 'i')
                {
                    Console.Write("Customs fee: ");
                    double fee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    listProduct.Add(new ImportedProduct(fee, name, price));
                }
            }
            Console.WriteLine("PRICE TAGS: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(listProduct[i].PriceTag().ToString());
            }
        }
    }
}
