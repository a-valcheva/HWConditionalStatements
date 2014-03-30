using System;

class TheBiggestOf3Numbers
{
    //Write a program that finds the biggest of three numbers. 
    static void Main(string[] args)
    {
        decimal numberA = decimal.Parse(Console.ReadLine());
        decimal numberB = decimal.Parse(Console.ReadLine());
        decimal numberC = decimal.Parse(Console.ReadLine());

        //Biggest of three numbers without sorting.
        decimal biggest = numberB;
        if (numberA > numberB)
        {
            biggest = numberA;
        }
        if (numberC > biggest)
        {
            biggest = numberC;
        }
        Console.WriteLine(biggest);

        //Biggest of three numbers with sorting.
        //decimal temp = numberB;
        //if (numberA > numberB)
        //{
        //    temp = numberA;
        //    numberA = numberB;
        //    numberB = temp;
        //}

        //if (numberB > numberC)
        //{
        //    temp = numberB;
        //    numberB = numberC;
        //    numberC = temp;
        //}

        //if (numberA > numberB)
        //{
        //    temp = numberA;
        //    numberA = numberB;
        //    numberB = temp;
        //}

        //Console.WriteLine(numberC);
        //Console.WriteLine("{0} --> {1} --> {2}", numberA, numberB, numberC);
    }
}

