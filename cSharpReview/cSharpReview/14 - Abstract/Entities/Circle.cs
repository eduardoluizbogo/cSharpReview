using cSharpReview._14___Abstract.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpReview._14___Abstract.Entities
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(ColorBBR color) : base(color)
        {
        }

        public Circle(double radius, ColorBBR color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
