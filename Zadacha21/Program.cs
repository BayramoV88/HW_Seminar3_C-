Console.WriteLine("Введите значение x1");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение y1");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение z1");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение x2");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение y2");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение z2");
int z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"точка A с координатами ({x1}, {y1}, {z1})");
Console.WriteLine($"точка B с координатами ({x2}, {y2}, {z2})");

double distXX = Math.Pow(x2 - x1, 2);
double distYY = Math.Pow(y2 - y1, 2);
double distZZ = Math.Pow(z2 - z1, 2);

double distance = Math.Sqrt(distXX + distYY + distZZ);
;
Console.WriteLine($"расстояние между точками " + Math.Round(distance, 2));