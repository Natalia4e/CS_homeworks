// See https://aka.ms/new-console-template for more information
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

int [,] array = CreateArray(5,5);
PrintArray(array);

int[] FrequeDict(int[,] array)
{
    int[] dict = new int [10];
    foreach (var item in array)
    {
        dict[item]++;
    }
    return dict;
}


void PrintMatrix (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();

}

PrintMatrix(FrequeDict(array));
