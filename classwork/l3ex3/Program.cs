// Задача 3: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

Printer(Fill(8));

int[] Fill(int Length)
{
int [] array = new int [Length];
for (int i=0; i<=array.Length-1; i++)
{
    int r =new Random().Next(0,2);
    array[i] = r;
}
return array;
}

void Printer(int[]array)
{
    for (int i=0; i <= array.Length-1; i++)
    {
        Console.WriteLine($"{array[i]}\t");

    }
}