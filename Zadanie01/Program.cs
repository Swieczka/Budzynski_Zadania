using System;

namespace Zadanie01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jak Ci na imię?");
            Console.WriteLine("Napisz swoje imię:");
            string imie = Console.ReadLine();
            if(imie.Length == 0)
            {
                Console.Error.WriteLine("\n\n\t*** Błąd: nie podano imienia!\n\n");
                return;
            }
            bool czyImięŻeńskie = imie.ToLower()[imie.Length - 1]=='a';
            if (imie.Equals("Kuba") || imie.Equals("Barnaba")) czyImięŻeńskie = false;
            Console.WriteLine("Jesteś " + (czyImięŻeńskie? "kobietą" : "mężczyzną"));
           // if (czyImięŻeńskie) Console.WriteLine("Jesteś kobietą");
           // else Console.WriteLine("Jesteś mężczyzną");
        }
    }
}