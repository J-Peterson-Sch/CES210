using System.Text.Json.Serialization;

public class Entry {

    public string _date { get; set; }
    public string _promptText { get; set; }
    public string _entryText { get; set; }

    [JsonConstructor]
    public Entry(string _promptText, string _entryText, string _date)
    {
        this._promptText = _promptText;
        this._entryText = _entryText;

        if(String.IsNullOrEmpty(_date)){
            DateTime generatedTimestamp = DateTime.Now;
            this._date = generatedTimestamp.ToString("MM-dd-yyyy HH:mm:ss");
        }
        else{
            this._date = _date;
        }
    }

    public string display()
    {
        string contencedEntry = ($"{_date}|{_promptText}|{_entryText}");
        return contencedEntry;
    }
}