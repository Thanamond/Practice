using System;

namespace practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the range of a wall : ");
            string n = (Console.ReadLine());
            int num = 0;
            if (int.TryParse(n,out num))
            {
                if (num >= 0 && num % 2 == 0)
                {
                    Console.Write("{0},{1}", (num/2),(num/2+1));
                }
                else if (num < 0)
                {
                    Console.Write("Please input a positive integer.");
                }
                else if (num % 2 !=0)
                {
                    Console.Write("Please input an even positive integer.");
                }
            }
            else
            {
                Console.Write("Please input an integer.");
            }
        } 
    }
}
