// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
int Prompt(string msg)
{
    System.Console.Write(msg + " > ");
    return int.Parse(Console.ReadLine());
}

void PrintNumbers (int m, int n)
{
    if (m > n)
    {
        return;
    }
    System.Console.Write(m + "  ");
    PrintNumbers(m + 2, n);
    
}

int m  = Prompt("Введите число");
int n  = Prompt("Введите число");

PrintNumbers(m, n);
