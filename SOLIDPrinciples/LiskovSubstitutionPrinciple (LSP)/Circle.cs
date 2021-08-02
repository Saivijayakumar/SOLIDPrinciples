using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.LiskovSubstitutionPrinciple__LSP_
{
    public class Circle : Shape
    {
        public double radius { get; set; }
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double Area()
        {
            return radius * radius * Math.PI;
        }
    }
}
