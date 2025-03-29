public class Comment {

    public string _author;
    private string _text;

    public Comment(string author, string text)
    {
        this._author = author;
        this._text = text;
    }

    public void display()
    {
        Console.WriteLine($"{_author}: {_text}");
    }
}