using System;
using System.Numerics;
namespace CW04c
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                if (args[0] == "/?")
                {
                    Console.WriteLine("Wprowadz trzy kolejne liczby będące współczynnikami równania kwadratowego.");
                }
                else
                {
                    bool isEveryInputDigit = true;
                    for (int i = 0; i < args.Length; i++)
                    {
                        double.TryParse(args[i], out double j);
                        if (args[i] != "0" && j == 0)
                        {
                            Console.WriteLine("Argument nr. " + (i + 1) + " nie jest liczbą");
                            isEveryInputDigit = false;
                        }
                    }
                    if (isEveryInputDigit)
                    {
                        double.TryParse(args[0], out double a);
                        double.TryParse(args[1], out double b);
                        double.TryParse(args[2], out double c);
                        Calculate(a, b, c);
                    }

                }
            }
            else if (args.Length < 3)
            {
                Console.WriteLine("Wprowadzono za mało liczb. Wpisz /? aby uzyskać pomoc.");
            }
            else if (args.Length > 3)
            {
                Console.WriteLine("Wprowadzono za dużo liczb. Wpisz /? aby uzyskać pomoc.");
            }

        }
        public static void Calculate(double a, double b, double c)
        {
            double delta = b * b - 4 * a * c;
            Console.WriteLine("Delta: " + delta);
            if (delta > 0)
            {
                double x1, x2;
                x1 = (-b - Math.Sqrt(delta)) / 2 * a;
                x2 = (-b + Math.Sqrt(delta)) / 2 * a;
                Console.WriteLine("Rozwiązania równania kwadratowego to: " + x1 + " oraz " + x2);
            }
            else if (delta < 0)
            {
                Console.WriteLine("Równanie kwadratowe nie ma rozwiązań");
            }
            else
            {
                double x = -b / 2 * a;
                Console.WriteLine("Rozwiązanie tego równania to: " + x);
            }

        }

    }
}
