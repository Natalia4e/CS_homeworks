// 1. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 или Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точк

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool ValidateCoords(int xCoord, int yCoord)
{
    if (xCoord == 0 || yCoord ==0)
    {
        Console.WriteLine("Тояка находится как минимум на одной из осей");
        return false;
    }
    return true;
}

int x = Prompt ("Введите x >");
int y = Prompt ("Введите y >");

if(!ValidateCoords(x,y))
{
    return;
}

if (x > 0 && y > 0)
{
    System.Console.WriteLine("1 четверть");
}
if (x > 0 && y < 0)
{
    System.Console.WriteLine("4 четверть");
}
if (x < 0 && y > 0)
{
    System.Console.WriteLine("2 четверть");
}
if (x < 0 && y < 0)
{
    System.Console.WriteLine("3 четверть");
}