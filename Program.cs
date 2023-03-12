using System;

namespace practice1
{
    class Program
    {
        static void Main(string[] args)
        {
          int x = int.Parse(Console.ReadLine());
            double sum = 0;
            double p = 1;
            int i = 1;
            while (i <= x)
            {
            sum += (Math.Pow(p,2));
            p = p + 2;
            i++;
            }
            Console.WriteLine(sum);
        }  
    }
}
