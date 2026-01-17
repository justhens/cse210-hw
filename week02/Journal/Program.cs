//Added error handling so the program does not crash if the user enters a filename that does not exist.


using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        //journal prompts
        List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "What is one thing I want to improve tomorrow?",
            "What made me laugh today?",
            "What challenge did I face today and how did I handle it?",
            "What am I grateful for today?",
            "What did I learn today?",
            "How did I help someone today?"
        };

        bool running = true;

        while (running)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            if (choice == "1")
            {
                Random random = new Random();
                int index = random.Next(prompts.Count);
                string prompt = prompts[index];

                Console.WriteLine(prompt);
                Console.Write("> ");
                string response = Console.ReadLine();

                Entry entry = new Entry();
                entry._date = DateTime.Now.ToShortDateString();
                entry._promptText = prompt;
                entry._entryText = response;

                journal.AddEntry(entry);
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("Enter the filename: ");
                string fileName = Console.ReadLine();
                journal.SaveToFile(fileName);
            }
            else if (choice == "4")
            {
                Console.Write("Enter the filename: ");
                string fileName = Console.ReadLine();

                // creativity addition: error handling for file loading
                try
                {
                    journal.LoadFromFile(fileName);
                }
                catch (Exception)
                {
                    Console.WriteLine("Error: Unable to load the file.");
                }
            }
            else if (choice == "5")
            {
                running = false;
            }
            else
            {
                Console.WriteLine("Please enter a valid option.");
            }

            Console.WriteLine();
        }
    }
}
