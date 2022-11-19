// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
int Prompt(string msg)
{
    System.Console.Write(msg + " > ");
    return int.Parse(Console.ReadLine());
}

int SumNumbers (int m, int n, int sum = 0)
{
    sum += m;
    if (m == n)
    {
        return sum;
    }
    return SumNumbers(m + 1,n,sum);
}

int m  = Prompt("Введите число");
int n  = Prompt("Введите число");

Console.WriteLine(SumNumbers(m,n));


