// Показать чётные числа от 1 до N.

using System;
 
class Program
{
    public static void Main()
    {
        Action<int>[] f = new Action<int>[] { n => Console.Write(n), n => Console.Write(' ') };
        for (int i = 2; i <= 50; i++)
        {
            f[i & 1](i);
        }
    }
}