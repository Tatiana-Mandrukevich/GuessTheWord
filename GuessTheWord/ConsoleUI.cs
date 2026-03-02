namespace GuesTheWord;

public class ConsoleUI
{
    public char InputLetter()
    {
        Console.Write("Enter a letter: ");
        string result = Console.ReadLine();
        return result[0];
    }
    
    public DifficultyType ChooseDifficulty()
    {
        Console.WriteLine("Choose difficulty: 1 - Easy, 2 - Normal, 3 - Hard");
        string result = Console.ReadLine();
        return (DifficultyType) int.Parse(result);
    }
}