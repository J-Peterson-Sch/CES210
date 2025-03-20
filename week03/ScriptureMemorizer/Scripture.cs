public class Scripture {

    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        this._reference = reference;
        
        string[] wordsFromText = text.Split(' ');

        foreach (var word in wordsFromText)
        {
            this._words.Add(new Word(word));
        }
    }

    public string display()
    {
        return $"";
    }
}