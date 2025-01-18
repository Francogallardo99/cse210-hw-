using System;

public class PromptGenerator
{
    private List<string> prompts;
    public PromptGenerator()
    {
        prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What was the moment that made you smile the most today?",
            "How did I overcome the difficulties I faced today?",
            "How was your day at work?",
            "What did I learn from my scripture reading today?"
        };
    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }
}