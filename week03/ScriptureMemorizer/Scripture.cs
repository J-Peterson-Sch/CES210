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

    public void blankOutWords(int numberToBlankOut)
    {
        int hiddenWordCount = numberOfHiddenWords();
        if (numberToBlankOut > _words.Count - hiddenWordCount)
        {
            numberToBlankOut = _words.Count - hiddenWordCount;
        }
        
        Random random = new Random();
        int randomNumber = 0;

        for (int i = 0; i < numberToBlankOut; i++)
        {
            do
            {
                randomNumber = random.Next(0, _words.Count);
                if (!_words[randomNumber].isHidden())
                {
                    _words[randomNumber].hide();
                    break;
                }                
            } while (true);
        }
    }

    private int numberOfHiddenWords()
    {
        int numberOfHiddenWords = 0;
        foreach (Word word in _words)
        {
            if (word.isHidden())
            {
                numberOfHiddenWords += 1;
            }
        }
        return numberOfHiddenWords;
    }
}