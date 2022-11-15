// Задача 4: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
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


(int, int) FindMin (int [,] array)
{
    int indRow = 0;
    int indCol = 0;
    for (int i = 0; i < array.GetLength(0); i++ )
    {
        for (int j = 0; j < array.GetLength(1); j++ )
        {
            if (array[i,j] < array[indRow, indCol])
            {
                indRow = i;
                indCol = j;
            }
        }
    }
    return (indRow, indCol);
}

int [,] ChangeMatrix ( int[,] array)
{
    int [,] ans = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    (int minRow, int minCol) = FindMin(array);
    int a = 0;
    int b = 0;
    for (int i = 0; i < array.GetLength(0); i++ )
    {
        if (i != minRow)
        {
            b = 0;
            for (int j = 0; j < array.GetLength(1); j++ )
            {
                if ( i == minRow || j == minCol)
                {

                }
                else
                {
                ans[a,b] = array [i,j];
                b++;
                }
            }
            a++;
        }
    }    
    return ans;
}

int [,] array = CreateArray(4,4);
PrintArray(array);
System.Console.WriteLine();
PrintArray(ChangeMatrix(array));

