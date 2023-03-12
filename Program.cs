using System;

namespace practice1
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.Write(" Input number :");
          int number = int.Parse(Console.ReadLine());

          switch (number)
          {
            case 1:
              Console.WriteLine("yellow");
              break;
            case 2:
              Console.WriteLine("orange");
              break;
            case 3:
              Console.WriteLine("yellow");
              Console.WriteLine("orange");
              break;
            case 4:
              Console.WriteLine("red");
              break;
            case 5:
              Console.WriteLine("yellow");
              Console.WriteLine("red");
              break;
            case 6:
              Console.WriteLine("orange");
              Console.WriteLine("red");
              break;
            case 7:
              Console.WriteLine("yellow");
              Console.WriteLine("orange");
              Console.WriteLine("red");
              break;
            default:
              break;
          }
        }  
    }
}
