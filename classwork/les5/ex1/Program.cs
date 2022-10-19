// Задача 1: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
int[] CreateArray (int len, int minLimit, int maxlimit)
{
    int[] array = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minLimit, maxlimit+1);
    }
    return array;
}

void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();

}

int SumPositive ( int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

int SumNegative ( int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

int[] arr = CreateArray(8, -9, 9);
PrintArray(arr);
int sumPositive = SumPositive(arr);
int sumNegative = SumNegative(arr);
System.Console.WriteLine($"Положительная сумма {sumPositive} Отрицателльная = {sumNegative}");

