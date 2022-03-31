using System;
namespace Algorytm_X_wieksze_0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadz X");
            double x = double.Parse(Console.ReadLine());

            if(x>0)
            {
                Console.WriteLine("+");
            }
            else if(x<0)
            {
                Console.WriteLine("-");
            }
            else
            {
                Console.WriteLine("=");
            }
        }
    }
}