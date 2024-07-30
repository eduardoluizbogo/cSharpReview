using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpReview._15___Abs._Income.Entities
{
    internal class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(double healthExpenditures, string name, double anualIncome) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double tax = 0;
            if(AnualIncome < 20000.00)
            {
                tax = AnualIncome * 0.15;
            }else
            {
                tax = AnualIncome * 0.25;
            }
            if(HealthExpenditures > 0)
            {
                tax = tax - (HealthExpenditures * 0.5);
            }

            return tax;
        }
    }
}
