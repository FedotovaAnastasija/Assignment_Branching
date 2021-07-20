using System;

namespace Assignment_1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program where calculation of month will be performed if day number of the year is given.  For example, if the day number is 10, it is January, if day number is 32 - February, if day number is 100 - April, etc.
Information shown in the console:
The day number is: 100
It is: April

*It is possible to read user input from the console with Console.ReadLine() command.
Please ask the user to write the day number in the console. Read it and calculate which month it is. 
*/
            Console.WriteLine("Please enter amount of days: ");
            int days = Int32.Parse(Console.ReadLine());

            if (days <= 31)
            {
                if (days > 0)
                Console.WriteLine("This is January");
            }

            if (days >=31)
            { 
                if (days <= 59)

                Console.WriteLine("This is Febuary");
            }

            if (days >= 60)
            {
                if (days <= 90)

                    Console.WriteLine("This is March");
            }

            if (days >= 91)
            {
                if (days <= 120)

                    Console.WriteLine("This is April");
            }

            if (days >= 121)
            {
                if (days <= 152)

                    Console.WriteLine("This is May");
            }

            if (days >= 153)
            {
                if (days <= 182)

                    Console.WriteLine("This is June");
            }

            if (days >= 182)
            {
                if (days <= 213)

                    Console.WriteLine("This is July");
            }

            if (days >= 213)
            {
                if (days <= 244)

                    Console.WriteLine("This is August");
            }

            if (days >= 244)
            {
                if (days <= 274)

                    Console.WriteLine("This is September");
            }

            if (days >= 274)
            {
                if (days <= 305)

                    Console.WriteLine("This is October");
            }

            if (days >= 305)
            {
                if (days <= 335)

                    Console.WriteLine("This is November");
            }

            if (days >= 335)
            {
                if (days <= 366)

                    Console.WriteLine("This is December");
            }

            if (days < 0)
            {
                Console.WriteLine("Invalid input. Please enter a value from 1 to 366. ");
            }

            if (days > 366)
            {
                Console.WriteLine("Invalid input. Please enter a value from 1 to 366. ");
            }
        }
    }
}
