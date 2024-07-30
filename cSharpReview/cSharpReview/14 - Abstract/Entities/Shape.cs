using cSharpReview._14___Abstract.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpReview._14___Abstract.Entities
{
    internal abstract class Shape
    {
        public ColorBBR Color { get; set; }

        protected Shape(ColorBBR color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
