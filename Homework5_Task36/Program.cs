// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
void FillArray (int []arr)
{
for (int i = 0; i < arr.Length; i++)
{
    arr[i]= new Random().Next(-100,100);
    Console.Write (arr [i]+ " ");
}
}

void Sum (int [] numbers)
{
int sum = 0;
for (int i = 1; i < numbers.Length; i+=2)
{
    sum = sum + numbers[i];
}
Console.WriteLine ($"Сумма элементов нечетных позиций = {sum}");
}

Console.WriteLine("Введите количество элементов в массиве:");
int N = Convert.ToInt32 (Console.ReadLine());
int [] array = new int [N];
FillArray (array);
Console.WriteLine();
Sum (array);
