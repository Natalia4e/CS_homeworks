
// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
int [,] CreateMatrix(int lenRows, int lenColumns)
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

int [,] ResultMatrix(int [,] array1, int [,] array2)
{
    int [,] resultMatrix = new int [array1.GetLength(0), array1.GetLength(1)];
    if ( array1.GetLength(0) != array2.GetLength(0) ||  array1.GetLength(1) != array2.GetLength(1) )
    {
        Console.WriteLine("Матрицы разных размеров. Перемножать нельзя");
    }
    else 
    {
        for (int i = 0; i < array1.GetLength(0); i++ )
        {
            for (int j = 0; j < array1.GetLength(1); j++ )
            {
                resultMatrix [ i, j] = array1 [ i, j ] * array2 [i,j];
            }            
        }
    }
    return resultMatrix;
}





int [,] array1 = CreateMatrix(4,4);
PrintArray(array1);
System.Console.WriteLine();
int [,] array2 = CreateMatrix(4,4);
PrintArray(array2);
System.Console.WriteLine();
PrintArray(ResultMatrix(array1, array2));
