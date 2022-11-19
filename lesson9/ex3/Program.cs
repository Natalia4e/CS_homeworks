// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 
int Prompt(string msg)
{
    System.Console.Write(msg + " > ");
    return int.Parse(Console.ReadLine());
}

int Akkerman(int m, int n)
{
  if (m == 0) 
  {
    return n + 1;
  }
  else if (n == 0)
  {
    return Akkerman(m - 1, 1);
  } 
  else
  {
    return Akkerman(m - 1, Akkerman(m, n - 1));

  }
   
}

int m  = Prompt("Введите число");
int n  = Prompt("Введите число");
int functionAkkerman = Akkerman(m, n);

Console.WriteLine(Akkerman(m,n));