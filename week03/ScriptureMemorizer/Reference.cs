public class Reference {

    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse = 0;

    public Reference(string book, int chapter, int verse)
    {
        this._book = book;
        this._chapter = chapter;
        this._verse = verse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        this._book = book;
        this._chapter = chapter;
        this._verse = startVerse;
        this._endVerse = endVerse;
    }

    public string getDisplayText()
    {
        if (_endVerse != 0)
        {
            return $"{_book} chapter {_chapter}:{_verse}-{_endVerse}";    
        }
        else
        {
            return $"{_book} chapter {_chapter}:{_verse}";
        }
        
    }
}