int x = int.Parse(Console.ReadLine());
int silnia=1;

for(int i=x;i>0;i--)
{
    silnia *= i;
}
Console.WriteLine($"Silnia z liczby {x} wynosi: {silnia}");