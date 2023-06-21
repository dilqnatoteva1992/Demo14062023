namespace DemoProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Rectangle area for rectangle with sides 2 and 3 is:");
            Console.Write(GetRectangleArea(2, 3));

            Console.WriteLine("Sqare area for square with side 2 is:");
            Console.Write(GetSqareArea(2));

            Console.WriteLine("Sqare area for square with side 3 is:");
            Console.Write(GetSqareArea(2));

            Console.WriteLine("Area for circle with radious 3 is:");
            Console.Write(GetCircleArea(2));

            Console.WriteLine("Perimeter for cube with side 3 is:");
            Console.Write(GetCubePerimeter(3));
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

        public static double GetAreaOfCube(double side)
        {
            return GetSqareArea(side) * 6;
        }

        public static double GetAreaOfTriangle(double a, double ha)
        {
            return (a * ha) / 2;
        }

        public static double GetCircleArea(double radious)
        {
            double area = Math.PI * radious * radious;

            return area;
        }

        public static double GetCubePerimeter(double a)
        {
            double perimeter = 4 * a;

            return perimeter;
        }

        public static double RectanglePerimeter(double a, double b)
        {
            return 2 * a + 2 * b;
        }
    }
}