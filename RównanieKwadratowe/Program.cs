using System;
using System.Numerics;
namespace RównanieKwadratowe
{
    class Program
    {

        static (double x1, double x2)? rozwiążRównanieKwadratowe(double a, double b, double c)
        {
            double delta = b * b - 4 * a * c;

            if (delta >= 0)
            {
                double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                return (x1, x2);
            }
            else return null;
        }

        static double wczytajLiczbę(string zachęta)
        {
            double? liczba = null;
            do
            {
                try
                {
                    Console.WriteLine(zachęta + " ");
                    string s = Console.ReadLine();
                    liczba = double.Parse(s);
                }
                catch
                {
                    liczba = null;
                    Console.Error.WriteLine("Niepoprawny łańcych. Wprowadź liczbę jeszcze raz");
                }
            }
            while(!liczba.HasValue);
            return liczba.Value;
        }
        static void Main(string[] args)
        {
            try
            {
                //  Console.WriteLine("a =");
                // double a = double.Parse(Console.ReadLine());
                //  Console.WriteLine("b = ");
                // double b = double.Parse(Console.ReadLine());
                // Console.WriteLine("c =");
                //  double c = double.Parse(Console.ReadLine());

                double a = wczytajLiczbę("a== ");
                double b = wczytajLiczbę("b== ");
                double c = wczytajLiczbę("c== ");

                Console.WriteLine($"Równanie: {a}x^2 + {b}x + {c} = 0");

                (double x1, double x2)? rozwiazanie = rozwiążRównanieKwadratowe(a, b, c);
                if(rozwiazanie.HasValue)
                {
                    Console.WriteLine("Rozwiązania x1 = " + rozwiazanie.Value.x1 + ", x2 = " + rozwiazanie.Value.x2);
                }
                else
                {
                    Console.WriteLine("Równanie nie posiada rozwiązań");
                }
                
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
            }
            
        }
    }
}
