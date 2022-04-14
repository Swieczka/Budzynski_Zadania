double[] numbers = new double[3];
double max=0;

Console.WriteLine("Podaj pierwszą liczbę: ");
numbers[0]= double.Parse(Console.ReadLine());

Console.WriteLine("Podaj drugą liczbę: ");
numbers[1] = double.Parse(Console.ReadLine());

Console.WriteLine("Podaj trzecią liczbę: ");
numbers[2] = double.Parse(Console.ReadLine());

for(int i=0; i<numbers.Length; i++)
{
    if(numbers[i]>max)
    {
        max = numbers[i];
    }
}

Console.WriteLine($"Z podanych liczb {numbers[0]}, {numbers[1]} oraz {numbers[2]}, największą z nich jest {max}");