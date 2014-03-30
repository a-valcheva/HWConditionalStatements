using System;

class BiggestOf5NumbersV2
{
    //Write a program that finds the biggest of five numbers by using only five if statements. 
    static void Main(string[] args)
    {
        decimal[] numbers = new decimal[5];
        decimal biggest = numbers[0];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = decimal.Parse(Console.ReadLine());
            if (numbers[i] > biggest)
            {
                biggest = numbers[i];
            }
        }
        Console.WriteLine(biggest);
    }
}

