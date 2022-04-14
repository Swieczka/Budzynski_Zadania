Console.WriteLine("Podaj rok");
int rok = int.Parse(Console.ReadLine());
if(rok%4==0 && rok%100!=0 || rok%400==0)
{
    Console.WriteLine($"Rok {rok} jest rokiem przestępnym");
}
else
{
    Console.WriteLine($"Rok {rok} nie jest rokiem przestępnym");
}