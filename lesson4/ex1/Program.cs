// апишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B (и в нулевую степень). Использовать свои функции, не использовать Math.Pow

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int A = Prompt ("Введите число A >");
int B = Prompt ("Введите число B >");


int Pov(int A, int B)
{
    if ( B == 0) 
    {
        return 1;
    }

    int res = A;
    for (int i = 1; i < B; i++) 
    {
        res = res * A;
    }
    return res;
}

int result = Pov(A, B);

System.Console.WriteLine($"{A} в степени {B} равно {result}");
