

namespace CA_OCP_BAD
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Shape shape = new Shape(3, 4, 5);

            Console.WriteLine($"Square Area : {shape.GetArea(ShapeType.Square)}");
            Console.WriteLine($"Rectangle Area : {shape.GetArea(ShapeType.Rectangle)}");
            Console.WriteLine($"Circle Area : {shape.GetArea(ShapeType.Circle)}");

            Console.Read();

        }

        
    }
}
