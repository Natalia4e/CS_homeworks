// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деление.
Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
int c = a%b;
if (a % b == 0)
{
    Console.WriteLine($"Число {b} кратно {a}.");
}
else
{
    Console.WriteLine($"Число {b} не кртано {a}. Остаток = {c}");
}