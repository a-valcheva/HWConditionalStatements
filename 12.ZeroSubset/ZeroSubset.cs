using System;
using System.Collections.Generic;

class ZeroSubset
{
    //We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0. Assume that 
    //repeating the same subset several times is not a problem. 
    static void Main(string[] args)
    {
        //The implementation is not ready! Still a lot of work to do! Still not working correctly!
        int[] numbers = new int[5];
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("Enter an integer:");
            int num = int.Parse(Console.ReadLine());
            numbers[i] = num;
            sum += num;
        }

        int checkSum;
        for (int i = 0; i < numbers.Length; i++)
        {
            checkSum = sum - numbers[i];
            if (checkSum == 0)
            {
                PrintNumber(numbers, i, 0);
            }
            for (int j = i; j < numbers.Length; j++)
            {
                if (i != j)
                {
                    checkSum -= numbers[j];
                    if (checkSum == 0)
                    {
                        PrintNumber(numbers, j, i);
                    }
                    for (int n = j; n < numbers.Length; n++)
                    {
                        if (j != n)
                        {
                            checkSum -= numbers[n];
                            if (checkSum == 0)
                            {
                                PrintNumber(numbers, n, j);
                            }
                        }
                    }
                }
            }
        }
    }

    private static void PrintNumber(int[] numbers, int j, int start)
    {
        for (int w = start; w < numbers.Length; w++)
        {
            if (w != j)
            {
                if (w == numbers.Length-1)
                {
                    Console.Write(numbers[w] + "= 0");
                }
                else
                {
                    Console.Write(numbers[w] + "+");
                }
            }
        }
        Console.WriteLine();
    }
}

