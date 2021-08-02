using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.LiskovSubstitutionPrinciple__LSP_
{
    public class Rectangle : Shape
    {
        public double height { get; set; }
        public double width { get; set; }
        public Rectangle(double height, double width)
        {
            this.height = height;
            this.width = width;
        }
        public override double Area()
        {
            return height * width;
        }
    }
}
