﻿using System;

namespace _05._Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            while (destination != "End")
            {
                double savings = 0;
                double budget = double.Parse(Console.ReadLine());
                while (savings<budget)
                {
                    savings += double.Parse(Console.ReadLine());

                }
                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();
            }
        }
    }
}