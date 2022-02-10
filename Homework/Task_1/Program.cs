// Даны два числа. Показать большее и меньшее число.

using System;
 
class Program
{
    static void Main(string[] args)
    {
        int a = 3, b = 8;
        try
        {
            throw new Exception(a > b ? a + " " + b : b + " " + a);
        }
        catch(Exception exc)
        {
            Console.WriteLine(exc.Message);
        }
    }
}