using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_OCP_BAD
{
    public class Shape
    {
        public double Width { get; set; }
        public double Length { get; set; }
        public double Radius { get; set; }

        public Shape(double width, double length, double radius)
        {
            Width = width;
            Length = length;
            Radius = radius;
        }

        public double GetArea(ShapeType shapeType)
        {
            double area = 0;

            switch(shapeType)
            {
                case ShapeType.Circle:
                    area = Math.PI * Radius * Radius;
                    break;
                case ShapeType.Square:
                    area = Width * Width;
                    break;
                case ShapeType.Rectangle:
                    area = Width * Length;
                    break;
            }

            return area;
        }
    }
}
