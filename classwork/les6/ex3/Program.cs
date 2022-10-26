//Задача 2: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
int Prompt()
{
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}

int [] Binarny(int number)
{
    int [] array = new int[10];
    int count = array.Length - 1;
    while ( number > 0)
    {
        array[count] = number % 2;
        number = number / 2;
        count -- ;
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i =0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
}

int a = 42;
PrintArray(Binarny(a));
