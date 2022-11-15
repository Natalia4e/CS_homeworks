// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочивает по убыванию элементы каждой строки двумерного массива.
int [,] CreateArray(int lenRows, int lenColumns)
{
    int[,] array = new int[lenRows, lenColumns];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++ )
    {
        for (int j = 0; j < array.GetLength(1); j++ )
        {
            array[i, j] = random.Next(0, 9);
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


int [,] SortMatrix (int [,] array)
{
   for (int i = 0; i < array.GetLength(0); i++ )
   {
    for (int index = 0; index < array.GetLength(0); index++ )
   {
    int min = array [i, index];
    for (int j = 0; j < array.GetLength(1); j++ )
    {
        if ( array [i,j] < min)
        {
            min = array [i, j];
            array [i, j] = array [i, index];
            array [i, index] = min;
        }
    }
   }
   } 
   return array;
}

int [,] array = CreateArray(4,4);
PrintArray(array);
System.Console.WriteLine();
PrintArray(SortMatrix(array));