using System;

namespace Assignment_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Please enter date: ");
            int day = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Month: ");
            int month = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Year: ");
            int year = Int32.Parse(Console.ReadLine());

            if (day > 31)
            {
                if (day < 1)
                    Console.WriteLine("Incorrect value!");
            }

            if (month > 12)
            {
                if (month < 1)
                    Console.WriteLine("Incorrect value!");
            }

            if (year > 2021)
            {
                if (year < 0)
                    Console.WriteLine("Incorrect value!");
            }

            Console.WriteLine("What format would you like to choose?");
            Console.WriteLine("1 - YYYY/MM/DD, 2- YYYY.MM.DD. Please enter a number: ");
            int format = Int32.Parse(Console.ReadLine());

            if (format == 1)
            {
                Console.WriteLine("Your date is: " + year + "/" + month + "/" + day + "/");
            }
            else
            {
                Console.WriteLine("Your date is: " + year + "." + month + "." + day + ".");
            }

            if (format < 1)
            {
                if (format > 2)
                    Console.WriteLine("Invalid input.");
            }
        }
    }
}
