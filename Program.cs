using System;

namespace practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            string job = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            int y = 0;
            while (year < 2565)
            {
                job = Console.ReadLine();
                year = int.Parse(Console.ReadLine());
                y = year;
                if (year < y)
                {
                    Console.WriteLine(year);
                }
            }
            //Console.WriteLine(job);
            //Console.WriteLine(year);
        }  
    }
}
