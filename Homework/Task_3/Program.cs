// Выяснить является ли число чётным

using System;
  class Program
  {
    static void Main()
     {
       Console.Write("Введите целое число ");
       int x = int.Parse(Console.ReadLine());
       double x_2 = x % 2;
       if (x_2==0) 
          Console.WriteLine("число четное");
       else
       Console.WriteLine("Число нечетное");
       Console.ReadLine();
      }
   }