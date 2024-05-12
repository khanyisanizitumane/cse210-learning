using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        // Create a scripture
        Scripture scripture = new Scripture("John 3:16", "For God so loved the world...");

        // Display scripture and allow user interaction
        while (!scripture.AllWordsHidden)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide more words, or type 'quit' to exit:");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;
            else
                scripture.HideRandomWords();
        }
    }
}

public class Scripture
{
    private List<Word> words = new List<Word>();
    private bool allWordsHidden = false;

    public bool AllWordsHidden { get { return allWordsHidden; } }

    public Scripture(string reference, string text)
    {
        Reference = new Reference(reference);
        AddWords(text);
    }

    private Reference Reference { get; }

    public void AddWords(string text)
    {
        string[] wordArray = text.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        foreach (string wordText in wordArray)
        {
            words.Add(new Word(wordText));
        }
    }

    public void HideRandomWords()
    {
        Random random = new Random();
        List<Word> visibleWords = words.Where(word => !word.Hidden).ToList();
        if (visibleWords.Count == 0)
        {
            allWordsHidden = true;
            return;
        }
        int randomIndex = random.Next(visibleWords.Count);
        visibleWords[randomIndex].Hide();
    }

    public string GetDisplayText()
    {
        string displayText = $"{Reference.GetDisplayText()}\n\n";
        foreach (Word word in words)
        {
            displayText += word.GetDisplayText() + " ";
        }
        return displayText;
    }
}

public class Reference
{
    private string reference;

    public Reference(string reference)
    {
        this.reference = reference;
    }

    public string GetDisplayText()
    {
        return reference;
    }
}

public class Word
{
    private string text;
    private bool hidden;

    public bool Hidden { get { return hidden; } }

    public Word(string text)
    {
        this.text = text;
    }

    public void Hide()
    {
        hidden = true;
    }

    public string GetDisplayText()
    {
        return hidden ? "*****" : text;
    }
}
