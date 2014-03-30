using System;

class MultiplicationSign
{
    //Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it. Use a 
    //sequence of if operators. 
    static void Main(string[] args)
    {
        string numbers = Console.ReadLine();
        int counterMinus = 0;
        int counterZero = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == '-')
            {
                counterMinus++;
            }
            if (numbers[i] == '0')
            {
                counterZero++;
            }
        }
        if (counterZero > 0)
        {
            Console.WriteLine("0");
        }
        else
        {
            if (counterMinus % 2 == 0)
            {
                Console.WriteLine("+");
            }
            else
            {
                Console.WriteLine("-");
            }
        }
    }
}

