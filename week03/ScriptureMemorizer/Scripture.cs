using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference reference;
    private List<Word> words;
    private Random rand = new Random();

    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        words = new List<Word>();
        foreach (var w in text.Split(' '))
        {
            words.Add(new Word(w));
        }
    }

    public void Display()
    {
        Console.WriteLine(reference.GetReferenceText());
        foreach (var word in words)
        {
            Console.Write(word.GetDisplayText() + " ");
        }
        Console.WriteLine("\n");
    }
    public void HideRandomWords()
    {
        var visibleWords = words.Where(w => !w.IsHidden()).ToList();

        if (visibleWords.Count == 0)
            return;

        int wordsToHide = Math.Min(rand.Next(1, 4), visibleWords.Count);

        for (int i = 0; i < wordsToHide; i++)
        {
            int index = rand.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    // Shows creativity and exceeds core requirements: gives option to unhide some hidden words
    public void UnhideRandomWords()
    {
        var hiddenWords = words.Where(w => w.IsHidden()).ToList();

        if (hiddenWords.Count == 0)
            return;

        int wordsToUnhide = Math.Min(rand.Next(1, 4), hiddenWords.Count);

        for (int i = 0; i < wordsToUnhide; i++)
        {
            int index = rand.Next(hiddenWords.Count);
            hiddenWords[index].Unhide();
            hiddenWords.RemoveAt(index);
        }
    }

    public bool AllWordsHidden()
    {
        return words.All(w => w.IsHidden());
    }
}
