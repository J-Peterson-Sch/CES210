public class Entry {

    public string _date = "";
    public string _promptText = "";
    public string _entryText = "";

    public Entry(string promptText, string entryText, string timestamp)
    {
        _promptText = promptText;
        _entryText = entryText;

        if(String.IsNullOrEmpty(timestamp)){
            DateTime generatedTimestamp = DateTime.Now;
            _date = generatedTimestamp.ToString("MM-dd-yyyy HH:mm:ss");
        }
        else{
            _date = timestamp;
        }
    }

    public string display()
    {
        string contencedEntry = ($"{_date}|{_promptText}|{_entryText}");
        return contencedEntry;
    }
}