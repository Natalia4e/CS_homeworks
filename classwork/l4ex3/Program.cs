// Задача 2: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
int InputNumber(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int number = InputNumber("Введите число");
int multiply = 1;
for (int i =1; i<=number; i++)
{
    multiply = multiply*i;
}
Console.WriteLine($"Выводим факториал {multiply}");
