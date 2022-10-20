//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
double[] CreateArray (int len, int minLimit, int maxlimit)
{
    double[] array = new double[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(rnd.Next(minLimit, maxlimit+1) + rnd.NextDouble(),2);
    }
    return array;
}

void PrintArray (double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
}

double[] myArray = CreateArray(5, -50, 50);
PrintArray(myArray);

double MaxNumber (double[] array)
{
    double max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0 || array[i]> max)
        {
            max = array[i];
        }
    }
    return max;
}

double MinNumber (double[] array)
{
    double min = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0 || array[i]< min)
        {
            min = array[i];

        }
    }
    return min;
    
}


 double max_num = MaxNumber(myArray);
 double min_num = MinNumber(myArray);
  

 System.Console.WriteLine($" максимум = {max_num} ");
 System.Console.WriteLine($" минимум = {min_num} ");