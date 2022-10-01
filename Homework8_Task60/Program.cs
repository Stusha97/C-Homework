// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
int Read (string message)
{
    Console.Write (message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray (int [,,] matrix)
{
    for (int i=0; i<matrix.GetLength(0); i++)
    {
        for (int j=0; j<matrix.GetLength(1); j++)
        {
            for (int k=0; k< matrix.GetLength(1); k++ )
            {
            Console.Write (" ");
            matrix [i,j,k]= new Random().Next(10,100);
            }
        }
    }
}
void PrintArray (int [,,] matrix)
{
    for (int i=0; i<matrix.GetLength(0); i++)
    {
        for (int j=0; j<matrix.GetLength(1); j++)
        {
            for (int k=0; k< matrix.GetLength(2); k++ )
            {
            Console.Write (matrix [i,j,k]);
            Console.Write ((i,j,k) + " "); 
            }
            Console.WriteLine();
        }
    }
}
int x = Read ("Введите X:");
int y = Read ("Введите Y:");
int z = Read ("Введите Z:");
int [,,] matr = new int [x,y,z];
FillArray (matr);
Console.WriteLine();
PrintArray (matr);
