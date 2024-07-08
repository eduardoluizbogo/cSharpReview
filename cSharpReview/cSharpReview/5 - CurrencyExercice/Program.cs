using System.Globalization;

//Recap membros estaticos
namespace cSharpReview.CurrencyExercice
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            //Can't use instance like ConversoDeMoeda x = new ConversorDeMoeda(); static methods and attributes can only
            //be accessed using the class name directly
            Console.WriteLine("Qual a cotacao do dollar?");
            ConversorDeMoeda.Cambio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantos dolares voce vai comprar?");
            ConversorDeMoeda.Quant = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Valor a ser pago em reais: " + ConversorDeMoeda.DollarToReal());



        }

    }
}
