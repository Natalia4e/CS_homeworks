//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Функция должна на вход принимать число, а выдавать сумму его цифр
int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int N = Prompt ("Введите число N >");



int SumNumber(int N)
{
    int sum = 0;
    while (N > 0)
    {
        sum = sum + ( N % 10 );
        N = N/10;
    }
    return sum;
}

int result = SumNumber(N);

Console.WriteLine($"Сумма цифр в заданном числе равна {result}");