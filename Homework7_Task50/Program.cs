/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет.*/
int Read (string message)
{
    Console.Write (message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray (int [,] matrix)
{
    for (int i = 0; i<matrix.GetLength(0); i++)
    {
        for (int j=0; j< matrix.GetLength(1); j++)
        {
            Console.Write (" ");
            matrix [i,j]= new Random().Next (0,10);
            Console.Write ($"{matrix [i,j]}");
        }
    Console.WriteLine ();
    }
}

void ShowElement (int [,] matrix)
{
    int m = Read ("Введите строку элемента:");
    int n = Read ("Введите столбец элемента:");
    if ((m <= matrix.GetLength(0)) && (n<= matrix.GetLength(1)))
    Console.WriteLine ($"Элемент {m} строки и {n} столбца = {matrix [m-1,n-1]}");
    else
    Console.WriteLine ("Такого числа в массиве нет");
}

int x = Read ("Введите количество строк:");
int y = Read ("Введите количество столбцов:");
int [,] matr = new int [x,y];
PrintArray (matr);
ShowElement (matr);