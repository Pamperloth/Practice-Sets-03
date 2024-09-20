using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter 1st Side: ");
        double a =Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter 2nd Side: ");
        double b=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter 3rd Side: ");
        double c=Convert.ToInt32(Console.ReadLine());

        double Area=Herons_Formula(a,b,c);
        
        Console.WriteLine("The Area of this Triangle is: " + Area);
    }
    static double Herons_Formula(double a, double b, double c)
    {
        double s = (a + b + c)/2;
        double Area = Math.Sqrt(s*(s-a)*(s-b)*(s-c));
        return Area;
    }
}
