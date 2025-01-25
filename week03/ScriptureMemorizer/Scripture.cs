using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    public Reference ScriptureReference { get; private set; }
    private List<ScriptureWord> Words;

    public Scripture(Reference reference, string text)
    {
        ScriptureReference = reference;
        Words = text.Split(' ').Select(w => new ScriptureWord(w)).ToList();
    }

    public void DisplayScripture()
    {
        Console.WriteLine(ScriptureReference.ToString());
        foreach (var word in Words)
        {
            Console.Write(word.GetDisplayedWord() + " ");
        }
        Console.WriteLine();
    }

    public bool HideRandomWord()
    {
        var visibleWords = Words.Where(w => !w.IsHidden).ToList();

        if (visibleWords.Count == 0)
        {
            return false;
        }

        Random random = new Random();
        var wordToHide = visibleWords[random.Next(visibleWords.Count)];
        wordToHide.HideWord();

        return true;
    }

    public bool AreAllWordsHidden()
    {
        return Words.All(w => w.IsHidden);
    }
}