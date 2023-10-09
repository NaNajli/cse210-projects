using System;
using System.Collections.Generic;
public class PromptGenerator{
    public List<string>_prompt;

    public PromptGenerator()
    {
    _prompt = new List<string>

    {"Who was the most interesting person I interacted with today?",
     "What was the best part of my day?",
     "How did I see the hand of the Lord in my life today?",
     "What was the strongest emotion I felt today?",
     "If I had one thing I could do over today, what would it be?",
     "What is something unexpected that happened today? ",
     "List three things that you are grateful for?",
     "What is something you would want to again from today?",
    };
    }
    public string RandomPrompt()
    {
    Random random = new Random();
    int index = random.Next(_prompt.Count);
    return _prompt[index];
}}