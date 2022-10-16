// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
int InputNumber(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int CountSym(int number)
{
    int result = 0;
    while (number>0)
    {
        number = number/10;
        result++;
    }
    return result;
}

int number = InputNumber("Введите число");
int result = CountSym(number);
System.Console.WriteLine($" в числе {number} количество цифр {result}");