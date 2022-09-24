namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double side1;
            double side2;
            Console.Write("Side 1:");
            side1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Side 2:");
            side2 = Convert.ToDouble(Console.ReadLine());
            Rectangle rectangle = new Rectangle(side1,side2);
            rectangle.PerimeterCalculator();
            rectangle.AreaCalculator();
            Console.WriteLine($"Perimeter is - {rectangle.Perimeter}");
            Console.WriteLine($"Area is - {rectangle.Area}");
        }
    }
}