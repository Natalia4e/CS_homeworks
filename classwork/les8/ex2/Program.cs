//Задача 2: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.
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



int [,] TransponateMatrix(int [,] array)
{
   for (int j = 0; j < array.GetLength(1); j++ )
   {
    for (int i = j; i < array.GetLength(0); i++ )
    {
        int t = array [i,j];
        array [i,j] = array [j,i];
        array [j,i] = t;
    }
   }
   return array; 
}

Console.WriteLine("     ");
PrintArray(TransponateMatrix(array));
