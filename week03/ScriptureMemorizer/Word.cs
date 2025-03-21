public class Word {

    private string _text;
    private bool _isHidden = false;

    public Word(string text)
    {
        this._text = text;
    }

    public void hid()
    {
        _isHidden = true;
    }

    public void show()
    {
        _isHidden = false;
    }

    public bool isHidden()
    {
        return _isHidden;
    }

    public string getDisplayText()
    {
        if (_isHidden)
        {
            string blankWord = new string('_', _text.Length);
            return blankWord;
        }
        else
        {
            return _text;    
        }
    }
}