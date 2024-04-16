using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_OCP_VALIDATE
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius) 
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Radius * Radius * Math.PI;
        }
    }
}
