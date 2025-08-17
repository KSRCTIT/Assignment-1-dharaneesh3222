using System;
using System.Text.RegularExpressions;

class Question3
{
    static void Main()
    {
        // i) ATM PIN system
        int pin = 1234, attempts = 0;
        bool access = false;
        while (attempts < 3)
        {
            Console.Write("Enter PIN: ");
            int entered = Convert.ToInt32(Console.ReadLine());
            if (entered == pin)
            {
                Console.WriteLine("Access Granted");
                access = true;
                break;
            }
            else
                Console.WriteLine("Wrong PIN");
            attempts++;
        }
        if (!access)
            Console.WriteLine("Card Blocked");

        // ii) Multiplication table
        string choice;
        do
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
                Console.WriteLine($"{num} x {i} = {num * i}");

            Console.Write("Do you want another number? (Y/N): ");
            choice = Console.ReadLine();
        } while (choice.ToUpper() == "Y");

        // Electricity bill
        Console.Write("Enter units consumed: ");
        int units = Convert.ToInt32(Console.ReadLine());
        int bill = 0;
        if (units <= 100)
            bill = units * 2;
        else if (units <= 200)
            bill = 100 * 2 + (units - 100) * 3;
        else
            bill = 100 * 2 + 100 * 3 + (units - 200) * 5;
        Console.WriteLine("Total Bill: ₹" + bill);

        // iii) Student scores
        int[] marks = new int[5];
        int sum = 0;
        Console.WriteLine("Enter 5 subject marks:");
        for (int i = 0; i < 5; i++)
        {
            marks[i] = Convert.ToInt32(Console.ReadLine());
            sum += marks[i];
        }
        double avg = sum / 5.0;
        Console.WriteLine("Average: " + avg);
        if (avg >= 40)
            Console.WriteLine("Passed");
        else
            Console.WriteLine("Failed");

        // iv) Name validation
        Console.Write("Enter name: ");
        string name = Console.ReadLine();
        if (Regex.IsMatch(name, @"^[a-zA-Z\s]+$"))
            Console.WriteLine("Valid Name");
        else
            Console.WriteLine("Invalid Name");
    }
}
