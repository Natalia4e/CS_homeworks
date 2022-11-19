// Задача 3: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр. Использовать рекурсию.
int Prompt(string msg)
{
    System.Console.Write(msg + " > ");
    return int.Parse(Console.ReadLine());
}

int PrintNumbers (int num)
{
    if (num <= 0)
    {
        return 0;
    }
    return num % 10 + PrintNumbers(num/10);
    
}


int num  = 453;
int sum = 0;
sum = PrintNumbers(num);
Console.WriteLine(sum);
