// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
int rnd = new Random().Next(10,100);
System.Console.WriteLine(rnd);
int result2 = rnd % 10;
int result1 = rnd/10;
if (result1>result2)
{
    System.Console.WriteLine($"Первое число {result1} больше второго {result2}");
}
else
{
    System.Console.WriteLine($"Второе число {result2} больше первого {result1}");
}