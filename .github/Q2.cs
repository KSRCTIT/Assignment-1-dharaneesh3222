using System;

class Question2
{
    static void Main()
    {
        // i) Calculator for kids
        int a = 10, b = 5;
        Console.WriteLine("Total apples: " + (a + b));
        Console.WriteLine("Difference of pencils: " + (a - b));
        Console.WriteLine("Total pages: " + (a * b));
        Console.WriteLine("Chocolates per kid: " + (a / b));
        Console.WriteLine("Leftover candies: " + (a % b));

        // ii) Game scores comparison
        int playerA = 20, playerB = 15;
        Console.WriteLine("Player A > Player B: " + (playerA > playerB));
        Console.WriteLine("Scores equal: " + (playerA == playerB));
        Console.WriteLine("Any player failed to beat the other: " + (playerA <= playerB || playerB <= playerA));

        // iii) Login system
        string username = "admin", password = "1234";
        string u = "admin", p = "1234";

        if (u == username && p == password)
            Console.WriteLine("Access Granted");
        else
            Console.WriteLine("Access Denied");

        Console.WriteLine("Using OR: " + (u == username || p == password));
        Console.WriteLine("Using NOT: " + !(u == username));

        // iv) Quiz score updates
        int score = 50;
        score += 10;  // correct
        Console.WriteLine("After correct: " + score);
        score -= 5;   // wrong
        Console.WriteLine("After wrong: " + score);
        score *= 2;   // bonus
        Console.WriteLine("After bonus: " + score);
        score /= 5;   // penalty
        Console.WriteLine("After penalty: " + score);

        // v) Election booth
        for (int i = 1; i <= 5; i++)
        {
            Console.Write("Enter age: ");
            int personAge = Convert.ToInt32(Console.ReadLine());
            if (personAge >= 18)
                Console.WriteLine("Eligible to Vote");
            else
                Console.WriteLine("Not Eligible");
        }
    }
}
