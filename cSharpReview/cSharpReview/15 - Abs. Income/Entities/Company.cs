using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpReview._15___Abs._Income.Entities
{
    internal class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company(int numberOfEmployees, string name, double anualIncome) : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            double tax = 0;
            if(NumberOfEmployees <= 10)
            {
                tax = AnualIncome * 0.16;
            }else
            {
                tax = AnualIncome * 0.14;
            }

            return tax;
        }
    }
}
