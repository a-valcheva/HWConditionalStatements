using System;

class NumberAsWords
{
    //Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation. 
    private static string PrintTenName(int ten)
    {
        string number = null;
        switch (ten)
        {
            case 1: number = "Ten"; break;
            case 2: number = "Twenty"; break;
            case 3: number = "Thirty"; break;
            case 4: number = "Fourty"; break;
            case 5: number = "Fifty"; break;
            case 6: number = "Sixty"; break;
            case 7: number = "Seventy"; break;
            case 8: number = "Eighty"; break;
            case 9: number = "Ninety"; break;
            default: number = null; break;
        }
        return number;
    }

    private static string PrintTeenName(int teen)
    {
        string number = null;
        switch (teen)
        {
            case 11: number = "Eleven"; break;
            case 12: number = "Twelve"; break;
            case 13: number = "Thirteen"; break;
            case 14: number = "Fourteen"; break;
            case 15: number = "Fifteen"; break;
            case 16: number = "Sixteen"; break;
            case 17: number = "Seventeen"; break;
            case 18: number = "Eighteen"; break;
            case 19: number = "Nineteen"; break;
            default: number = null; break;
        }
        return number;
    }

    private static string PrintUnitName(int unit)
    {
        string number = null;
        switch (unit)
        {
            case 0: number = "Zero"; break;
            case 1: number = "One"; break;
            case 2: number = "Two"; break;
            case 3: number = "Three"; break;
            case 4: number = "Four"; break;
            case 5: number = "Five"; break;
            case 6: number = "Six"; break;
            case 7: number = "Seven"; break;
            case 8: number = "Eight"; break;
            case 9: number = "Nine"; break;
            default: number = null; break;
        }
        return number;
    }

    private static string PrintNumber(int unit, int secondDigit, int teen)
    {
        string number;
        if (unit == 0)
        {
            number = PrintTenName(secondDigit);
        }
        else if (secondDigit == 1 && unit != 0)
        {
            number = PrintTeenName(teen);
        }
        else
        {
            number = PrintTenName(secondDigit) + " " + PrintUnitName(unit).ToLower();
        }
        return number;
    }

    private static string PrintFinal(int newNumber)
    {
        string number;
        int unit = newNumber % 10;
        int secondDigit = (newNumber / 10) % 10;
        int teen = newNumber % 100;
        int hundred = newNumber / 100;

        if (newNumber.ToString().Length == 1)
        {
            number = PrintUnitName(unit);
        }
        else if (newNumber.ToString().Length == 2)
        {
            number = PrintNumber(unit, secondDigit, teen);
        }
        else
        {
            if (unit == 0 && secondDigit == 0)
            {
                number = PrintUnitName(hundred) + "hundred";
            }
            else
            {
                number = PrintUnitName(hundred) + " hundred and " + PrintNumber(unit, secondDigit, teen).ToLower();
            }
        }
        return number;
    }

    static void Main(string[] args)
    {
        int newNumber = int.Parse(Console.ReadLine());
        string number = PrintFinal(newNumber);
        Console.WriteLine(number);
    }
}

