using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var scriptures = new List<(Reference reference, string text)>
        {
            (new Reference("John", 3, 16), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."),
            (new Reference("Proverbs", 3, 5), "Trust in the Lord with all your heart and lean not on your own understanding;"),
            (new Reference("Psalm", 23, 1), "The Lord is my shepherd; I shall not want."),
            (new Reference("Romans", 8, 28), "And we know that in all things God works for the good of those who love him, who have been called according to his purpose."),
            (new Reference("James", 1 , 5), "If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him.")
        };

        while (true)
        {
            Random random = new Random();
            var selectedScripture = scriptures[random.Next(scriptures.Count)];

            var scripture = new Scripture(selectedScripture.reference, selectedScripture.text);

            while (true)
            {
                Console.Clear();
                scripture.DisplayScripture();

                Console.WriteLine("\nPress Enter to hide a word or type 'quit' to exit.");
                string userInput = Console.ReadLine().Trim();

                if (userInput.ToLower() == "quit")
                {
                    return;
                }

                if (!scripture.HideRandomWord())
                {
                    break;
                }
            }

            Console.Clear();
            scripture.DisplayScripture();
            Console.WriteLine("\nAll words are now hidden. Program will end.");
            break;
        }
    }
}