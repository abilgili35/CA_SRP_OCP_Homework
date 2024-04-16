using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_OCP_VALIDATE
{
    public class Square : Shape
    {
        public double Width { get; set; }

        public Square(double width)
        {
            Width = width;
        }

        public override double GetArea()
        {
            return Width * Width;
        }
    }
}
