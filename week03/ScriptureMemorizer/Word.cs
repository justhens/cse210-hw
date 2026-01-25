public class Word
{
    private string text;
    private bool isHidden;

    public Word(string text)
    {
        this.text = text;
        this.isHidden = false;
    }

    public void Hide()
    {
        isHidden = true;
    }

    public void Unhide()
    {
        isHidden = false;
    }

    public string GetDisplayText()
    {
        if (isHidden)
        {
            return new string('_', text.Length);
        }
        return text;
    }

    public bool IsHidden()
    {
        return isHidden;
    }
}
