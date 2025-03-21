// Jordan Peterson
// Added a restart functionality to help the user start over without haveing to restart the program.

using System;

class Program
{
    private static Reference _reference = new Reference("1 Samuel", 3, 7, 8);
    private static string _text = """
    Then said Saul unto his servants, Seek me a woman that hath
    a familiar spirit, that I may go to her, and inquire of her. And his servants said to
    him, Behold, there is a woman that hath a familiar spirit at En-dor.
    And the woman said unto him, Behold, thou knowest what Saul hath done, how he hath cut
    off those that have familiar spirits, and the wizards, out of the land: wherefore then
    layest thou a snare for my life, to cause me to die?
    """;
    
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture(_reference, _text);
        string input = "";
        do
        {
            printToScreen(scripture);
            input = Console.ReadLine();

            if (input == "")
            {
                scripture.blankOutWords(5);
            }
            else if (input == "restart")
            {
                scripture.resetWordVisibility();
            }
            
        } while (input != "quit");
    }

    static void printToScreen(Scripture scripture)
    {
        Console.Clear();
        Console.WriteLine(scripture.display());
        Console.WriteLine();
        Console.WriteLine("Press enter to continue, type 'quit' to finish or 'restart' to start over: ");
    }
}