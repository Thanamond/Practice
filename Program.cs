using System;

namespace practice1
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.Write("Input number: ");
          int num = int.Parse(Console.ReadLine());
          if (num >= 0)
          {
            Console.WriteLine(num);
          }
          else
          {
            Console.WriteLine(-num);
          }
        }  
    }
}
