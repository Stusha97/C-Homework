// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
int[,] FillArray(int[,] matrix)
{
    int count = 1, i = 0, j = 0;
    while (count <= matrix.GetLength(0) * matrix.GetLength(1))
    {
        matrix[i, j] = count;
        // count++;
        if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= matrix.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > matrix.GetLength(1) - 1)
            j--;
        else
            i--;
        count++;
    }
return matrix;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] / 10 <= 0)
                Console.Write(matrix[i, j] + "  ");

            else Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[,] array = new int[4, 4];
FillArray (array);
PrintArray (array);
