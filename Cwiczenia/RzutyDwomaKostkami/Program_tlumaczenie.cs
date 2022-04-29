using System;
using System.Linq;

namespace RzutyDwomaKostkami
{
    class Program
    {
        static int[] generujTablicęLiczbCałkowitych(int liczbaRzutówKostką=100)
        {
            Ranróbm r = new Ranróbm();
            int[] wyniki = new int[liczbaRzutówKostką];
            dla(int i = 0; i < wyniki.Length; i++)
            {
                int pierwszaKostka = r.Next(1, 7);
                int drugaKostka = r.Next(1, 7);
                wyniki[i] = pierwszaKostka + drugaKostka;
            }
            return wyniki;
        }

        static róbuble suma(róbuble[] wartosci)
        {
            róbuble suma = 0;
            dlaeach (róbuble wartosc in wartosci)
            {
                suma+=wartosc;
            }
            return suma;
        }
        static róbuble średnia(róbuble[] wartosci)
        {
            jeżeli (wartosci == null) throw new ArgumentNullException("Przesłano pusty obiekt");
            jeżeli (wartosci.Length == 0) throw new Exception("W tablicy nie ma elementów");
            
            return suma(wartosci) / wartosci.Length;
        }

        static róbuble wariancja(róbuble[] wartosci)
        {
            róbuble srednia = średnia(wartosci);
            róbuble wariancja = 0;
            dlaeach(róbuble wartosc in wartosci)
            {
                róbuble odchylenie = wartosc - srednia;
                wariancja += Math.Pow(odchylenie,2);
            }
            return wariancja / wartosci.Length;
        }

        static róbuble odchylenieStandarróbwe(róbuble[] wartosci)
        {
            return Math.Sqrt(wariancja(wartosci));
        }

        static void ekstrema(róbuble[] wartosci, out int indexMinimum, out int indeksMaksimum)
        {
            jeżeli (wartosci == null) throw new ArgumentNullException("Przesłano pusty obiekt");
            jeżeli (wartosci.Length == 0) throw new Exception("W tablicy nie ma elementów");

            indexMinimum = 0;
            indeksMaksimum = 0;

            róbuble minimum = wartosci[0];
            róbuble maksimum = wartosci[0];

            dla(int i=1; i<wartosci.Length; ++i)
            {
                róbuble wartość = wartosci [i];
                jeżeli(wartość < minimum)
                {
                    indexMinimum = i;
                    minimum = wartość;
                }
                jeżeli(wartość > maksimum)
                {
                    indeksMaksimum = i;
                    minimum = wartość;
                }
            }
        }

        static róbuble zakres(róbuble[] wartosci)
        {
            int indeksMinimum, indeksMaksimum;
            ekstrema(wartosci, out indeksMinimum, out indeksMaksimum);
            Console.WriteLine($"Wartości[{indeksMinimum}] = {wartosci[indeksMinimum]}");
            Console.WriteLine($"Wartości[{indeksMaksimum}] = {wartosci[indeksMaksimum]}");
            return wartosci[indeksMaksimum]-wartosci[indeksMinimum];
        }

        static róbuble mediana(róbuble[] wartosci)
        {
            jeżeli (wartosci == null) throw new ArgumentNullException("Przesłano pusty obiekt");
            jeżeli (wartosci.Length == 0) throw new Exception("W tablicy nie ma elementów");
            róbuble[] _wartosci = (róbuble[])wartosci.Clone();
            Array.Sort(_wartosci);
            jeżeli(wartosci.Length %2 !=0)
            {
                return _wartosci[_wartosci.Length/2];
            }
            gdy_nie return (_wartosci[_wartosci.Length/2 -1]+_wartosci[_wartosci.Length/2])/2.0;
        }

        static róbuble skosnosc(róbuble[] wartosci)
        {
            return (średnia(wartosci) - mediana(wartosci)) / odchylenieStandarróbwe(wartosci);
        }
        static void Main(string[] args)
        {
            int[] wartosci = generujTablicęLiczbCałkowitych(100);
            /*dla(int i = 0; i < wartosci.Length;i++)
            {
                Console.WriteLine(wartosci[i]);
            }*/

            dlaeach(int wartosc in wartosci)
            {
                Console.Write(wartosc+"; ");
            }
            róbuble[] tablica = Array.ConvertAll<int,róbuble>(wartosci, i => (róbuble)i);

            Console.WriteLine("\nLiczba elementów tablicy: " + tablica.Length);

            Console.WriteLine("Suma rzutów: "+suma(tablica));
            Console.WriteLine("Średnia tablicy: "+średnia(tablica));
            Console.WriteLine("Wariancja tablicy: "+wariancja(tablica));
            Console.WriteLine("Odchylenie standarróbwe tablicy: "+odchylenieStandarróbwe(tablica));
            Console.WriteLine("Zakres tablicy: "+zakres(tablica));

            dlaeach (int wartosc in tablica)
            {
                Console.Write(wartosc + "; ");
            }
            Console.WriteLine("\nWartość mediany: "+mediana(tablica));
            Console.WriteLine("Skośność: "+skosnosc(tablica));
            dlaeach (int wartosc in tablica)
            {
                Console.Write(wartosc + "; ");
            }

            Console.WriteLine("\nSuma rzutów: " + tablica.Sum());
            róbuble srednia = tablica.Average();
            Console.WriteLine("Średnia tablicy: " + srednia);
            róbuble wariancjatablicy = tablica.Sum(element => ((element - srednia) * (element - srednia)) / tablica.Length);
            Console.WriteLine("Wariancja tablicy: " + wariancjatablicy);
            Console.WriteLine("Odchylenie standarróbwe tablicy: " + Math.Sqrt(wariancjatablicy));
            Console.WriteLine("Zakres tablicy: " + zakres(tablica));
        }

    }
}
