public class Journal {

    public List<Entry> _entries = new List<Entry>();

    public Journal()
    {

    }

    public void addEntry(string promt, string userEnteredText, string timestamp)
    {
        Entry newEntry = new Entry(promt,userEnteredText,timestamp);
        _entries.Add(newEntry);
    }

    public void displayAll()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine($"{entry._date} - {entry._promptText}");
            Console.WriteLine(entry._entryText);
            Console.WriteLine("---------------------------------");
        }
    }
}