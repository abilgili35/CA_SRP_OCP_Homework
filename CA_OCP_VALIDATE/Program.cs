namespace CA_OCP_VALIDATE
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Square square = new Square(2);
            Rectangle rectangle = new Rectangle(3, 5);
            Circle circle = new Circle(6);

            Console.WriteLine($"Square Area : {square.GetArea()}");
            Console.WriteLine($"Rectangle Area : {rectangle.GetArea()}");
            Console.WriteLine($"Circle Area : {circle.GetArea()}");

            Console.Read();

        }
    }
}
