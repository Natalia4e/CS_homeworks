// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа
Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());
if (a > 99 & a < 1000)
{
    int result = a % 10;
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Вы ввели не трехзначное число");
}