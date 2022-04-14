int suma = 0;
int x = 0;

while(suma<=100)
{
    x++;
    suma += x;
}
Console.WriteLine($"Żeby wartość sumy kolejnych liczb całkowitych przekroczyła 100 należy dodać do siebie {x} liczb");