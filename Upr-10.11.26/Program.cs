namespace Upr_10._11._26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region PointCoordinates

            //Console.WriteLine("Enter point coordinates:");
            //double x = double.Parse(Console.ReadLine());
            //double y = double.Parse(Console.ReadLine());

            //if(x> 0 && y > 0)
            //{
            //    Console.WriteLine("Point is in the first quadrant.");
            //}
            //else if (x < 0 && y > 0)
            //{
            //    Console.WriteLine("Point is in the second quadrant.");
            //}
            //else if (x < 0 && y < 0)
            //{
            //    Console.WriteLine("Point is in the third quadrant.");
            //}
            //else if (x > 0 && y < 0)
            //{
            //    Console.WriteLine("Point is in the fourth quadrant.");
            //}
            //else
            //{
            //    Console.WriteLine("Point is on an axis.");
            //}
            #endregion

            #region LinearEquation
            //double a, b;
            //Console.WriteLine("Enter coefficients for the linear equation (ax + b = 0):");
            //Console.Write("a = ");
            //a = double.Parse(Console.ReadLine());
            //Console.Write("b = ");
            //b = double.Parse(Console.ReadLine());
            //if(a == 0)
            //{
            //    if (b == 0)
            //    {
            //        Console.WriteLine("The equation has infinitely many solutions.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("The equation has no solution.");
            //    }
            //}
            //else
            //{
            //    double xSolution = -b / a;
            //    Console.WriteLine($"The solution of the equation is x = {xSolution}");
            //}            
            #endregion

            #region quadraticEquation
            double a, b, c;
            Console.WriteLine("Enter coefficients for the quadratic equation (ax^2 + bx + c = 0):");
            Console.Write("a = ");
            a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            c = double.Parse(Console.ReadLine());

            if(a == 0)
            {
                // If a is 0, the equation becomes linear (bx + c = 0)
                if (b == 0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine("The equation has infinitely many solutions.");
                    }
                    else
                    {
                        Console.WriteLine("The equation has no solution.");
                    }
                }
                else
                {
                    double xSolution = -c / b;
                    Console.WriteLine($"The solution of the equation is x = {xSolution}");
                }
            }
            else
            {
                double discriminant = Math.Pow(b, 2) - 4 * a * c;
                if (discriminant > 0)
                {
                    double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                    Console.WriteLine($"The equation has two distinct real roots: x1 = {x1}, x2 = {x2}");
                }
                else if (discriminant == 0)
                {
                    double x = -b / (2 * a);
                    Console.WriteLine($"The equation has one real root: x = {x}");
                }
                else
                {
                    Console.WriteLine("The equation has no real roots.");
                }
            }
            #endregion
            #region triangleType
            bool isValid = a>0 && b > 0 && c > 0 && (a + b > c) && (a + c > b) && (b + c > a);
            if(isValid)
            {
                if (a == b && b == c)
                {
                    Console.WriteLine("The triangle is equilateral.");
                }
                else if (a == b || b == c || a == c)
                {
                    Console.WriteLine("The triangle is isosceles.");
                }
                else
                {
                    Console.WriteLine("The triangle is scalene.");
                }
                double perimeter = a + b + c;
                double semiPerimeter = perimeter / 2;
                double area = Math.Sqrt(semiPerimeter * (semiPerimeter - a) * (semiPerimeter - b) * (semiPerimeter - c));
                Console.WriteLine($"The perimeter of the triangle is: {perimeter}");
                Console.WriteLine($"The area of the triangle is: {area}");
            }
            else
            {
                Console.WriteLine("The given lengths do not form a valid triangle.");
            }
            #endregion
        }
    }
}
