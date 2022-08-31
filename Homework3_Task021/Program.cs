// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
int ReadMessage (string message )
{
    Console.Write (message);
    return Convert.ToInt32 (Console.ReadLine ());
}
 
int x1=  ReadMessage ("Введите х1: ");
int y1=  ReadMessage ("Введите y1: ");
int z1= ReadMessage ("Введите z1: ");
int x2= ReadMessage ("Введите х2: ");
int y2= ReadMessage ("Введите y2: ");
int z2= ReadMessage ("Введите z2: ");
int x = x2-x1;
int y = y2-y1;
int z = z2-z1;
double Distance = Math.Sqrt (x*x + y*y + z*z);
Console.WriteLine ("Расстояние между точками:" + Distance);

