using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpReview.StockExercice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stock product1 = new Stock();

            Console.WriteLine("Entre com os dados do produto: ");
            Console.WriteLine("Nome: ");
            product1.Name = Console.ReadLine();
            Console.WriteLine("Preco: ");
            product1.Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantidade: ");
            product1.Quantity = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + product1.ToString());

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int add = int.Parse(Console.ReadLine());
            product1.AdicionarProdutos(add);

            Console.WriteLine("Dados do produto: " + product1.ToString());

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            int rem = int.Parse(Console.ReadLine());
            product1.RemoverProdutos(rem);

            Console.WriteLine("Dados do produto: " + product1.ToString());

        }
    }
}
