//  Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
int Prompt(string msg)
{
    System.Console.Write(msg + " > ");
    return int.Parse(Console.ReadLine());
}

int Power (int num, int exp)
{
    if (exp <= 0)
    {
        return 1;
    }
    return num * Power(num, exp-1);
    
}


int num  = 2;
int exp = 5;
int result = Power(num, exp);
Console.WriteLine(result);

