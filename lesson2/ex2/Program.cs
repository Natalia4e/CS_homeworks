// Задача 2: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. Не использовать строки для расчета.
int rnd = new Random().Next(100,999);
System.Console.WriteLine(rnd);
int first_number = rnd / 100; 
int third_number = rnd % 10;
System.Console.WriteLine(third_number + first_number * 10);
