class Word
{
    private string word;
    private bool isHidden;
    private string hiddenString;


    public bool Hide()
    {
        return !isHidden && (isHidden = true); // hehe
    }

    public bool IsHidden()
    {
        return isHidden;
    }

    public string DisplayString()
    {
        return isHidden ? hiddenString : word;
    }

    public Word(string word)
    {
        this.word = word;
        isHidden = false;
        hiddenString = "";
        foreach (char c in word)
            hiddenString += char.IsPunctuation(c) ? c : '_';
    }
}