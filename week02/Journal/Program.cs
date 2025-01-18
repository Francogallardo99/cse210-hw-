using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
         var journal = new Journal();
        var promptGenerator = new PromptGenerator();
        while (true)
        {
            Console.WriteLine("Principal Menu");
            Console.WriteLine("1.Write in your journal");
            Console.WriteLine("2.Displey your jornal");
            Console.WriteLine("3.Save your jornal in a file");
            Console.WriteLine("4.Load jornal from a file");
            Console.WriteLine("0.Exit");
            var choise = Console.ReadLine();

            switch (choise)
            {
                case "1":
                var prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"Prompt : {prompt}");
                Console.Write("Your response: ");
                var response = Console.ReadLine();
                journal.AddEntry(prompt, response);
                Console.WriteLine("Entry added to your journal successfully\n");
                break;

                case "2":
                journal.DisplayEntries();
                break;

                case "3":
                Console.Write("Enter the filename to save the journal: ");
                string saveFileName = Console.ReadLine();
                Journal.SaveToFile(journal.Entries , saveFileName);
                Console.WriteLine($"The Journal is saved on {saveFileName}");
                break;

                case "4":
                Console.WriteLine("Enter the filename to load: ");
                var loadFilename = Console.ReadLine();
                List<Entry> loadedEntries = Journal.ReadFromFile(loadFilename);
                Console.WriteLine("Entries loaded from the file: ");
                foreach (var entry in loadedEntries)    
                {
                    Console.WriteLine($"Date: {entry._date} , prompt:{entry._promptText} , Res´pmse : {entry._entry}");
                }
                break;

                case "0":
                Console.WriteLine("Goodbye");
                return;

                default:
                Console.WriteLine("Invalid option! Try again");
                break;
            }   
        }
        
    }
}