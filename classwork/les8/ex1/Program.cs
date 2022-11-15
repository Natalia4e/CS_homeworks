// Задача 1: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
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
PrintArray(ChangeArray(array));

int [,] ChangeArray(int [,] array)
{
    for (int j = 0; j < array.GetLength(1); j++ )
    {
        int t = array[0,j];
        array[0,j] = array[array.GetLength(0)-1,j];
        array[array.GetLength(0)-1,j] = t;
    }
    return array;

}