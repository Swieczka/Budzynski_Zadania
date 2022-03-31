using System;

namespace Zmienne
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("a = ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("b = ");
                int b = int.Parse(Console.ReadLine());
                double średnia = (a + b) / 2.0;
                Console.WriteLine($"Średnia liczb {a} i {b} to {średnia}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Wystąpił błąd: "+ex.Message);
            }
        }
    }
}