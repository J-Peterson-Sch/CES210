
using System;
using System.IO;
using System.Text.Json;

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
        Console.Clear();
        foreach (Entry entry in _entries)
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine($"{entry._date} - {entry._promptText}");
            Console.WriteLine(entry._entryText);
            Console.WriteLine("---------------------------------");
        }
    }

    public void saveToFile()
    {
        Console.Clear();
        Console.Write("Enter the file name you want to save to: ");
        string fileName = Console.ReadLine();
        string jsonString = JsonSerializer.Serialize(_entries, new JsonSerializerOptions{WriteIndented = true});
        File.WriteAllText(fileName, jsonString);
    }

    public void loadFromFile()
    {
        string loadedEntries;
        Console.Clear();
        Console.Write("Enter the file name you want to load from: ");
        string loadFilePath = Console.ReadLine();

        if (File.Exists(loadFilePath))
        {
            loadedEntries = File.ReadAllText(loadFilePath);
            _entries = JsonSerializer.Deserialize<List<Entry>>(loadedEntries);
        }
        else
        {
            Console.WriteLine("File not found. No entries were loaded.");
        }
    }
}