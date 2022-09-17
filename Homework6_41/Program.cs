// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int [] GetArray ()
{
    Console.WriteLine ("Введите число m:");
    int M = Convert.ToInt32 (Console.ReadLine());
    Console.WriteLine ("Введите m чисел:");
    int [] array = new int [M];
    for (int i =0; i< M; i++)
    {
        array [i] = Convert.ToInt32 (Console.ReadLine());
    }
return array;
}

void Calculation (int [] arr)
{
    int count = 0;
    for (int i =0; i< arr.Length; i++)
    {
        if (arr [i] > 0)
        count ++;
    }
    Console.WriteLine ($"Количество чисел массива больше нуля: = {count}");
}
int [] array = GetArray ();
Calculation (array);

