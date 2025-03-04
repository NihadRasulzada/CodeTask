
Console.Write("Telebe balini daxil edin: ");
int bal = int.Parse(Console.ReadLine());

if (bal >= 90) Console.WriteLine("A");
else if (bal >= 75) Console.WriteLine("B");
else if (bal >= 60) Console.WriteLine("C");
else if (bal >= 50) Console.WriteLine("D");
else Console.WriteLine("F");