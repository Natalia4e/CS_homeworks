//  Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверт
int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool ValidateCoords (int quarter)
{
    if (quarter > 4 && quarter <1 )
    {
        System.Console.WriteLine("Вы ввели неправильную четверть");
        return false;
    }
    return true;
}
string GetCoords (int quarter)
{
    switch (quarter)
    {
        case 1:
        return "x > 0 && y > 0";
        case 2:
        return "x < 0 && y > 0";
        case 3:
        return "x < 0 && y < 0";
        default:
        return "x > 0 && y < 0";
    }
}

int quarter = Prompt ("Введите номер четверти");
if(!ValidateCoords(quarter))
{
    return;
}
System.Console.WriteLine(GetCoords(quarter));