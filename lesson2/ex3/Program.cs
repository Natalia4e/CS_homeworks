//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Не использовать строки для расчета.
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
if (a < 100)
{
    Console.WriteLine($"Третьей цифры нет");
}
else {
    while (a > 999)
    {
        a = a / 10 ;
    }
    Console.WriteLine($"Третья цифра =" + a % 10);
}