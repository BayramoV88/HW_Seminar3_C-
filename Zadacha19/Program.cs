Random rand = new Random();
int num = rand.Next(9999, 100000);
//int num = 12321; - строка для проверки с конкретным числом
Console.WriteLine(num);

int firstNum = num / 10000;
int lastNum = num % 10;
int secondNum = num / 1000 % 10;
int prelastNum = num % 100 / 10;

if (firstNum == lastNum && secondNum == prelastNum)
{
    Console.WriteLine($"число {num} является палиндромом, УРА!!!");
}
else
{
    Console.WriteLine($"число {num} не является палиндромом, попробуйте еще раз");
}