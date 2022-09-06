// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine ("Введите A:");
double A = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите B:");
double B = Convert.ToInt32 (Console.ReadLine());
double result = 1;
for (double i = 1; i <= B; i++)
{
     result = Math.Pow (A,i);
} 
Console.WriteLine ($"Число А в степени числа В = {result}");

