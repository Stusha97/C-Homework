// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число:");
int Num = Convert.ToInt32 (Console.ReadLine());
string Number = Convert.ToString (Num);
int i = Number.Length;
if (i < 3)
{
    Console.WriteLine ("3 цифры нет");
}
else
{
    Console.WriteLine (Number [2]);
}

