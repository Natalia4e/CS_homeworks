// Задача 2: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
const int X = 0;
const int Y = 1;
const int Z = 2;

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}


int [] InputPoint(int point)
{
    int[] answer = new int[3]; // [0,0]
    answer[X] = Prompt($"Введите x {point} ->"); // [1,0]
    answer[Y] = Prompt($"Введите y {point} ->"); // [10,0]
    answer[Z] = Prompt($"Введите z {point} ->"); // [10,0]
    return answer;
}

int Power2(int arg)
{
    return arg*arg;
}

int [] p1 = InputPoint(1);
int [] p2 = InputPoint(2);

double lenght = Math.Sqrt(Power2(p1[X] - p2[X])+Power2(p1[Y] - p2[Y])+Power2(p1[Z] - p2[Z])); //Math.sqrt

Console.WriteLine($"{lenght:F2}"); //f - кол-во знаков после запятой