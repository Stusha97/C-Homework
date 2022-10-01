// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
int [,] FillMatrix ( )
{
    int [,] matrix = new int [2,2];
    for (int i=0; i<matrix.GetLength(0); i++)
    {
        for (int j=0; j<matrix.GetLength(1); j++)
        {
            Console.Write (" ");
            matrix [i,j]= new Random().Next(0,10);
        }
    }
    return matrix;
}

void PrintMatrix (int [,] matrix)
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
int [,] MultiplyMatrix (int [,] matrix1,int [,] matrix2 )
{
    int [,] matrix3= new int [2,2];
    for (int i=0; i<matrix3.GetLength(0); i++)
    {
        for (int j=0; j<matrix3.GetLength(1);j++ )
        {
        int sum = 0;
        for (int k=0; k<matrix1.GetLength(1);k++ )
        {
            sum += matrix1 [i,k] * matrix2 [k,j]; 
        }
        matrix3 [i,j] = sum;
        }
    }
    return matrix3;
}

int [,] matrix1 = FillMatrix ();
Console.WriteLine ("Матрица 1:");
PrintMatrix (matrix1);
int [,] matrix2 = FillMatrix ();
Console.WriteLine ("Матрица 2:");
PrintMatrix (matrix2);
Console.WriteLine ("Произведение матриц 1 и 2:");
MultiplyMatrix (matrix1,matrix2);
PrintMatrix (MultiplyMatrix (matrix1,matrix2));
