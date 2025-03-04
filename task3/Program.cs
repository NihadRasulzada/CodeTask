
Console.Write("Maaşi daxil edin: ");
double maas = double.Parse(Console.ReadLine());

Console.Write("Kredit deyerini daxil edin: ");
double kredit = double.Parse(Console.ReadLine());

if (kredit < maas * 0.6)
{
    Console.WriteLine("Kredit goture bilmezsiniz!");
}
else
{
    Console.WriteLine("Kredit goture bilersiniz!");
}