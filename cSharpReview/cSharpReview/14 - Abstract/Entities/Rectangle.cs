using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cSharpReview._14___Abstract.Entities.Enum;

namespace cSharpReview._14___Abstract.Entities
{
    internal class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(ColorBBR color) : base(color)
        {

        }

        public Rectangle(double width, double height, ColorBBR color) : base(color)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }
}
