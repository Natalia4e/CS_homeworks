// Задача 3: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
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


double[] AverageColumn(int [,] array)
{
    double[] average = new double [array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++ )
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(0); j++ )
        {
            sum = array[j, i] + sum;
        }
        average [i] = (double) sum / array.GetLength(0);
    }
    return average;
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

void PrintPlainArray(double[] array)
{
    for (int i = 0; i < array.Length; i++ )
    {
        Console.Write($"{array[i]}\t");
    }
        System.Console.WriteLine();

}

int [,] array = CreateArray(4,8);
PrintArray(array);
PrintPlainArray(AverageColumn(array));
