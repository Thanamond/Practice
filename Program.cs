using System;

namespace practice1
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.Write("Input seat number : ");
          int num = int.Parse(Console.ReadLine());

          for (int i = 1; i <= 4; i++)
          {
            num++;
            if (num == 9)
            {
              num = 1;
            }
                if (num == 10)
                {
                    num = 2;
                }
                    if (num == 11)
                    {
                        num = 3;
                    }
                        if (num == 12)
                        {
                            num = 4;
                        }
            Console.WriteLine(num);
          }
        }  
    }
}
