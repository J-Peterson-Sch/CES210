public class Video {

    public string _title;
    private string _author;
    private double _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string author, string title, double length)
    {
        this._author = author;
        this._title = title;
        this._length = length;

    }

    public void addComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public void display()
    {
        Console.WriteLine($"{_title} - {_author}: {_length} seconds");
        Console.WriteLine($"Comments: {numberOfComments()}");

        foreach (Comment comment in _comments)
        {
            comment.display();
        }
        Console.WriteLine("------------------------------------");
    }

    public int numberOfComments()
    {
        return _comments.Count;
    }
}