// Задача 1: Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
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

int[] myArray = CreateArray(5, -9, 9);
PrintArray(myArray);
PrintArray(ChangeArray(myArray));


int[] ChangeArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0 || arr[i] < 0 )
        {
            arr[i] *= -1;

        }
    }
    return arr;

}
