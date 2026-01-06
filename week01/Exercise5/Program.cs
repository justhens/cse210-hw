using System;

class Program
{
    static void Main(string[] args)
    {
        ShowWelcome();
        string name = GetUserName();
        int favoriteNumber = GetFavoriteNumber();
        int squared = Square(favoriteNumber);
        ShowResult(name, squared);
    }
    static void ShowWelcome()
    {
        Console.WriteLine("Hello! Welcome to this program!");
    }
    static string GetUserName()
    {
        Console.Write("What is your name? ");
        return Console.ReadLine();
    }
    static int GetFavoriteNumber()
    {
        int number;
        bool isValid;
        do
        {
            Console.Write("Enter your favorite number: ");
            string input = Console.ReadLine();
            isValid = int.TryParse(input, out number);
            if (!isValid)
            {
                Console.WriteLine("Oops! That is not a valid number. Please try again.");
            }
        } while (!isValid);
        return number;
    }
    static int Square(int num)
    {
        return num * num;
    }
    static void ShowResult(string userName, int squaredNumber)
    {
        Console.WriteLine($"{userName}, the square of your number is {squaredNumber}");
    }
}
