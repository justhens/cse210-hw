// Extra Credit Features:
// Used timed loops instead of fixed repetitions to ensure each activity runs for the exact time selected by the user.
// Randomized prompts to provide a different experience each time an activity is run

using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine();
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflection Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                    break;

                case "2":
                    ReflectionActivity reflection = new ReflectionActivity();
                    reflection.Run();
                    break;

                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                    break;

                case "4":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Press Enter to continue.");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
