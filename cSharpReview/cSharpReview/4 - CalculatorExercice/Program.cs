using System.Globalization;

//Exercício sobre membros estáticos de classe e membros de instância
namespace cSharpReview.CalculatorExercice
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            Calculadora calc = new Calculadora();
            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);
            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
