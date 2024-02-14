class Scripture
{
    private List<Word> words;
    private Reference reference;
    private Random random;


    public Scripture(string text, Reference reference)
    {
        words = new();
        random = new();
        this.reference = reference;
        foreach (string word in text.Split(" ")) words.Add(new Word(word));
    }

    public string DisplayString()
    {
        string text = reference.DisplayString();
        foreach (Word word in words) text += " " + word.DisplayString();
        return text;
    }

    public void HideWords(int wordsToHide)
    {
        int count = int.Min(WordsLeft(), wordsToHide);
        for (int i = 0;i < count;i++)
            if (!words[random.Next(0,words.Count)].Hide()) HideWords(1);
    }

    public int WordsLeft()
    {
        int n = 0;
        foreach (Word word in words) if (!word.IsHidden()) n++;
        return n;
    }
}