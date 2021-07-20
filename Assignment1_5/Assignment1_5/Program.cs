using System;

class Assignment1_5
{
    static void Main(string[] args)
    {
        double workingHDay = 8, ratePerDay;
        Console.WriteLine("Enter the working hours per day: ");
        if (Double.TryParse(Console.ReadLine(), out workingHDay))
        {
            Console.WriteLine("Input is incorrect");
            
        }
        if (workingHDay < 0 || workingHDay > 24)
        {
            Console.WriteLine("Working hours is incorrect");
            return;
        }
        if (workingHDay <= 8)
        {
            ratePerDay = 80;

        }
        else
        {
            ratePerDay = 80 + ((workingHDay - 8) * 15);
            Console.WriteLine("Rate per day: " + ratePerDay);
        }
    }
}