// Задача 3: Задайте двумерный массив. Найдите сумму элементов главной диагонали.
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

int SumDiagonal(int [,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++ )
    {
        for (int j = 0; j < array.GetLength(1); j++ )
        {
            if ( i == j)
            {
                sum += array[i, j];
            }
        }

    }
    return sum;

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
System.Console.WriteLine(SumDiagonal(array));
