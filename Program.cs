using System;

namespace practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Year : ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Month : ");
            int month = int.Parse(Console.ReadLine());
            int m = 0;
            if (month >= 1 && month <= 12)
            {
                m = month;
            }
            else
            {
                Console.WriteLine("Invalid Month");
                return;
            }
            Console.Write("Day : ");
            int day = int.Parse(Console.ReadLine());
            int d = 0;
            if (day >= 1 && day <= 31)
            {
                d = day;
            }
            else
            {
                Console.WriteLine("Invalid day");
                return;
            }

            if (year >= 1868 && year <= 1912 )
            {
                Console.WriteLine("Meji");
            }
            else if (year >= 1912 && year <= 1926)
            {
                Console.WriteLine("Taisho");
            }
            else if (year >= 1926 && year <= 1989)
            {
                Console.WriteLine("Showa");
            }
            else if (year >= 1989 && year <= 2019)
            {
                Console.WriteLine("Heisei");
            }
            else if (year >= 2019)
            {
                Console.WriteLine("Reiwa");
            }        
        }  
    }
}
