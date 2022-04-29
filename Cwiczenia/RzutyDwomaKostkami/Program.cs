using System;
using System.Linq;

namespace RzutyDwomaKostkami
{
    class Program
    {
        static int[] generujTablicęLiczbCałkowitych(int liczbaRzutówKostką=100)
        {
            Random r = new Random();
            int[] wyniki = new int[liczbaRzutówKostką];
            for(int i = 0; i < wyniki.Length; i++)
            {
                int pierwszaKostka = r.Next(1, 7);
                int drugaKostka = r.Next(1, 7);
                wyniki[i] = pierwszaKostka + drugaKostka;
            }
            return wyniki;
        }

        static double suma(double[] wartosci)
        {
            double suma = 0;
            foreach (double wartosc in wartosci)
            {
                suma+=wartosc;
            }
            return suma;
        }
        static double średnia(double[] wartosci)
        {
            if (wartosci == null) throw new ArgumentNullException("Przesłano pusty obiekt");
            if (wartosci.Length == 0) throw new Exception("W tablicy nie ma elementów");
            
            return suma(wartosci) / wartosci.Length;
        }

        static double wariancja(double[] wartosci)
        {
            double srednia = średnia(wartosci);
            double wariancja = 0;
            foreach(double wartosc in wartosci)
            {
                double odchylenie = wartosc - srednia;
                wariancja += Math.Pow(odchylenie,2);
            }
            return wariancja / wartosci.Length;
        }

        static double odchylenieStandardowe(double[] wartosci)
        {
            return Math.Sqrt(wariancja(wartosci));
        }

        static void ekstrema(double[] wartosci, out int indexMinimum, out int indeksMaksimum)
        {
            if (wartosci == null) throw new ArgumentNullException("Przesłano pusty obiekt");
            if (wartosci.Length == 0) throw new Exception("W tablicy nie ma elementów");

            indexMinimum = 0;
            indeksMaksimum = 0;

            double minimum = wartosci[0];
            double maksimum = wartosci[0];

            for(int i=1; i<wartosci.Length; ++i)
            {
                double wartość = wartosci [i];
                if(wartość < minimum)
                {
                    indexMinimum = i;
                    minimum = wartość;
                }
                if(wartość > maksimum)
                {
                    indeksMaksimum = i;
                    minimum = wartość;
                }
            }
        }

        static double zakres(double[] wartosci)
        {
            int indeksMinimum, indeksMaksimum;
            ekstrema(wartosci, out indeksMinimum, out indeksMaksimum);
            Console.WriteLine($"Wartości[{indeksMinimum}] = {wartosci[indeksMinimum]}");
            Console.WriteLine($"Wartości[{indeksMaksimum}] = {wartosci[indeksMaksimum]}");
            return wartosci[indeksMaksimum]-wartosci[indeksMinimum];
        }

        static double mediana(double[] wartosci)
        {
            if (wartosci == null) throw new ArgumentNullException("Przesłano pusty obiekt");
            if (wartosci.Length == 0) throw new Exception("W tablicy nie ma elementów");
            double[] _wartosci = (double[])wartosci.Clone();
            Array.Sort(_wartosci);
            if(wartosci.Length %2 !=0)
            {
                return _wartosci[_wartosci.Length/2];
            }
            else return (_wartosci[_wartosci.Length/2 -1]+_wartosci[_wartosci.Length/2])/2.0;
        }

        static double skosnosc(double[] wartosci)
        {
            return (średnia(wartosci) - mediana(wartosci)) / odchylenieStandardowe(wartosci);
        }
        static void Main(string[] args)
        {
            int[] wartosci = generujTablicęLiczbCałkowitych(100);
            /*for(int i = 0; i < wartosci.Length;i++)
            {
                Console.WriteLine(wartosci[i]);
            }*/

            foreach(int wartosc in wartosci)
            {
                Console.Write(wartosc+"; ");
            }
            double[] tablica = Array.ConvertAll<int,double>(wartosci, i => (double)i);

            Console.WriteLine("\nLiczba elementów tablicy: " + tablica.Length);

            Console.WriteLine("Suma rzutów: "+suma(tablica));
            Console.WriteLine("Średnia tablicy: "+średnia(tablica));
            Console.WriteLine("Wariancja tablicy: "+wariancja(tablica));
            Console.WriteLine("Odchylenie standardowe tablicy: "+odchylenieStandardowe(tablica));
            Console.WriteLine("Zakres tablicy: "+zakres(tablica));

            foreach (int wartosc in tablica)
            {
                Console.Write(wartosc + "; ");
            }
            Console.WriteLine("\nWartość mediany: "+mediana(tablica));
            Console.WriteLine("Skośność: "+skosnosc(tablica));
            foreach (int wartosc in tablica)
            {
                Console.Write(wartosc + "; ");
            }

            Console.WriteLine("\nSuma rzutów: " + tablica.Sum());
            double srednia = tablica.Average();
            Console.WriteLine("Średnia tablicy: " + srednia);
            double wariancjatablicy = tablica.Sum(element => ((element - srednia) * (element - srednia)) / tablica.Length);
            Console.WriteLine("Wariancja tablicy: " + wariancjatablicy);
            Console.WriteLine("Odchylenie standardowe tablicy: " + Math.Sqrt(wariancjatablicy));
            Console.WriteLine("Zakres tablicy: " + zakres(tablica));
        }

    }
}
