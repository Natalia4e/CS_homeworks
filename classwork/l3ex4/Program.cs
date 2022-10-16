// Напишите программу, которая из массива случайных чисел. Ищет второй максимум (число меньше максимального элемента, но больше всех остальных). Постарайтесь сделать одним циклом 


int [] arr = { -2, -3, -4, -1 };

int max = arr[0];
int max2 = arr[1];

for (int i=0; i < arr.Length; i++)
{
    if (max < arr[i])
    {
        max2 = max;
        max = arr[i];
    }
    else if ( max2 < arr[i] && arr[i] != max)
    {
        max2 = arr[i];
    }
}
Console.WriteLine(max);
Console.WriteLine(max2);