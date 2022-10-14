// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int N = Prompt ("Введите пятизначное число: ");

int first_number = N / 10000;
int second_number = N % 10000 /1000;
int fourth_number = N % 100 /10;
int fifth_number =N % 10;

if ( N > 9999 & N < 100000 )
{
     Console.WriteLine($"Число пятизначное");
    if (first_number == fifth_number && second_number == fourth_number)
    {
        Console.WriteLine($"Число является палиндромом");
    }
    else 
    {
        Console.WriteLine($"Число не является палиндромом");
    }
}

else {
    Console.WriteLine($"Число не пятизначное"); 
}



