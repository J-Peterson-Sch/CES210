public class Scripture {

    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        this._reference = reference;
        this._words = new List<Word>();
        
        string[] wordsFromText = text.Split(' ');

        foreach (var word in wordsFromText)
        {
            this._words.Add(new Word(word));
        }
    }

    public string display()
    {
        string text = "";
        foreach (var word in _words)
        {
            text += word.getDisplayText() + " ";
        }
        return $"{_reference.getDisplayText()} {text}";
    }
}