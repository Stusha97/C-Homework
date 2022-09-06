// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Console.Write ("[");
void ArrayPrint (int [] arr)
{
   for (int i = 0; i < arr.Length ;  i++)
   {
      int number = new Random ().Next (0,10);
      arr [i]= number;
      if (i >=0 && i <= arr.Length-2)
      Console.Write (arr [i]+ ",");
      else 
      Console.Write (arr [i]);
   }
   Console.Write ("]");
}
int [] array = new int [8];
ArrayPrint (array);

