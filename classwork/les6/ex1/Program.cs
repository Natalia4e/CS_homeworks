// Задача 1: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
int [] GenerateArray(int len)
{
    int[] answer = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < answer.Length; i++)
    {
        answer[i] = rnd.Next(0,10);
    }
    return answer;
}

void PrintArray(int[] array)
{
    for (int i =0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
}


int [] Reverse(int[] array)
{
    for (int i =0; i < array.Length/2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
    return array;

}

int [] array = GenerateArray(5);
PrintArray(array);
PrintArray(Reverse(array));
