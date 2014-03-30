using System;

class NestedIfsSortNumbers
{
    //Write a program that enters 3 real numbers and prints them sorted in descending order. Use nested if statements. Don’t use 
    //arrays and the built-in sorting functionality. 
    static void Main(string[] args)
    {
        decimal numberA = decimal.Parse(Console.ReadLine());
        decimal numberB = decimal.Parse(Console.ReadLine());
        decimal numberC = decimal.Parse(Console.ReadLine());

        decimal temp = numberB;

        if (numberA < numberB)
        {
            temp = numberA;
            numberA = numberB;
            numberB = temp;

            if (numberB < numberC)
            {
                temp = numberB;
                numberB = numberC;
                numberC = temp;
            }
            if (numberA < numberB)
            {
                temp = numberA;
                numberA = numberB;
                numberB = temp;
            }
        }
        else
        {
            if (numberB < numberC)
            {
                temp = numberB;
                numberB = numberC;
                numberC = temp;
            }
            if (numberA < numberB)
            {
                temp = numberA;
                numberA = numberB;
                numberB = temp;
            }
        }
        Console.WriteLine("{0} --> {1} --> {2}", numberA, numberB, numberC);
    }
}

