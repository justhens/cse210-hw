using System;
using System.Collections.Generic;

class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something you were proud of."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "What did you learn about yourself through this experience?",
        "How did you feel when it was complete?",
        "How can you apply this experience in the future?"
    };

    public ReflectionActivity()
        : base(
            "Reflection Activity",
            "This activity will help you reflect on times in your life when you have shown strength and resilience."
        )
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on the following questions:");
        Console.WriteLine();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        int index = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(_questions[index]);
            ShowSpinner(5);
            Console.WriteLine();

            index = (index + 1) % _questions.Count;
        }

        DisplayEndingMessage();
    }
}
