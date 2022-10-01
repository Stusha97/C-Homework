// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
int Read (string message)
{
    Console.Write (message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray (int [,] matrix)
{
    for (int i=0; i<matrix.GetLength(0); i++)
    {
        for (int j=0; j<matrix.GetLength(1); j++)
        {
            Console.Write (" ");
            matrix [i,j]= new Random().Next(0,10);
            Console.Write ($"{matrix[i,j]}"); 
        }
    Console.WriteLine();
    }
}

void Selection (int [,] matrix)
{
   for (int i=0; i<matrix.GetLength(0); i++)
    {
        for (int j=0; j<matrix.GetLength(1); j++)
        { 
            for (int k=0; k< matrix.GetLength(1)-1; k++)
            {
                if (matrix [i,k]< matrix [i,k+1])
                {
                    int temp = matrix [i,k+1];
                    matrix [i,k+1] = matrix [i,k];
                    matrix [i,k] = temp;
                }
            }
        }
    }
}

void PrintArray (int [,] matrix)
{
    for (int i=0; i<matrix.GetLength(0); i++)
    {
        for (int j=0; j<matrix.GetLength(1); j++)
        {
            Console.Write (matrix [i,j] + " "); 
        }
    Console.WriteLine();
    }
}

int m = Read ("Введите количество строк:");
int n = Read ("Введите количество столбцов:");
int [,] matr = new int [m,n];
Console.WriteLine ("Исходный массив:");
FillArray (matr);
Selection (matr);
Console.WriteLine ("Упорядоченный массив:");
PrintArray (matr);
