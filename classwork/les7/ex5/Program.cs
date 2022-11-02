// Задайте двумерный массив. Введите элемент, и найдите первое его вхождение, выведите позиции по горизонтали и вертикали, или напишите, что такого элемента нет.
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

(int, int) SearchNumb( int [,] array, int number)
{
    for (int i = 0; i < array.GetLength(0); i++ )
    {
        for (int j = 0; j < array.GetLength(1); j++ )
        {
            if(array [i, j] == number)
            { 
                return (i, j);
            }

        }
    }
    return(-1, -1);

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

int number = 2;
(int line , int column) = SearchNumb(array, number);
if (line == -1)
{
    System.Console.WriteLine("Нет искомого числа");
}
else 
{
    System.Console.WriteLine($"Координаты [{line}, {column}]");
}

