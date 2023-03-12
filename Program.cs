using System;

namespace practice1
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.Write(" Input max number range : ");
          float max = float.Parse(Console.ReadLine());
          Console.Write(" Input min number range : ");
          float min = float.Parse(Console.ReadLine());

          Console.Write(" Input your number : ");
          float num = float.Parse(Console.ReadLine());

          if(num <= max && num >= min)
          {
            Console.WriteLine("True");
          }
          else
          {
            Console.WriteLine("False");
          }
        }   
    }
}
