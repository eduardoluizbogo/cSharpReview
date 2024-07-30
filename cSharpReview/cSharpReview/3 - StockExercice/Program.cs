using System.Globalization;

//Exercício sobre métodos, ToString, Override, Constutores, Initialize directly w/out a constructor
namespace cSharpReview.StockExercice
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Entre com os dados do produto: ");
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Preco: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Stock product1 = new Stock(nome, preco);

            Stock product2 = new Stock {Name = "TV", Price = 500.0, Quantity = 5 };


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
