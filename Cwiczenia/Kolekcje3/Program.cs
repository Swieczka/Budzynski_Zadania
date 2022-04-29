using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Kolekcje
{
    class Program
    {

        static void Main(string[] args)
        {
            SortedList<string, string> slownik = new SortedList<string, string>()
            {
                {"if", "jeżeli" },
                {"else", "gdy_nie" },
                {"for", "dla" },
                {"do","rób" },
                {"while","dopóki" },
                {"switch","wybór" },
                {"case", "przypadek" },
                {"List", "lista" },
                {"Random","Losowy" },
                {"Queue","Kolejke" },
                {"Stack","Stos" }
            };

            string ścieżkaPliku = @"D:\projekty\Budzynski_Zadania\Cwiczenia\RzutyDwomaKostkami\Program.cs";
            Console.WriteLine($"Czytam plik {ścieżkaPliku}...");
            string tekst = File.ReadAllText(ścieżkaPliku);

            /*foreach(string slowo in slownik.Keys)
            {
                tekst = tekst.Replace(slowo, slownik[slowo]);
            }*/
            StringBuilder _tekst = new StringBuilder(tekst);
            foreach(string slowo in slownik.Keys)
            {
                _tekst.Replace(slowo, slownik[slowo]);
            }
            tekst = _tekst.ToString();

            string ścieżkaKatalogu = Path.GetDirectoryName(ścieżkaPliku);
            string nazwaPlikuBezRozszerzenia = Path.GetFileNameWithoutExtension(ścieżkaPliku);
            string rozszerzenie = Path.GetExtension(ścieżkaPliku);
            string nowaŚcieżkaPliku = Path.Combine(ścieżkaKatalogu,nazwaPlikuBezRozszerzenia+"_tlumaczenie"+rozszerzenie);
            Console.WriteLine("Zapisuje tlumaczenie do pliku " + nowaŚcieżkaPliku);
            File.WriteAllText(nowaŚcieżkaPliku, tekst);
        }
    }
}