
// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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

int [] SumRaws(int [,] array)
{
    int [] newAr = new int [array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++ )
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++ )
        {
            sum = array[i, j] + sum;
        }
        newAr [i] = sum;
    }
    return newAr;
}

int MinSum ( int [] newAr )
{
    int min = newAr [0];
    for (int i = 0; i < newAr.GetLength(0); i++ )
    {
        if (i== 0) { min = newAr[i]; }
        else if ( newAr [i] < min)
        {
            min = newAr [i];
        }
    }
    return min;

}



void PrintPlainArray(int[] array)
{
    for (int i = 0; i < array.Length; i++ )
    {
        Console.Write($"{array[i]}\t");
    }
        System.Console.WriteLine();

}

int [,] array = CreateArray(4,8);
PrintArray(array);
System.Console.WriteLine();
PrintPlainArray(SumRaws(array));
System.Console.WriteLine(MinSum(SumRaws(array)));