using System;

public class Entry
{
    public string _date;
    public string _entry;
    public string _promptText;
    public void Display()
    {
        Console.WriteLine($"{_date}\n{_promptText}\n{_entry}");
    }
    
}