namespace DemoProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Rectangle area for rectangle with sides 2 and 3 is:");
            Console.Write(GetRectangleArea(2,3));

            Console.WriteLine("Sqare area for square with side 2 is:");
            Console.Write(GetSqareArea(2));

            Console.WriteLine("Sqare area for square with side 3 is:");
            Console.Write(GetSqareArea(2));
        }

        public static double GetRectangleArea(double a, double b)
        {
            double area = a * b;

            return area;
        }

        public static double GetSqareArea(double a)
        {
            double area = a * a;

            return area;
        }
    }
}