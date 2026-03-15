//exercise 1
using System.Net.NetworkInformation;

void GreetUser(string name)
{
    Console.WriteLine($"Welcome to DOT1002, {name}!");
}
GreetUser("Freeman");

//exercise 2
decimal pi = 3.14m;
decimal CalculateArea(double radius) 
{
    // This part is perfect!
    decimal area = pi * (decimal)radius * (decimal)radius;
    return area;
}
Console.WriteLine($"Area: {CalculateArea(5)}");

//exercise 3
bool IsValidPassword(string password)
{
    if(password.Length >= 6)
    {
        return true;
    }
    else
    {
        return false;
    }
}
Console.WriteLine($"Is Password Valid? {IsValidPassword("123456")}");

//exercise 4
double CelsiusToFahrenheit(int celsius)
{
    double fahrenheit = (celsius * 9 / 5) + 32;
    return fahrenheit;
}
Console.WriteLine($"42C is {CelsiusToFahrenheit(42)}F");

//exercise 5
void PrintReport(string title, int a1, int a2, int a3, int midterm)
{
    int midtermNet = (int)((a1 * 0.1) + (a2 * 0.1) + (a3 * 0.1) + (midterm * 0.7));
    Console.WriteLine($"---{title}---");
    Console.WriteLine($"Assingment 1: {a1}");
    Console.WriteLine($"Assingment 2: {a2}");
    Console.WriteLine($"Assingment 3: {a3}");
    Console.WriteLine($"Midretm Score: {midterm}");
    Console.WriteLine($"Result for Midterm: {midtermNet}");
}
PrintReport("Midterm", 85, 0, 100, 50);

