using System;
public class Practical_Assignment_1_0
{
    public static void Main()
    {
        int number1, number2;
        Console.Write("\n\n");
        Console.Write("Check whether two integers are equal or not:\n");
        Console.Write("-------------------------------------------");
        Console.Write("\n\n");
        Console.Write("Input the 1st number: ");
        number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input the 2nd number: ");
        number2 = Convert.ToInt32(Console.ReadLine());

        if (number1 == number2)
            Console.WriteLine("{0} and {1} are equal.\n", number1, number2);
        else
            Console.WriteLine("{0} and {1} are not equal.\n", number1, number2);
    }
}
