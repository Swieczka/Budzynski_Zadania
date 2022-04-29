using System;
namespace TypyWartiRef
{
    class Program
    {
        struct TypStruct
        {
            public int Wartosc;
        }
        class TypClass
        {
            public int Wartosc;

            public override bool Equals(object? obj)
            {
                return this.Wartosc == (obj as TypClass).Wartosc;
            }
        }
        static void ustawWartosc3(TypStruct o)
        {
            o.Wartosc = 3;
        }
        static void ustawWartosc3(TypClass o)
        {
            o.Wartosc = 3;
        }

        static void Main(string[] args)
        {
            //struct
            Console.WriteLine("Sprawdzenie jak działa kod w przypadku structu");
            TypStruct str1 = new TypStruct() { Wartosc = 1};
            TypStruct str2 = str1;

            Console.WriteLine($"str1 = {str1.Wartosc}, str2 = {str2.Wartosc}");

            Console.WriteLine("Kopiowanie");
            str1.Wartosc = 2;

            Console.WriteLine($"str1 = {str1.Wartosc}, str2 = {str2.Wartosc}");

            Console.WriteLine("Wywołanie metody");
            ustawWartosc3(str1);
            Console.WriteLine($"str1 = {str1.Wartosc}, str2 = {str2.Wartosc}");
            Console.WriteLine($"Czy str1 jest równy str2? {str1.Equals(str2)}");


            //class
            Console.WriteLine("\nSprawdzenie jak działa kod w przypadku klasy");
            TypClass cl1 = new TypClass() { Wartosc = 1 };
            TypClass cl2 = new TypClass() { Wartosc = 3 };

            Console.WriteLine($"cl1 = {cl1.Wartosc}, cl2 = {cl2.Wartosc}");

            Console.WriteLine("Kopiowanie");
            cl1.Wartosc = 2;

            Console.WriteLine($"cl1 = {cl1.Wartosc}, cl2 = {cl2.Wartosc}");

            Console.WriteLine("Wywołanie metody");
            ustawWartosc3(cl1);
            Console.WriteLine($"cl1 = {cl1.Wartosc}, cl2 = {cl2.Wartosc}");
            Console.WriteLine($"Czy cl1 ma tę samą wartość co cl2? {cl1.Equals(cl2)}");
            Console.WriteLine($"Czy cl1 == cl2? {cl1 == cl2}");

        }

    }
}
