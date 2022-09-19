// Задача 47. Задайте двумерный массив размером mхn, заполненный случайными вещественными числами.
int Read (string message)
{
    Console.Write (message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray (double [,] matrix)
{
    for (int i = 0; i<matrix.GetLength(0); i++)
    {
        for (int j=0; j< matrix.GetLength(1); j++)
        {
            Console.Write (" ");
	    matrix [i,j]= Math.Round (new Random().NextDouble()*10,1);
            Console.Write ($"{matrix [i,j]}");
        }
    Console.WriteLine ();
    }
}


int m = Read ("Введите количество строк:");
int n = Read ("Введите количество столбцов:");
double [,] matr = new double [m,n];
PrintArray (matr);
