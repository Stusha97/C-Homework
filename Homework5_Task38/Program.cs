// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
void FillArray (double []arr)
{
for (int i = 0; i < arr.Length; i++)
{
    double number = new Random().NextDouble()*100;
    arr [i]= Math.Round (number,2);
    Console.Write (arr [i]+ " ");
}
}
void MaxMinDifference (double [] numbers)
{
double Max = numbers [0], MaxIndex = 0;
double Min = numbers [0], MinIndex = 0;
for (int i = 1; i < numbers.Length; i++)
{
    if (Max < numbers [i])
    {
      Max = numbers [i];
      MaxIndex = i;
    }
    else if (Min > numbers [i])
    {
      Min = numbers [i];
      MinIndex = i;
    }
}
Console.WriteLine ($"Максимальный элемент массива = {Max},минимальный элемент массива = {Min}");
Console.WriteLine ($"Разница между макс. и мин. элементами = {Max - Min}");
}
Console.WriteLine("Введите количество элементов в массиве:");
int N = Convert.ToInt32 (Console.ReadLine());
double [] array = new double [N];
FillArray (array);
Console.WriteLine ();
MaxMinDifference (array);

