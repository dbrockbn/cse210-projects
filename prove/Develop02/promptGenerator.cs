using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public static List<string> prompt = new List<string>()
    {
    "What was the best part of my day?",
    "How did I see the hand of the Lord in my life today?",
    "What was the strongest emotion I felt today?",
    "If I had one thing I could change today, what would it be?",
    "What tender mercies did I see today?",
    "What is something I'm proud of doing today?",
    "Did I do any act(s) of service today?"};
    
    private static Random rnd = new Random();
    
    static int randIndex = rnd.Next(prompt.Count);
    string random = prompt[randIndex];
    public string _GetRandomPrompt = "";
    
    Console.WriteLine (random);

}
