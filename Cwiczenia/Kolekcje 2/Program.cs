using System;
using System.Collections.Generic;

namespace Kolekcje
{
    class Program
    {
        static void drukujLiczby(IEnumerable<int> tablica)
        {
            foreach(int i in tablica)
            {
                Console.Write(i+"\t");
            }
            Console.WriteLine();
        }

        static T[] przepiszElementyDoTablicy<T>(List<T> lista)
        {
            T[] tablica = new T[lista.Count];
            for(int i = 0; i < lista.Count; i++)
            {
                tablica[i] = lista[i];
            }
            return tablica;
        }
        static int[] filtrujLiczbyParzyste(int[] liczby)
        {
            List<int> liczbyParzyste = new List<int>();

            foreach(int i in liczby)
            {
                if(i%2==0)
                {
                    liczbyParzyste.Add(i);
                }
                
            }
            return przepiszElementyDoTablicy(liczbyParzyste);
        }
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] liczby = new int[100];
            for(int i = 0; i < liczby.Length; i++)
            {
                liczby[i] = r.Next(100);
            }
            Console.WriteLine("Wszystkie liczby: ");
            drukujLiczby(liczby);
            IEnumerable<int> liczbyParzyste = filtrujLiczbyParzyste(liczby);
            Console.WriteLine("Liczby parzyste: ");
            drukujLiczby(liczbyParzyste);
        }
    }
}