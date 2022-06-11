using System;

namespace _03._Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int a = 0; a <= input; a++)
            {
                for (int b = 0; b <= input; b++)
                {
                    for (int c = 0; c <= input; c++)
                    {
                        int sum = a + b + c;
                        if (sum == input)
                        {
                            counter++;
                        }
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
