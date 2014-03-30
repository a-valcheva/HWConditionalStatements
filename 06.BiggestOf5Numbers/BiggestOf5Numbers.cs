using System;

class BiggestOf5Numbers
{
    //Write a program that finds the biggest of five numbers by using only five if statements. 
    static void Main(string[] args)
    {
        decimal numberA = decimal.Parse(Console.ReadLine());
        decimal numberB = decimal.Parse(Console.ReadLine());
        decimal numberC = decimal.Parse(Console.ReadLine());
        decimal numberD = decimal.Parse(Console.ReadLine());
        decimal numberE = decimal.Parse(Console.ReadLine());
        decimal biggest = numberA;//Instead if one if statement.

        if (numberB > biggest)
        {
            biggest = numberB;
        }
        if (numberC > biggest)
        {
            biggest = numberC;
        }
        if (numberD > biggest)
        {
            biggest = numberD;
        }
        if (numberE > biggest)
        {
            biggest = numberE;
        }
        Console.WriteLine(biggest);
    }
}

