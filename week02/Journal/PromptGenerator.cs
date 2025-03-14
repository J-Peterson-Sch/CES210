public class PromptGenerator{

    private string[] prompts;

    public PromptGenerator(string filePath)
    {
        if (File.Exists(filePath))
        {
            prompts = File.ReadAllLines(filePath);
        }
        else
        {
            Console.WriteLine("File not found.");
            prompts = new string[0];
        }
    }
    public string getRandomPrompt(){
        if (prompts.Length == 0)
        {
            return "No prompts available.";
        }

        Random random = new Random();
        int index = random.Next(prompts.Length);
        return prompts[index];
    }
}