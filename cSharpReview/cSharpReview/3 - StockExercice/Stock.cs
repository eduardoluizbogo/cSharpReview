using System.Globalization;

namespace cSharpReview.StockExercice
{
    internal class Stock
    {
        public string Name;
        public double Price;
        public int Quantity;

        public Stock()
        {
        }

        public Stock(string nome, double preco)
        {
            Name = nome;
            Price = preco;
            Quantity = 0; //unnecessary
        }
        public Stock(string nome, double preco, int quantidade)
        {
            Name = nome;
            Price = preco;
            Quantity = quantidade;
        }

        public double ValorTotalEmEstoque()
        {
            return Price * Quantity;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantity += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantity -= quantidade;
        }

        public override string ToString()
        {
            return Name
            + ", $ "
            + Price.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantity
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
