// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите число:");
int x = Convert.ToInt32 (Console.ReadLine());
if ((x == 6)|| (x == 7))
{
    Console.WriteLine (x + "- это выходной");
}
 else if ((x < 1)|| (x > 7))
{
    
    Console.WriteLine (x + "- нет такого дня недели");
}
else 
{
  Console.WriteLine (x + "- это будний день");  
}
