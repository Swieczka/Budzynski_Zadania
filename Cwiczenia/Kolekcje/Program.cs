using System;
using System.Collections.Generic;

namespace Kolekcje
{
    class Program
    {
        static void Main(string[] args)
        {
            int rozmiar = 10;
            Queue<int> kolejka = new Queue<int>(rozmiar);
            Stack<int> stos = new Stack<int>(rozmiar);
            for(int i = 0; i < rozmiar; i++)
            {
                kolejka.Enqueue(i);
                stos.Push(i);
            }
            string s = "Elementy zdjęte ze stosu ";
            for(int i = 0; i < rozmiar; i++)
            {
                s += stos.Pop().ToString()+ " ";
            }
            Console.WriteLine(s);
            s = "Elementy zdjęte z kolejki ";
            for (int i = 0; i < rozmiar; i++)
            {
                s += kolejka.Dequeue().ToString() + " ";
            }
            Console.WriteLine(s);
        }
    }
}