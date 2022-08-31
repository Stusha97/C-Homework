// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine ("Введите число:");
double a = Convert.ToInt32 (Console.ReadLine ());
Cube (a);

void Cube (double n)
{
int i = 1;
while (i <= n)
{
    Console.Write(i*i*i + " ");
    i= i+1;
}
}
