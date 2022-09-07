//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
void FillArray (int []arr)
{
for (int i = 0; i < arr.Length; i++)
{
    arr[i]= new Random().Next(100,1000);
    Console.Write (arr [i]+ " ");
}
}
void Count (int [] numbers)
{
int count = 0;
foreach (int a in numbers)
{
    if (a % 2 == 0)
    count ++;
}
Console.WriteLine ($"Количество четных элементов в массиве = {count}");
}

Console.WriteLine("Введите количество элементов в массиве:");
int N = Convert.ToInt32 (Console.ReadLine());
int [] array = new int [N];
FillArray (array);
Console.WriteLine();
Count (array);
