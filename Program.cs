using System;

namespace practice1
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.Write(" Input the multiplier : ");
          int mult = int.Parse(Console.ReadLine());
            int i = 1;
            int sum = 2;
            while (i < mult)
            {
                sum *= 2;
                i++;
            }
            Console.WriteLine("The result is : {0}",sum);
        }   
    }
}
