using System;

class IntDoubleOrString
{
    //Write a program that, depending on the user’s choice, inputs an int, double or string variable. If the variable is int or 
    //double, the program increases it by one. If the variable is a string, the program appends "*" at the end. Print the result 
    //at the console. Use switch statement. 
    static void Main(string[] args)
    {
        Console.WriteLine("Please choose a type:");
        Console.WriteLine("1 --> int\n2 --> double\n3 --> string");
        string choice = Console.ReadLine();
        UseChoice(choice);
        
    }

    private static void UseChoice(string choice)
    {
        int number;
        double number2;
        switch (choice)
        {
            case "1": Console.WriteLine("Please enter an int:");
                string choiceInt = Console.ReadLine();
                while (!Int32.TryParse(choiceInt, out number))
                {
                    goto case "1";
                }
                Console.WriteLine(number + 1);
                break;
            case "2": Console.WriteLine("Please enter a double:");
                string choiceDouble = Console.ReadLine();
                while (!Double.TryParse(choiceDouble, out number2))
                {
                    goto case "2";
                }
                Console.WriteLine(number2 + 1);
                break;
            case "3": Console.WriteLine("Please enter a string:");
                string choiceString = Console.ReadLine();
                Console.WriteLine(choiceString + "*");
                break;
            default: Console.WriteLine("Invalid input.");
                break;
        }
    }
}

