
Console.Write("Birinci ededi daxil edin: ");
int eded1 = int.Parse(Console.ReadLine());

Console.Write("Ikinci ededi daxil edin: ");
int eded2 = int.Parse(Console.ReadLine());

if (eded1 % 2 == 0 && eded2 % 2 == 0)
{
    Console.WriteLine("Cem: " + (eded1 + eded2));
}
else
{
    Console.WriteLine("Daxil olunan ededler cut olmalidir!");
}