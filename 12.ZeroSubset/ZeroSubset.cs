using System;
using System.Collections.Generic;

class ZeroSubset
{
    //We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0. Assume that 
    //repeating the same subset several times is not a problem. 
    static void Main(string[] args)
    {
        int[] numbers = new int[5];
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("Enter an integer:");
            int num = int.Parse(Console.ReadLine());
            numbers[i] = num;
        }

        int sum = 0;
        List<string> subsets = new List<string>();
        for (int i = 0; i < numbers.Length; i++)
        {
            sum = numbers[i];
            subsets.Add(sum.ToString());
            for (int j = i; j < numbers.Length; j++)
            {
                if (i != j)
                {
                    sum += numbers[j];
                    subsets[i] = subsets[i] + "+" + numbers[j].ToString();
                    if (sum == 0)
                    {
                        
                    }
                }
            }
        }
    }
}

