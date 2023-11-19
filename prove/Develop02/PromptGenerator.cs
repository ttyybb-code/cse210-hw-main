public class PromptGenerator
{
    string[] prompts;

    public PromptGenerator()
    {
        prompts = new string[]
        {
            "What's the best thing that happened to you today?",
            "Describe a new skill or hobby you'd like to try.",
            "Write about a goal you want to accomplish this week.",
            "What's your favorite way to relax after a long day?",
            "Describe a small act of kindness you witnessed or did.",
            "Write about something that made you laugh recently.",
            "What's a book, movie, or TV show you're currently enjoying?",
            "Write about a place in your neighborhood you appreciate.",
            "Describe a delicious meal or food you had recently.",
            "What's a challenge you faced today and how did you handle it?"
        };
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Length);

        return prompts[index];
    }
}