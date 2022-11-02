// Задача 2: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
int [,] CreateArray(int lenRows, int lenColumns)
{
    int[,] array = new int[lenRows, lenColumns];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++ )
    {
        for (int j = 0; j < array.GetLength(1); j++ )
        {
            array[i, j] = random.Next(-5, 6);
        }
    }
    return array;
}


void PrintArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++ )
    {
        for (int j = 0; j < array.GetLength(1); j++ )
        {
            Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

int [,] array = CreateArray(4,4);
PrintArray(array);

Console.WriteLine("Введите номер строки");
int i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца");
int j = Convert.ToInt32(Console.ReadLine());

if (i > array.GetLength(0) || j > array.GetLength(1))
{
    Console.WriteLine("Данного элемента нет");
}
else
{
    Console.WriteLine($"Значение элемента {i} строки и {j} столбца равно {array[i-1,j-1]}");
}

PrintArray(array);