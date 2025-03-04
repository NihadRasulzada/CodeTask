
Console.Write("Duzbucaqlinin uzunlugunu daxil edin: ");
double uzunluq = double.Parse(Console.ReadLine());

Console.Write("Duzbucaqlinin enini daxil edin: ");
double en = double.Parse(Console.ReadLine());

double sahə = uzunluq * en;
double perimetr = 2 * (uzunluq + en);

Console.WriteLine("Sahe: " + sahə);
Console.WriteLine("Perimetr: " + perimetr);
