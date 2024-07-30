using System.Globalization;

using cSharpReview._15___Abs._Income.Entities;

namespace cSharpReview._15___Abs._Income
{
    internal class Program
    {
        public static void Main1(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual income: ");
                double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healtExpeditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(healtExpeditures, name, income));
                }
                else if(ch == 'c')
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Company(numberOfEmployees, name, income));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            double totalTax = 0;
            foreach (TaxPayer payer in list)
            {
                Console.WriteLine(payer.Name + ": $ " + payer.Tax().ToString("F2", CultureInfo.InvariantCulture));
                totalTax += payer.Tax();
            }
            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + totalTax);
        }
    }
}
