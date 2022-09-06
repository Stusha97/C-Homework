// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
void Sum (int a)
{
     int len = Convert.ToString (a).Length;
     int sum = 0;

     for (int i = 0; i < len; i++)
{
     sum += a % 10;
     a = a/10;
} 
 Console.WriteLine ($"Сумма цифр данного числа = {sum}");
}
Console.WriteLine ("Введите число :");
int N = Convert.ToInt32 (Console.ReadLine());
Sum (N);

