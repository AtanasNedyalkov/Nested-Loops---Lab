using System;

namespace _04._Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int startInterval = int.Parse(Console.ReadLine());
            int endInterval = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int combinationSum = 0;
            int combinationNum = 0;
            for (int a = startInterval; a <=endInterval ; a++)
            {
                for (int b = startInterval; b <= endInterval; b++)
                {
                    combinationSum = a + b;
                    combinationNum++;
                    if (combinationSum == magicNum)
                    {
                        Console.WriteLine($"Combination N:{combinationNum} ({a} + {b} = {magicNum})");
                        return;
                    }
                }
            }
           Console.WriteLine($"{combinationNum} combinations - neither equals {magicNum}"); 
        }
    }
}
