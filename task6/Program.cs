
Console.Write("Birinci deyer (a) daxil edin: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Ikinci deyer (b) daxil edin: ");
int b = int.Parse(Console.ReadLine());

// Yerini deyisdirmek
int temp = a;
a = b;
b = temp;

Console.WriteLine("Yeni deyerler: a = " + a + "; b = " + b);
