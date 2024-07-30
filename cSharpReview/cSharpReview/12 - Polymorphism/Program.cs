using cSharpReview._12___Polymorphism.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpReview._12___Polymorphism
{
    internal class Program
    {
        public static void Main1(string[] args)
        {
            List<Employee> list = new List<Employee>();
            Console.WriteLine("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Employee #" + i + " data: ");
                Console.Write("Outsorced (y/n)? ");
                char outsourced = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("ValuePerHours: ");
                double valuePerHours = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (outsourced == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee(additionalCharge, name, hours, valuePerHours));
                }else if(outsourced == 'n')
                {
                    list.Add(new Employee(name, hours, valuePerHours));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");

            foreach (Employee emp in list)
            {
                Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}