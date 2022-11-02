// Задача 1: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
double [,] CreateArray(int lenRows, int lenColumns)
{
    double[,] array = new double[lenRows, lenColumns];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++ )
    {
        for (int j = 0; j < array.GetLength(0); j++ )
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;

        }
    }
    return array;
}

void PrintArray(double [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++ )
    {
        for (int j = 0; j < array.GetLength(0); j++ )
        {
            Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

double [,] array = CreateArray(3,4);
PrintArray(array);
