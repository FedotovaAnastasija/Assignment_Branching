using System;

namespace Assignment_1_1
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("Please enter the first value: ");
            int val1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the second value: ");
            int val2 = Int32.Parse(Console.ReadLine());

            if (val1 > val2)
            {
                Console.WriteLine("The first value is bigger than the second. Second value is the smallest. " + val1 + " > " + val2);
            }
            else
            {
                Console.WriteLine(" The second value is bigger than the first. First value is the smallest. " + val2 + " > " + val1);
            }

            if (val1 == val2)
            {
                Console.WriteLine("The values are equal. ");
            }
            else
            {
                Console.WriteLine(" Values are not equal. ");
            }

            if (val1 % 2 == 0)
            {
                Console.WriteLine("First value is even.");
}
            else
            {
                Console.WriteLine("First value is odd.");
           }

            if (val2 % 2 == 0)
            {
                Console.WriteLine("Second value is even.");
}
            else
            {
                Console.WriteLine("Second value is odd.");
           }

            if (val1 > 0)
            {
                Console.WriteLine("First value is positive.");
            }
            else
            {
                Console.WriteLine("First value is negative.");
            }

            if (val2 > 0)
            {
                Console.WriteLine("Second value is positive.");
            }
            else
            {
                Console.WriteLine("Second value is negative.");
            }

            if (val1 < 100)
            {
                Console.WriteLine("First value is less than 100.");
            }
            else
            {
                Console.WriteLine("First value is more than 100.");
            }

            if (val2 < 100)
            {
                Console.WriteLine("Second value is less than 100.");
            }
            else
            {
                Console.WriteLine("Second value is more than 100.");
            }
        }
    }
}
