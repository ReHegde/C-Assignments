using System;

namespace Assignment1e
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, Area,Circumference;
            const double PI = 3.14;
            Console.WriteLine("Enter Radius Of Circle");
            r = Convert.ToDouble(Console.ReadLine());
            Area = PI * r * r;
            Circumference = 2 * PI * r;
            Console.WriteLine(" Area of Circle : {0},Circumference : {1} ", + Area, Circumference);
        }
    }
}
