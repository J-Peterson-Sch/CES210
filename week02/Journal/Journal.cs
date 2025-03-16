
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
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in this._entries)
            {
                outputFile.WriteLine(entry.display());
            }
        }
    }

    public void loadFromFile()
    {
        string[] loadedEntries;
        Console.Clear();
        Console.Write("Enter the file name you want to load from: ");
        string loadFilePath = Console.ReadLine();

        if (File.Exists(loadFilePath))
        {
            loadedEntries = File.ReadAllLines(loadFilePath);

            foreach (string entry in loadedEntries){
                string[] splitEntry = entry.Split("|");
                addEntry(timestamp: splitEntry[0], promt: splitEntry[1], userEnteredText: splitEntry[2]);
            }
        }
        else
        {
            Console.WriteLine("File not found.");
            loadedEntries = new string[0];
        }

        if (loadedEntries.Length == 0)
        {
            Console.WriteLine("No entries were loaded.");
        }
    }   
}