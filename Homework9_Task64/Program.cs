// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
int Read(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
void ShowNums(int m, int n)
{
    for (int i = m; i <= n; i++)
    {
        Console.Write(i + ",");
    }
}
int M = Read("Введите M:");
int N = Read("Введите N:");
ShowNums(M, N);

