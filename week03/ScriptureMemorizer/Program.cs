// To show Creativity I added the option to unhide some words that were previously hidden.
// That will be shown in the scripture.cs file

using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

        while (true)
        {
            Console.Clear();
            scripture.Display();

            Console.WriteLine("Press Enter to hide words, type 'unhide' to reveal some words, or type 'quit' to exit.");
            string input = Console.ReadLine().ToLower();

            if (input == "quit")
                break;
            else if (input == "unhide")
                scripture.UnhideRandomWords();
            else
                scripture.HideRandomWords();

            if (scripture.AllWordsHidden())
            {
                Console.Clear();
                scripture.Display();
                Console.WriteLine("All words are hidden! Well done!");
                break;
            }
        }
    }
}
