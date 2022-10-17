//  Напишите программу, которая из массива случайных чисел. Ищет второй максимум (число меньше максимального элемента, но больше всех остальных). Постарайтесь сделать одним циклом
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



int MaxNumber(int[] arr)
{
    
    int max = 0;
    int secondMax = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) 
        {
            max = arr[i];
        }
    }
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < max && arr[i] > secondMax)
        {
            secondMax = arr[i];
        }
    }
    return secondMax;
}

 int result = MaxNumber(arr);

 System.Console.WriteLine($"Второй максимум = {result} ");
