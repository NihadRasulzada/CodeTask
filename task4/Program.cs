
Console.Write("Iki reqemli ededi daxil edin: ");
int eded = int.Parse(Console.ReadLine());

int onluq = eded / 10;
int tekliq = eded % 10;

if (onluq > tekliq)
{
    Console.WriteLine("Onluq daha boyukdur.");
}
else if (tekliq > onluq)
{
    Console.WriteLine("Tekliq daha boyukdur.");
}
else
{
    Console.WriteLine("Onluq ve tekliq beraberdir.");
}