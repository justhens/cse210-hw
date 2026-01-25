public class Reference
{
    public string Book { get; }
    public int Chapter { get; }
    public int VerseStart { get; }
    public int VerseEnd { get; }
    public Reference(string book, int chapter, int verse)
    {
        Book = book;
        Chapter = chapter;
        VerseStart = verse;
        VerseEnd = verse;
    }
    public Reference(string book, int chapter, int verseStart, int verseEnd)
    {
        Book = book;
        Chapter = chapter;
        VerseStart = verseStart;
        VerseEnd = verseEnd;
    }

    public string GetReferenceText()
    {
        if (VerseStart == VerseEnd)
        {
            return $"{Book} {Chapter}:{VerseStart}";
        }
        return $"{Book} {Chapter}:{VerseStart}-{VerseEnd}";
    }
}
