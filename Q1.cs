using System;

class Program
{
    static void Main()
    {
        // i) Float literal for temperature
        float temperature = 36.6f;  // float literal
        if (temperature > 37.0f)
            Console.WriteLine("Fever");
        else
            Console.WriteLine("Normal");

        // ii) Int literal for age
        int age = 18;  // int literal
        if (age >= 18)
            Console.WriteLine("Eligible to Vote");
        else
            Console.WriteLine("Not Eligible");

        // iii) Char literal for gender
        char gender = 'M';  // char literal
        if (gender == 'M')
            Console.WriteLine("Male");
        else if (gender == 'F')
            Console.WriteLine("Female");
        else
            Console.WriteLine("Other");

        // iv) Double literals for price and discount
        double price = 1000.0;   // double literal
        double discount = 10.0;  // double literal (percentage)
        double finalPrice = price - (price * discount / 100);
        Console.WriteLine("Final Price after discount: " + finalPrice);

        // v) Bool literal for login success
        bool loginSuccess = true;  // bool literal
        if (loginSuccess)
            Console.WriteLine("Login successful");
        else
            Console.WriteLine("Access denied");

        // vi) Declare different literals and display values with data type
        int personAge = 25;
        float bodyTemp = 98.6f;
        char grade = 'A';
        bool isPassed = true;

        Console.WriteLine("Value: " + personAge + ", Type: " + personAge.GetType());
        Console.WriteLine("Value: " + bodyTemp + ", Type: " + bodyTemp.GetType());
        Console.WriteLine("Value: " + grade + ", Type: " + grade.GetType());
        Console.WriteLine("Value: " + isPassed + ", Type: " + isPassed.GetType());
    }
}
