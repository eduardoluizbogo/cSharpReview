using System.Globalization;

namespace cSharpReview.Encapsulation
{
    internal class Stock
    {
        private string _name;
        private double _price;
        public int Quantity { get; private set; }
        // Constructors
        public Stock()
        {
        }

        public Stock(string nome, double preco)
        {
            _name = nome;
            _price = preco;
            Quantity = 0; //unnecessary
        }
        public Stock(string nome, double preco, int quantidade)
        {
            _name = nome;
            _price = preco;
            Quantity = quantidade;
        }

        // Customized properties
        public string Name
        { 
            get {return _name;}
            set {
                if(value != null && value.Length > 1)
                    _name = value;
                }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        // Methods
        public double ValorTotalEmEstoque()
        {
            return _price * Quantity;
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
            return _name
            + ", $ "
            + _price.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantity
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
