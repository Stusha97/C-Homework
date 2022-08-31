// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
void CheckPalindrom (string a)
{
    int i =a.Length;
    if ((i ==5) && (a [0] == a [4])&& (a [1] == a [3]))
        Console.WriteLine ("Это число - палиндром");
    else if (i > 5 || i < 5)
        Console.WriteLine ("Это не пятизначное число");
    else
        Console.WriteLine ("Это число не палиндром");
}

Console.WriteLine("Введите число:");
int Num = Convert.ToInt32 (Console.ReadLine());
string Number = Convert.ToString (Num);
CheckPalindrom (Number);
