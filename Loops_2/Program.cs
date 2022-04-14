int x = int.Parse(Console.ReadLine());
int suma = 0;
for(int i = 1; i <= x; i++)
{
    suma += i;
}
Console.WriteLine($"Suma wszystkich liczb od 0 do {x} wynosi: {suma}");