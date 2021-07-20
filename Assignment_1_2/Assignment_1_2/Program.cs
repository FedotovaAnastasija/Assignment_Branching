using System;

namespace Assignment_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("What time is it? ");
            int timeOfDay = Int32.Parse(Console.ReadLine());

            if (timeOfDay <= 12)
            {
                if (timeOfDay >= 0)
                    Console.WriteLine("Good morning, sleepy head!");
            }

            if (timeOfDay < 0)
            {
                Console.WriteLine("Wrong input! Enter a valid number from 0 to 24.");
            }

            if (timeOfDay >= 13)
            {
                if (timeOfDay <= 19)
                    Console.WriteLine("Good Afternoon. Work Hard!");
            }

            if (timeOfDay >= 20)
            {
                if (timeOfDay <= 24)
                    Console.WriteLine("Good Evening.Get some rest!");
            }

            if (timeOfDay > 100)
            {
                Console.WriteLine("Wrong input! Enter a valid number from 0 to 24.");
            }


        }
    }
}
