using System;
using System.Numerics;
namespace RównanieKwadratowe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a =");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("c =");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine($"Równanie: {a}x^2 + {b}x + {c} = 0");

            double delta = b * b - 4 * a * c;
            if(delta > 0)
            {
                Complex x1 = (-b - Complex.Sqrt(delta)) / (2 * a);
                Complex x2 = (-b + Complex.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"Rozwiązania: x1 = {x1}   x2 = {x2}");
            }
            else if(delta == 0)
            {
                Complex x = -b / 2 * a;
                Console.WriteLine($"Rozwiązanie tego równania to: {x}");
            }
            else
            {
                Console.WriteLine("Równanie kwadratowe nie ma rozwiązań");
            }
        }
    }
}
