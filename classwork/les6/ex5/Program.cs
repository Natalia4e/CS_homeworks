//  Задача 4: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
int [] RandomArrGen()
{
    int length = 3;
    int [] arr = new int [length];
    
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(1,10);
        System.Console.Write($"{arr[i]} ");
    }
    return arr;
}

void PrintArray(int[] array)
{
    for (int i =0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
}

int Prompt()
{
    System.Console.WriteLine("Напишите число");
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}

int[] array = RandomArrGen();
int[] array2 = array;
PrintArray(array);
array [0] = -1;
PrintArray(array);
PrintArray(array2);





