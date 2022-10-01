// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
int Read(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
void SumNums(int m, int n)
{
    int sum=0;
    for (int i = m; i <= n; i++)
    {
        sum+=i;
    }
Console.WriteLine($"Сумма элементов между M и N = {sum}");
}
int M = Read("Введите M:");
int N = Read("Введите N:");
SumNums(M, N);
