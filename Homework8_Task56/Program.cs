// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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

int [] SumRows (int [,] matrix)
{
    int sum=0;
    int [] a = new int [matrix.GetLength (0)];
    for (int i=0; i<matrix.GetLength(0); i++)
    {
        sum = 0; 
        for (int j=0; j<matrix.GetLength(1); j++)
        { 
            sum = sum + matrix [i,j] ;
        }
    a [i] = sum;
    }
return a;
}

void MinRow (int [] array)
{
    int Min = array [0];
    int MinIndex = 0;
    Console.Write ("Суммы строк матрицы:");
    for (int i= 0; i<array.Length; i++)
    {
    Console.Write (array [i] + " ");
    }
    for (int i=1; i< array.Length; i++)
    {
        if (Min > array [i])
        {
            Min = array [i];
            MinIndex = i;
        }
    }
    Console.WriteLine ();
    Console.WriteLine ($"Строка с наименьшей суммой: {MinIndex+1}");
}
int m = Read ("Введите количество строк:");
int n = Read ("Введите количество столбцов:");
int [,] matr = new int [m,n];
FillArray (matr);
int [] array = SumRows (matr);
MinRow (array);
