// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
double Read (string message)
{
    Console.Write(message);
    return Convert.ToDouble (Console.ReadLine());
}


void FindPoint (double k1, double k2, double b1, double b2)
{
    //double [] point = new double [2];
    if (k1 == k2)
    Console.WriteLine ("Прямые не пересекаются");
    else
    {
        double x = (b2-b1)/ (k1-k2);
        double y = k1 * x + b1;
        Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");
    }  
}
double k1 = Read ("Введите k1:");
double k2 = Read ("Введите k2:");
double b1 = Read ("Введите b1:");
double b2 = Read ("Введите b2:");
FindPoint(k1, k2, b1, b2);



