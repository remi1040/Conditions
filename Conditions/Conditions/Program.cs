using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a minimum number: ");
        String numberString1 = Console.ReadLine();
        Console.Write("Enter a maximum number: ");
        String numberString2 = Console.ReadLine();
        Console.Write("Enter a number: ");
        String numberString3 = Console.ReadLine();

        int number1 = Convert.ToInt32(numberString1);
        int number2 = Convert.ToInt32(numberString2);
        int number3 = Convert.ToInt32(numberString3);

        if (number3 < number1)
        {
            Console.Write("You have entered " + number3 + " which is lower than " + number1 + " which is the minimum");
        }
        else if (number3 > number2) {
            Console.Write("You have entered " + number3 + " which is greater than " + number2 + " which is the maximum");
        }



    }
}