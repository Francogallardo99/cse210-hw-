using System;
using System.Data;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Xml;
using System.IO;
public class Journal
{
    public List<Entry> Entries;
    private List<string> prompts;
    public Journal()
    {
        Entries = new List<Entry>();
    }
    public void AddEntry(string prompt , string response)
    {
        var entry = new Entry
        {
            _date = DateTime.Now.ToString("yyyy:MM:dd :HH :mm"),
            _promptText = prompt,
            _entry = response
        };
        Entries.Add(entry);
    }
    public void DisplayEntries()
    {
        if(Entries.Count == 0)
        {
            Console.WriteLine("Your journal is empty.");
        }
        else
        {
            foreach (var entry in Entries)
            {
                Console.WriteLine($"Date: {entry._date}");
                Console.WriteLine($"Prompt: {entry._promptText}");
                Console.WriteLine($"Responde: {entry._entry}");
                Console.WriteLine(new string('|', 40));
            }
        }
    }
    public static void SaveToFile(List<Entry> entries, string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry j in entries)
            {
                outputFile.WriteLine($"{j._date}~|~{j._promptText}~|~{j._entry}");
            }
        }
    }
    public static List<Entry> ReadFromFile(string fileName)
    {
        Console.WriteLine("Reading file...");
        List<Entry> entries = new List<Entry>();
        string filename = "journal.txt";
        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(fileName);
            foreach (string line in lines)
            {
                string[] parts = line.Split(new string[] { "~|~" }, StringSplitOptions.None);
                if (parts.Length==3)
                {
                    var entry = new Entry
                    {
                        _date = parts[0],
                        _promptText = parts[1],
                        _entry = parts[2]
                    };
                    entries.Add(entry);
                }
            }
        }
        else
        {
            Console.WriteLine("File not found");
        }
        return entries;
    }
}