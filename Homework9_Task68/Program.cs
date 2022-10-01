// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
int Read(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int AkkermanFunction(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n==0) return AkkermanFunction (m-1,1);
    else return AkkermanFunction (m-1, AkkermanFunction(m,n-1));
}
int M = Read("Введите M:");
int N = Read("Введите N:");
int A = AkkermanFunction (M,N);
Console.Write($"Функция Аккермана = {A} ");