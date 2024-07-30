using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpReview._13___Inh._and_Poly.Entities
{
    internal class ImportedProduct : ProductCommon
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(double customsFee, string name, double price) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        { 
            return Price + CustomsFee;
        }

        public override string PriceTag()
        {
            return Name + " $ " + TotalPrice() + " (Customs fee: $ " + CustomsFee + ")";
        }
    }
}
