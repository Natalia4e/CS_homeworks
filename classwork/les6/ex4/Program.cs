// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
int [] RandomArrGen()
{
    int length = 3;
    int [] arr = new int [length];
    
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(1,100);
        System.Console.Write($"{arr[i]} ");
    }
    return arr;
}

int Prompt()
{
    System.Console.WriteLine("Напишите число");
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}

int count = Prompt();
int tmp1 = 0;
int tmp2 = 1;
while(count > 0)
{
    int tmp = tmp1 + tmp2;
    tmp1 = tmp2;
    tmp2 = tmp;
    System.Console.WriteLine($"{tmp1}");
    count--;
}
