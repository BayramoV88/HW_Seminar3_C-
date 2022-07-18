Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int index = 1;

while (index <= num)
{
    double result = Math.Pow(index, 3);
    Console.WriteLine($"{index} в кубе = {result}");
    index++;
}