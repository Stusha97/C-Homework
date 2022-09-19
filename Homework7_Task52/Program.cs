//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int Read (string message)
{
    Console.Write (message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray (int [,] matrix)
{
    for (int i = 0; i<matrix.GetLength (0); i++)
    {
        for (int j=0; j< matrix.GetLength (1) ; j++)
        {
            Console.Write (" ");
            matrix [i,j]= new Random().Next (0,10);
            Console.Write ($"{matrix [i,j]}");
        }
    Console.WriteLine ();
    }
}

void Average (int [,] matrix)
{
double [] average = new double [matrix.GetLength (1)];

for (int i = 0; i<matrix.GetLength (1); i++)
{
    double result = 0.0;
    for (int j=0; j< matrix.GetLength (0); j++)
    {
        result += matrix [j,i];
    }
    average [i] = Math.Round (result/matrix.GetLength (0),2);
}
Console.Write ("Среднее арифметическое столбцов матрицы:");
for (int count = 0; count < average.Length; count++)
{
    Console.Write (average [count] + " ");
}
    Console.WriteLine();
}

int m = Read ("Введите количество строк:");
int n = Read ("Введите количество столбцов:");
int [,] matr = new int [m,n];
PrintArray (matr);
Average (matr);

