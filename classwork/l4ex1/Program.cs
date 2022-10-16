// Задача 1: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// Ввод числа по приглашению
int InputNumber(string message)
{
    Console.Write(message);                    // вывод приглашения 
    string str = Console.ReadLine();          // читаем строку с консоли
    return int.Parse(str);                    // Преобразуем строку в число
}

// Сумма чисел от 1 до number
int SumNumbers(int number)
{
    int sum = 0;                          // Накапливаем сумму
    for( int i = 1; i <=number; i++)      // цикл от 1 до number
    {
        sum = sum + i;                     // суммируем
    }
    return sum;
}

// проверка на правильность ввода
bool ValidateNumber(int number)
{
    if (number<1)
    {
        System.Console.WriteLine("Число меньше единицы,сумма не считается");
    }
    return true;
}

int n = InputNumber("Введите число >");

if (ValidateNumber(n))
{
    int result = SumNumbers(n);
    System.Console.WriteLine($"Сумма чисел от 1 до {n} равна {result}");
}