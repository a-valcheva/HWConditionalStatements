using System;

class ExchangeIfGreater
{
    //Write an if-statement that takes two integer variables a and b and exchanges their values if the first one is greater than 
    //the second one. As a result print the values a and b, separated by a space. 
    static void Main(string[] args)
    {
        Console.WriteLine("Enter first integer");
        int numberA = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second integer");
        int numberB = int.Parse(Console.ReadLine());

        if (numberA > numberB)
        {
            int temp = numberA;
            numberA = numberB;
            numberB = temp;
        }
        Console.WriteLine(numberA + " " + numberB);
    }
}

