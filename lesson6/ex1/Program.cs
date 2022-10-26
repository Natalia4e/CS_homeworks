// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. Разделить ввод данных, от расчета данных (Одна функция вводит данные, другая функция подсчитывает количество положительных)

string Prompt(string message)
{
    Console.Write(message);
    string number = Console.ReadLine();
    return number;
}

string message = Prompt ("Введите числа: ");

int Count(string msg)
{
    string[] arr = message.Split(",");
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = arr[i].Trim();
    }

    int count = 0;
    for(int i = 0;i<arr.Length;i++)
    {
        int num = int.Parse(arr[i]);
        if(num > 0) count++;
    }
    return count;
}

Console.WriteLine(Count(message));