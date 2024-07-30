using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace cSharpReview._13___Inh._and_Poly.Entities
{
    internal class ProductCommon
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public ProductCommon()
        {
        }

        public ProductCommon(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            return Name + " $ " + Price;
        }
    }
}
