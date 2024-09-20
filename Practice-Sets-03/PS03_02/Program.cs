using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter Year: ");
        int year=Convert.ToInt32(Console.ReadLine());

        if (Leap_Test(year))
        {
            Console.WriteLine("Leap year.");
        }
        else
        {
            Console.WriteLine("Not a leap year.");
        }
    }

    static bool Leap_Test (int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }
}
