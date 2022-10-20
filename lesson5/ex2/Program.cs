// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

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

int[] myArray = CreateArray(6, 0, 20);
PrintArray(myArray);

int SummNumber (int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i = i+2)
    {
        sum += array[i];
    }
    return sum;
}

Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {SummNumber(myArray)}");
