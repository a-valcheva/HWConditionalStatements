using System;
using System.Globalization;
using System.Threading;

class BeerTime
{
    //A beer time is after 1:00 PM and before 3:00 AM. Write a program that enters a time in format “hh:mm tt” (an hour in range 
    //[01...12], a minute in range [00…59] and AM / PM designator) and prints “beer time” or “non-beer time” according to the 
    //definition above or “invalid time” if the time cannot be parsed. Note that you may need to learn how to parse dates and 
    //times
    static void Main(string[] args)
    {
        CultureInfo ci = new CultureInfo("en-us");
        //ci.DateTimeFormat.ShortTimePattern = "hh:mm tt";
        Thread.CurrentThread.CurrentCulture = ci;
        Thread.CurrentThread.CurrentUICulture = ci;
        //Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-us");
        //string format = "hh:mm tt";
        
        DateTime newDate = DateTime.Parse(Console.ReadLine());
        //string formatTime = newDate.ToShortTimeString();
        //Console.WriteLine(newDate.ToString());
        //while (newDate.ToShortTimeString() != newDate.ToString())
        //{
        //    Console.WriteLine("Try again");
        //    newDate = DateTime.Parse(Console.ReadLine());
        //    //formatTime = newDate.ToShortTimeString();
        //}
        DateTime startBeer = DateTime.Parse("1:00 PM");
        DateTime endBeer = DateTime.Parse("3:00 PM");
        if (newDate.Hour >= startBeer.Hour && newDate.Hour < endBeer.Hour)
        {
            Console.WriteLine("beer time");
        }
        else
        {
            Console.WriteLine("non-beer time");
        }
    }
}

