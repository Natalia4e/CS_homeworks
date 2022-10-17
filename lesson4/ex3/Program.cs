// Напишите программу, которая задаёт массив из 8 случайных элементов и выводит их на экран.


int[] CreateArray (int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(0,21);
        Console.Write($"{array[i]} ");
    }
    return array;
}

int[] arr = CreateArray (8);