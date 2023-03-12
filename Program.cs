using System;

namespace practice1
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.Write("Please input a number of stations: ");
          int n = int.Parse(Console.ReadLine());
          if(n == 1)
          {
            Console.Write("Cost (THB): 16 ");
          }
          else if(n == 2)
          {
            Console.Write("Cost (THB): 23 ");
          }
          else if(n == 3)
          {
            Console.Write("Cost (THB): 26 ");
          }
          else if(n == 4)
          {
            Console.Write("Cost (THB): 30 ");
          }
          else if(n == 5)
          {
            Console.Write("Cost (THB): 33 ");
          }
          else if(n == 6)
          {
            Console.Write("Cost (THB): 37 ");
          }
          else if(n == 7)
          {
            Console.Write("Cost (THB): 40 ");
          }
          else if(n >= 8 && n <= 15)
          {
            Console.Write("Cost (THB): 44 ");
          }
          else if(n > 15)
          {
            Console.Write("Cost (THB): 59 ");
          }
        }   
    }
}
