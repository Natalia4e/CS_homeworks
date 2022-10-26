

// Задача 2. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int b1 = Prompt ("Введите число b1 ");
int k1 = Prompt ("Введите число k1 ");
int b2 = Prompt ("Введите число b2 ");
int k2 = Prompt ("Введите число k2 ");

int x = (b2 - b1)/ (k1 - k2);
int y = k1* (b2 - b1)/ (k1 - k2) + b1;

 System.Console.WriteLine($"Пересечение в точке = ( {x} ; {y}) ");