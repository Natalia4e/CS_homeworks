// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b & a > c)
{
    Console.WriteLine($"Число {a} наибольшее.");
}
else if (b > c & b > a)
{
    Console.WriteLine($"Число {b} наибольшее.");
}
else
{
    Console.WriteLine($"Число {c} наибольшее.");
}
