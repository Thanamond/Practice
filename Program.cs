﻿using System;

namespace practice1
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.Write("Please input number 1 :");
          int num1 = int.Parse(Console.ReadLine());
          Console.Write("Please input number 2 :");
          int num2 = int.Parse(Console.ReadLine());
          Console.Write("Please input number 3 :");
          int num3 = int.Parse(Console.ReadLine());
          int sum = num1 + num2 + num3;
          Console.WriteLine("Sum = {0}",sum);
        }   
    }
}