using System;

class Journal
{
    List<string> _entries = new List<string>
    {

    };
    public void Display()
    {
        Console.WriteLine($"{_entries}");
    }

    public void AddEntry(){}
}